using Examen___Programmeren___Moba_Teamplanner.Data;
using Examen___Programmeren___Moba_Teamplanner.Enums;
using Examen___Programmeren___Moba_Teamplanner.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen___Programmeren___Moba_Teamplanner.Forms
{
    public partial class PlayerForms : Form
    {
        private readonly AppDbContext _context;
        private Player? _selectedPlayer;
        private bool _rankSortAscending = true;
        private bool _sortByRank = false;

        public PlayerForms()
        {
            InitializeComponent();
            _context = new AppDbContext();
            LoadDDL();
            LoadPlayers();
        }

        private void LoadDDL()
        {
            ddlFilterRoles.Items.Clear();
            ddlFilterRoles.Items.Add("All Roles");

            foreach (Role role in Enum.GetValues(typeof(Role)))
            {
                ddlFilterRoles.Items.Add(role);
            }

            ddlFilterRoles.SelectedIndex = 0;

            ddlBestRole.DataSource = Enum.GetValues(typeof(Role));

            var secondaryRoleOptions = new List<object> { "None" };

            secondaryRoleOptions.AddRange(Enum.GetValues(typeof(Role)).Cast<object>());
            ddlSecondaryRole.DataSource = secondaryRoleOptions;

            ddlRank.DataSource = Enum.GetValues(typeof(Rank));
        }

        private void LoadPlayers()
        {
            var players = GetFilteredPlayers();

            dgvPlayers.DataSource = players.Select(p => new
            {
                p.Id,
                p.IGN,
                Name = p.Name ?? "-",
                Role = p.BestRole.ToString(),
                FlexibleRole = p.SecondaryRole.HasValue ? p.SecondaryRole.Value.ToString() : "-",
                Rank = p.Rank.ToString(),
                Active = p.IsActive ? "✔" : "✘"
            }).ToList();

            if (dgvPlayers.Columns["Id"] != null)
                dgvPlayers.Columns["Id"].Visible = false;
        }

        private void dgvPlayers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPlayers.SelectedRows.Count == 0) return;

            var row = dgvPlayers.SelectedRows[0];
            int id = (int)row.Cells["Id"].Value;
            _selectedPlayer = _context.Players.FirstOrDefault(p => p.Id == id);

            if (_selectedPlayer == null) return;

            txtIGN.Text = _selectedPlayer.IGN;
            txtName.Text = _selectedPlayer.Name ?? "";
            ddlBestRole.SelectedItem = _selectedPlayer.BestRole;
            ddlSecondaryRole.SelectedItem = _selectedPlayer.SecondaryRole.HasValue ? (object)_selectedPlayer.SecondaryRole.Value : "None";
            ddlRank.SelectedItem = _selectedPlayer.Rank;
            chkIsActive.Checked = _selectedPlayer.IsActive;
            rtxtDescription.Text = _selectedPlayer.Description ?? "";

            btnSave.Enabled = true;
            btnDelete.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIGN.Text))
            {
                MessageBox.Show("IGN is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var player = new Player
            {
                IGN = txtIGN.Text.Trim(),
                Name = string.IsNullOrWhiteSpace(txtName.Text) ? null : txtName.Text.Trim(),
                BestRole = (Role)ddlBestRole.SelectedItem,
                SecondaryRole = GetSelectedSecondaryRole(),
                Rank = (Rank)ddlRank.SelectedItem,
                IsActive = chkIsActive.Checked,
                Description = string.IsNullOrWhiteSpace(rtxtDescription.Text) ? null : rtxtDescription.Text.Trim()
            };

            _context.Players.Add(player);
            _context.SaveChanges();
            MessageBox.Show("Player added!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForm();
            LoadPlayers();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_selectedPlayer == null) return;

            if (string.IsNullOrWhiteSpace(txtIGN.Text))
            {
                MessageBox.Show("IGN is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _selectedPlayer.IGN = txtIGN.Text.Trim();
            _selectedPlayer.Name = string.IsNullOrWhiteSpace(txtName.Text) ? null : txtName.Text.Trim();
            _selectedPlayer.BestRole = (Role)ddlBestRole.SelectedItem;
            _selectedPlayer.SecondaryRole = GetSelectedSecondaryRole();
            _selectedPlayer.Rank = (Rank)ddlRank.SelectedItem;
            _selectedPlayer.IsActive = chkIsActive.Checked;
            _selectedPlayer.Description = string.IsNullOrWhiteSpace(rtxtDescription.Text) ? null : rtxtDescription.Text.Trim();

            _context.Players.Update(_selectedPlayer);
            _context.SaveChanges();
            MessageBox.Show("Player changed!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForm();
            LoadPlayers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedPlayer == null) return;

            var confirm = MessageBox.Show($"Do you want to remove: {_selectedPlayer.IGN} ?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                _context.Players.Remove(_selectedPlayer);
                _context.SaveChanges();
                MessageBox.Show("Player removed!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadPlayers();
            }
        }

        private void ClearForm()
        {
            _selectedPlayer = null;
            txtIGN.Text = "";
            txtName.Text = "";
            ddlBestRole.SelectedIndex = 0;
            ddlSecondaryRole.SelectedIndex = 0;
            ddlRank.SelectedItem = Rank.Unranked;
            chkIsActive.Checked = false;
            rtxtDescription.Text = "";
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnAdd.Enabled = true;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadPlayers();
        }

        private void ddlFilterRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPlayers();
        }

        private void chkActiveOnly_CheckedChanged(object sender, EventArgs e)
        {
            LoadPlayers();
        }
        private Role? GetSelectedSecondaryRole()
        {
            return ddlSecondaryRole.SelectedItem is Role role ? role : null;
        }

        private void btnSortRank_Click(object sender, EventArgs e)
        {
            _sortByRank = true;
            _rankSortAscending = !_rankSortAscending;
            LoadPlayers();
        }

        private List<Player> GetFilteredPlayers()
        {
            var players = _context.Players.ToList();

            // Zoekfilter
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
                players = players
                    .Where(p => p.IGN.Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase))
                    .ToList();

            // Rolfilter
            if (ddlFilterRoles.SelectedIndex > 0 && ddlFilterRoles.SelectedItem is Role selectedRole)
                players = players.Where(p => p.BestRole == selectedRole).ToList();

            // Actief filter
            if (chkActiveOnly.Checked)
                players = players.Where(p => p.IsActive).ToList();

            // Sorteren op rank (indien actief)
            if (_sortByRank)
            {
                players = _rankSortAscending
                    ? players.OrderBy(p => p.Rank).ToList()
                    : players.OrderByDescending(p => p.Rank).ToList();
            }

            return players;
        }
    }
}
