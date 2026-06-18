using Examen___Programmeren___Moba_Teamplanner.Data;
using Examen___Programmeren___Moba_Teamplanner.Enums;
using Examen___Programmeren___Moba_Teamplanner.Models;
using Microsoft.EntityFrameworkCore;

namespace Examen___Programmeren___Moba_Teamplanner.Forms
{
    public partial class MatchForm : Form
    {
        private readonly AppDbContext _context;
        private Match? _selectedMatch;

        public MatchForm()
        {
            InitializeComponent();
            _context = new AppDbContext();

            dgvMatches.SelectionChanged += dgvMatches_SelectionChanged;

            LoadDDL();
            LoadMatches();
            ClearForm();
        }

        private void LoadDDL()
        {
            var teams = _context.Teams
                .OrderBy(t => t.Name)
                .ToList();

            ddlTeam.DataSource = null;
            ddlTeam.DisplayMember = "Name";
            ddlTeam.ValueMember = "Id";
            ddlTeam.DataSource = teams;

            ddlOpponent.Items.Clear();
            foreach (var team in teams)
            {
                ddlOpponent.Items.Add(team.Name);
            }

            if (ddlOpponent.Items.Count > 0)
                ddlOpponent.SelectedIndex = 0;

            ddlResult.DataSource = Enum.GetValues(typeof(MatchResult));

            ddlFilterResult.Items.Clear();
            ddlFilterResult.Items.Add("All Results");

            foreach (MatchResult result in Enum.GetValues(typeof(MatchResult)))
            {
                ddlFilterResult.Items.Add(result);
            }

            ddlFilterResult.SelectedIndex = 0;
        }

        private void LoadMatches()
        {
            var matches = GetFilteredMatches();

            dgvMatches.DataSource = matches.Select(m => new
            {
                m.Id,
                Date = m.Date.ToShortDateString(),
                Team = m.Team.Name,
                m.Opponent,
                Result = m.Result.ToString(),
                Duration = m.Duration.HasValue ? $"{m.Duration.Value.TotalMinutes} min" : "-",
                Champions = GetChampionOverview(m),
                Notes = m.Notes ?? "-"
            }).ToList();

            if (dgvMatches.Columns["Id"] != null)
                dgvMatches.Columns["Id"].Visible = false;
        }

        private List<Match> GetFilteredMatches()
        {
            var matches = _context.Matches
                .Include(m => m.Team)
                .Include(m => m.Participations)
                    .ThenInclude(p => p.Player)
                .Include(m => m.Participations)
                    .ThenInclude(p => p.Champ)
                .ToList();

            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                matches = matches
                    .Where(m => m.Team.Name.Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            if (ddlFilterResult.SelectedIndex > 0 && ddlFilterResult.SelectedItem is MatchResult selectedResult)
            {
                matches = matches
                    .Where(m => m.Result == selectedResult)
                    .ToList();
            }

            return matches
                .OrderByDescending(m => m.Date)
                .ToList();
        }

        private string GetChampionOverview(Match match)
        {
            if (match.Participations.Count == 0)
                return "-";

            return string.Join(", ", match.Participations
                .OrderBy(p => p.Player.IGN)
                .Select(p => $"{p.Player.IGN}: {p.Champ.Name}"));
        }

        private void dgvMatches_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvMatches.SelectedRows.Count == 0) return;

            var row = dgvMatches.SelectedRows[0];
            int id = (int)row.Cells["Id"].Value;

            _selectedMatch = _context.Matches
                .Include(m => m.Team)
                .FirstOrDefault(m => m.Id == id);

            if (_selectedMatch == null) return;

            dtpDate.Value = _selectedMatch.Date;
            ddlTeam.SelectedValue = _selectedMatch.TeamId;
            ddlResult.SelectedItem = _selectedMatch.Result;
            txtDuration.Text = _selectedMatch.Duration.HasValue
                ? _selectedMatch.Duration.Value.TotalMinutes.ToString()
                : "";
            rtxtDescription.Text = _selectedMatch.Notes ?? "";

            if (!ddlOpponent.Items.Contains(_selectedMatch.Opponent))
                ddlOpponent.Items.Add(_selectedMatch.Opponent);

            ddlOpponent.SelectedItem = _selectedMatch.Opponent;

            btnSave.Enabled = true;
            btnDelete.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var (success, message, match) = BuildMatchFromForm();

            if (!success)
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _context.Matches.Add(match!);
            _context.SaveChanges();

            MessageBox.Show("Match added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            using (var championForm = new MatchChampionForm(match.Id))
            {
                championForm.ShowDialog();
            }

            ClearForm();
            LoadMatches();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_selectedMatch == null) return;

            var (success, message, match) = BuildMatchFromForm();

            if (!success)
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _selectedMatch.Date = match!.Date;
            _selectedMatch.TeamId = match.TeamId;
            _selectedMatch.Opponent = match.Opponent;
            _selectedMatch.Result = match.Result;
            _selectedMatch.Duration = match.Duration;
            _selectedMatch.Notes = match.Notes;

            _context.Matches.Update(_selectedMatch);
            _context.SaveChanges();

            MessageBox.Show("Match updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearForm();
            LoadMatches();
        }

        private void btnChampions_Click(object sender, EventArgs e)
        {
            if (_selectedMatch == null)
            {
                MessageBox.Show("Select a match first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var championForm = new MatchChampionForm(_selectedMatch.Id);
            championForm.ShowDialog();
            LoadMatches();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedMatch == null) return;

            var confirm = MessageBox.Show($"Remove match against {_selectedMatch.Opponent}?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                _context.Matches.Remove(_selectedMatch);
                _context.SaveChanges();

                MessageBox.Show("Match removed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();
                LoadMatches();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadMatches();
        }

        private void ddlFilterResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatches();
        }

        private (bool success, string message, Match? match) BuildMatchFromForm()
        {
            if (ddlTeam.SelectedItem is not Team selectedTeam)
                return (false, "Team is required.", null);

            if (ddlOpponent.SelectedItem == null)
                return (false, "Opponent is required.", null);

            if (ddlResult.SelectedItem is not MatchResult selectedResult)
                return (false, "Result is required.", null);

            TimeSpan? duration = null;

            if (!string.IsNullOrWhiteSpace(txtDuration.Text))
            {
                if (!int.TryParse(txtDuration.Text, out int minutes) || minutes < 0)
                    return (false, "Duration must be a valid number.", null);

                duration = TimeSpan.FromMinutes(minutes);
            }

            var match = new Match
            {
                Date = dtpDate.Value,
                TeamId = selectedTeam.Id,
                Opponent = ddlOpponent.SelectedItem.ToString()!,
                Result = selectedResult,
                Duration = duration,
                Notes = string.IsNullOrWhiteSpace(rtxtDescription.Text) ? null : rtxtDescription.Text.Trim()
            };

            return (true, "OK", match);
        }

        private void ClearForm()
        {
            _selectedMatch = null;

            dtpDate.Value = DateTime.Now;

            if (ddlTeam.Items.Count > 0)
                ddlTeam.SelectedIndex = 0;

            if (ddlOpponent.Items.Count > 0)
                ddlOpponent.SelectedIndex = 0;

            ddlResult.SelectedItem = MatchResult.Planned;
            txtDuration.Text = "";
            rtxtDescription.Text = "";

            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnAdd.Enabled = true;
        }
    }
}
