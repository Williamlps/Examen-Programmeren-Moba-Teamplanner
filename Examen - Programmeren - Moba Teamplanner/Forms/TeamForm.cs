using Examen___Programmeren___Moba_Teamplanner.Data;
using Examen___Programmeren___Moba_Teamplanner.Enums;
using Examen___Programmeren___Moba_Teamplanner.Models;
using Microsoft.EntityFrameworkCore;

namespace Examen___Programmeren___Moba_Teamplanner.Forms
{
    public partial class TeamForm : Form
    {
        private readonly AppDbContext _context;
        private Team? _selectedTeam;

        public TeamForm()
        {
            InitializeComponent();
            _context = new AppDbContext();
            LoadDDL();
            LoadTeams();
        }

        private void LoadDDL()
        {
            FillRoleComboBox(ddlTop, Role.Top);
            FillRoleComboBox(ddlJungle, Role.Jungle);
            FillRoleComboBox(ddlMid, Role.Mid);
            FillRoleComboBox(ddlADC, Role.ADC);
            FillRoleComboBox(ddlSupport, Role.Support);
        }

        private void FillRoleComboBox(ComboBox ddl, Role role)
        {
            var players = _context.Players
                .Where(p => p.IsActive && (p.BestRole == role || p.SecondaryRole == role))
                .OrderBy(p => p.IGN)
                .ToList();

            ddl.DataSource = null;
            ddl.DisplayMember = "IGN";
            ddl.DataSource = players;
        }

        private void LoadTeams()
        {
            var teams = _context.Teams
                .Include(t => t.PlayersTeam)
                    .ThenInclude(pt => pt.Player)
                .ToList();

            dgvTeams.DataSource = teams.Select(t => new
            {
                t.Id,
                Team = t.Name,
                Top = GetPlayerInRole(t, Role.Top),
                Jungle = GetPlayerInRole(t, Role.Jungle),
                Mid = GetPlayerInRole(t, Role.Mid),
                ADC = GetPlayerInRole(t, Role.ADC),
                Support = GetPlayerInRole(t, Role.Support)
            }).ToList();

            if (dgvTeams.Columns["Id"] != null)
                dgvTeams.Columns["Id"].Visible = false;
        }

        private string GetPlayerInRole(Team team, Role role)
        {
            var pt = team.PlayersTeam.FirstOrDefault(pt => pt.AssignedRole == role);
            return pt?.Player.IGN ?? "-";
        }

        private void dgvTeams_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTeams.SelectedRows.Count == 0) return;

            var row = dgvTeams.SelectedRows[0];
            int id = (int)row.Cells["Id"].Value;

            _selectedTeam = _context.Teams
                .Include(t => t.PlayersTeam)
                    .ThenInclude(pt => pt.Player)
                .FirstOrDefault(t => t.Id == id);

            if (_selectedTeam == null) return;

            txtTeamName.Text = _selectedTeam.Name;

            SetComboBoxSelection(ddlTop, Role.Top);
            SetComboBoxSelection(ddlJungle, Role.Jungle);
            SetComboBoxSelection(ddlMid, Role.Mid);
            SetComboBoxSelection(ddlADC, Role.ADC);
            SetComboBoxSelection(ddlSupport, Role.Support);

            btnSave.Enabled = true;
            btnDelete.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void SetComboBoxSelection(ComboBox ddl, Role role)
        {
            var pt = _selectedTeam!.PlayersTeam.FirstOrDefault(pt => pt.AssignedRole == role);
            if (pt == null) return;

            for (int i = 0; i < ddl.Items.Count; i++)
            {
                if (ddl.Items[i] is Player p && p.Id == pt.PlayerId)
                {
                    ddl.SelectedIndex = i;
                    return;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var (success, message, team) = BuildTeamFromForm();

            if (!success)
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _context.Teams.Add(team!);
            _context.SaveChanges();
            MessageBox.Show("Team added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForm();
            LoadDDL();
            LoadTeams();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_selectedTeam == null) return;

            var (success, message, team) = BuildTeamFromForm();

            if (!success)
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _selectedTeam.Name = team!.Name;

            _context.PlayerTeams.RemoveRange(_selectedTeam.PlayersTeam);
            _selectedTeam.PlayersTeam = team.PlayersTeam;

            _context.Teams.Update(_selectedTeam);
            _context.SaveChanges();
            MessageBox.Show("Team updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForm();
            LoadDDL();
            LoadTeams();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedTeam == null) return;

            var confirm = MessageBox.Show($"Remove team {_selectedTeam.Name}?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                _context.Teams.Remove(_selectedTeam);
                _context.SaveChanges();
                MessageBox.Show("Team removed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadDDL();
                LoadTeams();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private (bool success, string message, Team? team) BuildTeamFromForm()
        {
            if (string.IsNullOrWhiteSpace(txtTeamName.Text))
                return (false, "Team name is required.", null);

            if (ddlTop.SelectedItem is not Player ||
                ddlJungle.SelectedItem is not Player ||
                ddlMid.SelectedItem is not Player ||
                ddlADC.SelectedItem is not Player ||
                ddlSupport.SelectedItem is not Player)
            {
                return (false, "Every role must have a player assigned.", null);
            }

            var playerTeams = new List<PlayerTeam>();
            AddPlayer(playerTeams, ddlTop, Role.Top);
            AddPlayer(playerTeams, ddlJungle, Role.Jungle);
            AddPlayer(playerTeams, ddlMid, Role.Mid);
            AddPlayer(playerTeams, ddlADC, Role.ADC);
            AddPlayer(playerTeams, ddlSupport, Role.Support);

            var playerIds = playerTeams.Select(pt => pt.PlayerId).ToList();
            if (playerIds.Distinct().Count() != playerIds.Count)
                return (false, "The same player cannot be in the team twice.", null);

            var team = new Team
            {
                Name = txtTeamName.Text.Trim(),
                PlayersTeam = playerTeams
            };

            return (true, "OK", team);
        }

        private void AddPlayer(List<PlayerTeam> list, ComboBox ddl, Role role)
        {
            var player = (Player)ddl.SelectedItem;
            list.Add(new PlayerTeam
            {
                PlayerId = player.Id,
                AssignedRole = role
            });
        }

        private void ClearForm()
        {
            _selectedTeam = null;
            txtTeamName.Text = "";

            if (ddlTop.Items.Count > 0) ddlTop.SelectedIndex = 0;
            if (ddlJungle.Items.Count > 0) ddlJungle.SelectedIndex = 0;
            if (ddlMid.Items.Count > 0) ddlMid.SelectedIndex = 0;
            if (ddlADC.Items.Count > 0) ddlADC.SelectedIndex = 0;
            if (ddlSupport.Items.Count > 0) ddlSupport.SelectedIndex = 0;

            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnAdd.Enabled = true;
        }
    }
}