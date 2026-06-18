using Examen___Programmeren___Moba_Teamplanner.Data;
using Examen___Programmeren___Moba_Teamplanner.Models;
using Microsoft.EntityFrameworkCore;

namespace Examen___Programmeren___Moba_Teamplanner.Forms
{
    public class MatchChampionForm : Form
    {
        private readonly int _matchId;
        private readonly AppDbContext _context;
        private readonly TableLayoutPanel _table;
        private readonly Button _btnSave;
        private readonly Button _btnCancel;
        private readonly List<(Player player, ComboBox ddlChampion)> _rows = new();

        public MatchChampionForm(int matchId)
        {
            _matchId = matchId;
            _context = new AppDbContext();

            Text = "Match champions";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            ClientSize = new Size(620, 420);

            var title = new Label
            {
                Text = "Champions per player",
                Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0),
                Location = new Point(20, 15),
                Size = new Size(560, 45)
            };

            _table = new TableLayoutPanel
            {
                Location = new Point(20, 80),
                Size = new Size(560, 250),
                ColumnCount = 3,
                AutoScroll = true
            };
            _table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120));
            _table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 190));
            _table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 230));

            _btnSave = new Button
            {
                Text = "Save",
                Location = new Point(360, 350),
                Size = new Size(100, 45)
            };
            _btnSave.Click += btnSave_Click;

            _btnCancel = new Button
            {
                Text = "Cancel",
                Location = new Point(480, 350),
                Size = new Size(100, 45)
            };
            _btnCancel.Click += (_, _) => Close();

            Controls.Add(title);
            Controls.Add(_table);
            Controls.Add(_btnSave);
            Controls.Add(_btnCancel);

            LoadRows();
        }

        private void LoadRows()
        {
            var match = _context.Matches
                .Include(m => m.Team)
                    .ThenInclude(t => t.PlayersTeam)
                        .ThenInclude(pt => pt.Player)
                .Include(m => m.Participations)
                .FirstOrDefault(m => m.Id == _matchId);

            if (match == null)
            {
                MessageBox.Show("Match not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
                return;
            }

            var champions = _context.Champions
                .OrderBy(c => c.Name)
                .ToList();

            _table.Controls.Clear();
            _rows.Clear();

            AddHeader("Role", 0);
            AddHeader("Player", 1);
            AddHeader("Champion", 2);

            int rowIndex = 1;
            foreach (var playerTeam in match.Team.PlayersTeam.OrderBy(pt => pt.AssignedRole))
            {
                var championsForRole = champions
                    .Where(c => c.MainRole == playerTeam.AssignedRole)
                    .ToList();

                var roleLabel = CreateLabel(playerTeam.AssignedRole.ToString());
                var playerLabel = CreateLabel(playerTeam.Player.IGN);
                var ddlChampion = new ComboBox
                {
                    DropDownStyle = ComboBoxStyle.DropDownList,
                    DisplayMember = "Name",
                    ValueMember = "Id",
                    DataSource = championsForRole,
                    Dock = DockStyle.Fill
                };

                var existingParticipation = match.Participations
                    .FirstOrDefault(p => p.PlayerId == playerTeam.PlayerId);

                if (existingParticipation != null && championsForRole.Any(c => c.Id == existingParticipation.ChampId))
                    ddlChampion.SelectedValue = existingParticipation.ChampId;
                else if (ddlChampion.Items.Count > 0)
                    ddlChampion.SelectedIndex = 0;

                _table.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
                _table.Controls.Add(roleLabel, 0, rowIndex);
                _table.Controls.Add(playerLabel, 1, rowIndex);
                _table.Controls.Add(ddlChampion, 2, rowIndex);
                _rows.Add((playerTeam.Player, ddlChampion));
                rowIndex++;
            }

            if (_rows.Count == 0)
            {
                MessageBox.Show("This match has no players because the selected team is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _btnSave.Enabled = false;
            }
        }

        private void AddHeader(string text, int column)
        {
            _table.Controls.Add(new Label
            {
                Text = text,
                Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft
            }, column, 0);
        }

        private static Label CreateLabel(string text)
        {
            return new Label
            {
                Text = text,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft
            };
        }

        private void btnSave_Click(object? sender, EventArgs e)
        {
            var existingParticipations = _context.GameParticipations
                .Where(p => p.MatchId == _matchId)
                .ToList();

            _context.GameParticipations.RemoveRange(existingParticipations);

            foreach (var row in _rows)
            {
                if (row.ddlChampion.SelectedValue is not int championId)
                {
                    MessageBox.Show("Every player must have a champion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _context.GameParticipations.Add(new GameParticipation
                {
                    MatchId = _matchId,
                    PlayerId = row.player.Id,
                    ChampId = championId
                });
            }

            _context.SaveChanges();
            MessageBox.Show("Champions saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                _context.Dispose();

            base.Dispose(disposing);
        }
    }
}
