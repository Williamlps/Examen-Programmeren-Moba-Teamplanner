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
using System.Xml.Linq;

namespace Examen___Programmeren___Moba_Teamplanner.Forms
{
    public partial class ChampForm : Form
    {
        private readonly AppDbContext _context;
        private Champ? _selectedChamp;

        public ChampForm()
        {
            InitializeComponent();
            _context = new AppDbContext();
            LoadDDL();
            LoadChamps();
        }

        private void LoadDDL()
        {
            ddlFilterRoles.Items.Clear();
            ddlFilterRoles.Items.Add("All Roles");

            foreach (Role role in Enum.GetValues(typeof(Role)))
                ddlFilterRoles.Items.Add(role);
            ddlFilterRoles.SelectedIndex = 0;

            clbTypes.Items.Clear();
            foreach (ChampionType type in Enum.GetValues(typeof(ChampionType)))
                clbTypes.Items.Add(type);

            ddlMainRole.DataSource = Enum.GetValues(typeof(Role));
            ddlDifficulty.DataSource = Enum.GetValues(typeof(Difficulty));
        }

        private void LoadChamps()
        {
            var champs = _context.Champions.ToList();

            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
                champs = champs
                    .Where(c => c.Name.Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase))
                    .ToList();

            if (ddlFilterRoles.SelectedIndex > 0 && ddlFilterRoles.SelectedItem is Role selectedRole)
                champs = champs.Where(c => c.MainRole == selectedRole).ToList();

            if (chkIsFavorite.Checked)
                champs = champs.Where(c => c.IsFavorite).ToList();

            dgvChamps.DataSource = champs.Select(c => new
            {
                c.Id,
                c.Name,
                Role = c.MainRole.ToString(),
                Type = c.Type.ToString(),
                c.Difficulty,
                Favorite = c.IsFavorite ? "⭐" : ""
            }).ToList();

            if (dgvChamps.Columns["Id"] != null)
                dgvChamps.Columns["Id"].Visible = false;
        }

        private ChampionType GetSelectedTypes()
        {
            ChampionType selectedTypes = 0;
            foreach (var item in clbTypes.CheckedItems)
                selectedTypes |= (ChampionType)item;
            return selectedTypes;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadChamps();
        }

        private void dgvChamps_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvChamps.SelectedRows.Count == 0) return;

            var row = dgvChamps.SelectedRows[0];
            int id = (int)row.Cells["Id"].Value;
            _selectedChamp = _context.Champions.FirstOrDefault(c => c.Id == id);

            if (_selectedChamp == null) return;

            txtChampion.Text = _selectedChamp.Name;
            ddlMainRole.SelectedItem = _selectedChamp.MainRole;

            for (int i = 0; i < clbTypes.Items.Count; i++)
                clbTypes.SetItemChecked(i, false);

            for (int i = 0; i < clbTypes.Items.Count; i++)
            {
                if (_selectedChamp.Type.HasFlag((ChampionType)clbTypes.Items[i]))
                    clbTypes.SetItemChecked(i, true);
            }

            ddlDifficulty.SelectedItem = _selectedChamp.Difficulty;
            chkIsFavorite.Checked = _selectedChamp.IsFavorite;

            btnSave.Enabled = true;
            btnDelete.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtChampion.Text))
            {
                MessageBox.Show("Name is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var champ = new Champ
            {
                Name = txtChampion.Text.Trim(),
                MainRole = (Role)ddlMainRole.SelectedItem,
                Type = GetSelectedTypes(),
                Difficulty = (Difficulty)ddlDifficulty.SelectedItem,
                IsFavorite = chkIsFavorite.Checked
            };

            _context.Champions.Add(champ);
            _context.SaveChanges();
            MessageBox.Show("Champion added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForm();
            LoadChamps();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_selectedChamp == null) return;

            if (string.IsNullOrWhiteSpace(txtChampion.Text))
            {
                MessageBox.Show("Name is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _selectedChamp.Name = txtChampion.Text.Trim();
            _selectedChamp.MainRole = (Role)ddlMainRole.SelectedItem;
            _selectedChamp.Type = GetSelectedTypes();
            _selectedChamp.Difficulty = (Difficulty)ddlDifficulty.SelectedItem;
            _selectedChamp.IsFavorite = chkIsFavorite.Checked;

            _context.Champions.Update(_selectedChamp);
            _context.SaveChanges();
            MessageBox.Show("Champion updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForm();
            LoadChamps();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedChamp == null) return;

            var confirm = MessageBox.Show($"Remove {_selectedChamp.Name}?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                _context.Champions.Remove(_selectedChamp);
                _context.SaveChanges();
                MessageBox.Show("Champion removed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadChamps();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            _selectedChamp = null;
            txtChampion.Text = "";
            ddlMainRole.SelectedIndex = 0;
            for (int i = 0; i < clbTypes.Items.Count; i++)
                clbTypes.SetItemChecked(i, false);
            ddlDifficulty.SelectedIndex = 0;
            chkIsFavorite.Checked = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnAdd.Enabled = true;
        }
    }
}
