namespace Examen___Programmeren___Moba_Teamplanner.Forms
{
    partial class ChampForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnClear = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnAdd = new Button();
            lblIsFavorite = new Label();
            lblDifficulty = new Label();
            lblMainrole = new Label();
            lblCharName = new Label();
            chkIsFavorite = new CheckBox();
            ddlDifficulty = new ComboBox();
            ddlMainRole = new ComboBox();
            txtChampion = new TextBox();
            lblRole = new Label();
            lblSearch = new Label();
            ddlFilterTypes = new ComboBox();
            txtSearch = new TextBox();
            dgvChamps = new DataGridView();
            lblDifficultyFilter = new Label();
            ddlDifficultyFilter = new ComboBox();
            lblType = new Label();
            clbTypes = new CheckedListBox();
            lblRoleFilter = new Label();
            ddlFilterRoles = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvChamps).BeginInit();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(1050, 620);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 80);
            btnClear.TabIndex = 50;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(1050, 495);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 80);
            btnDelete.TabIndex = 49;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(1050, 374);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 80);
            btnSave.TabIndex = 48;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(1049, 248);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 80);
            btnAdd.TabIndex = 47;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblIsFavorite
            // 
            lblIsFavorite.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIsFavorite.Location = new Point(760, 640);
            lblIsFavorite.Name = "lblIsFavorite";
            lblIsFavorite.Size = new Size(121, 23);
            lblIsFavorite.TabIndex = 45;
            lblIsFavorite.Text = "Favorite champ";
            // 
            // lblDifficulty
            // 
            lblDifficulty.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDifficulty.Location = new Point(760, 379);
            lblDifficulty.Name = "lblDifficulty";
            lblDifficulty.Size = new Size(121, 23);
            lblDifficulty.TabIndex = 43;
            lblDifficulty.Text = "Difficulty";
            // 
            // lblMainrole
            // 
            lblMainrole.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMainrole.Location = new Point(760, 323);
            lblMainrole.Name = "lblMainrole";
            lblMainrole.Size = new Size(121, 23);
            lblMainrole.TabIndex = 42;
            lblMainrole.Text = "Main role";
            // 
            // lblCharName
            // 
            lblCharName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCharName.Location = new Point(760, 248);
            lblCharName.Name = "lblCharName";
            lblCharName.Size = new Size(121, 23);
            lblCharName.TabIndex = 40;
            lblCharName.Text = "Champion";
            // 
            // chkIsFavorite
            // 
            chkIsFavorite.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkIsFavorite.Location = new Point(760, 666);
            chkIsFavorite.Name = "chkIsFavorite";
            chkIsFavorite.Size = new Size(147, 34);
            chkIsFavorite.TabIndex = 37;
            chkIsFavorite.Text = "Favorite";
            chkIsFavorite.UseVisualStyleBackColor = true;
            // 
            // ddlDifficulty
            // 
            ddlDifficulty.DropDownStyle = ComboBoxStyle.DropDownList;
            ddlDifficulty.FormattingEnabled = true;
            ddlDifficulty.Location = new Point(760, 405);
            ddlDifficulty.Name = "ddlDifficulty";
            ddlDifficulty.Size = new Size(147, 23);
            ddlDifficulty.TabIndex = 36;
            // 
            // ddlMainRole
            // 
            ddlMainRole.DropDownStyle = ComboBoxStyle.DropDownList;
            ddlMainRole.FormattingEnabled = true;
            ddlMainRole.Location = new Point(760, 349);
            ddlMainRole.Name = "ddlMainRole";
            ddlMainRole.Size = new Size(147, 23);
            ddlMainRole.TabIndex = 35;
            // 
            // txtChampion
            // 
            txtChampion.Location = new Point(760, 279);
            txtChampion.Name = "txtChampion";
            txtChampion.Size = new Size(147, 23);
            txtChampion.TabIndex = 33;
            // 
            // lblRole
            // 
            lblRole.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(220, 40);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(121, 23);
            lblRole.TabIndex = 32;
            lblRole.Text = "Character type";
            // 
            // lblSearch
            // 
            lblSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(50, 40);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(152, 23);
            lblSearch.TabIndex = 31;
            lblSearch.Text = "Search champion";
            // 
            // ddlFilterTypes
            // 
            ddlFilterTypes.DropDownStyle = ComboBoxStyle.DropDownList;
            ddlFilterTypes.FormattingEnabled = true;
            ddlFilterTypes.Location = new Point(220, 65);
            ddlFilterTypes.Name = "ddlFilterTypes";
            ddlFilterTypes.Size = new Size(121, 23);
            ddlFilterTypes.TabIndex = 29;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(50, 65);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(152, 23);
            txtSearch.TabIndex = 28;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dgvChamps
            // 
            dgvChamps.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChamps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChamps.Location = new Point(50, 100);
            dgvChamps.MultiSelect = false;
            dgvChamps.Name = "dgvChamps";
            dgvChamps.ReadOnly = true;
            dgvChamps.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChamps.Size = new Size(641, 619);
            dgvChamps.TabIndex = 27;
            dgvChamps.SelectionChanged += dgvChamps_SelectionChanged;
            // 
            // lblDifficultyFilter
            // 
            lblDifficultyFilter.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDifficultyFilter.Location = new Point(360, 40);
            lblDifficultyFilter.Name = "lblDifficultyFilter";
            lblDifficultyFilter.Size = new Size(121, 23);
            lblDifficultyFilter.TabIndex = 52;
            lblDifficultyFilter.Text = "Difficulty";
            // 
            // ddlDifficultyFilter
            // 
            ddlDifficultyFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            ddlDifficultyFilter.FormattingEnabled = true;
            ddlDifficultyFilter.Location = new Point(360, 65);
            ddlDifficultyFilter.Name = "ddlDifficultyFilter";
            ddlDifficultyFilter.Size = new Size(121, 23);
            ddlDifficultyFilter.TabIndex = 51;
            // 
            // lblType
            // 
            lblType.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblType.Location = new Point(760, 444);
            lblType.Name = "lblType";
            lblType.Size = new Size(121, 23);
            lblType.TabIndex = 54;
            lblType.Text = "Type";
            // 
            // clbTypes
            // 
            clbTypes.FormattingEnabled = true;
            clbTypes.Location = new Point(760, 480);
            clbTypes.Name = "clbTypes";
            clbTypes.Size = new Size(147, 148);
            clbTypes.TabIndex = 55;
            // 
            // lblRoleFilter
            // 
            lblRoleFilter.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRoleFilter.Location = new Point(500, 40);
            lblRoleFilter.Name = "lblRoleFilter";
            lblRoleFilter.Size = new Size(121, 23);
            lblRoleFilter.TabIndex = 57;
            lblRoleFilter.Text = "Role";
            // 
            // ddlFilterRoles
            // 
            ddlFilterRoles.DropDownStyle = ComboBoxStyle.DropDownList;
            ddlFilterRoles.FormattingEnabled = true;
            ddlFilterRoles.Location = new Point(500, 65);
            ddlFilterRoles.Name = "ddlFilterRoles";
            ddlFilterRoles.Size = new Size(121, 23);
            ddlFilterRoles.TabIndex = 56;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(760, 40);
            label1.Name = "label1";
            label1.Size = new Size(389, 169);
            label1.TabIndex = 58;
            label1.Text = "Champion Manager";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ChampForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1204, 761);
            Controls.Add(label1);
            Controls.Add(lblRoleFilter);
            Controls.Add(ddlFilterRoles);
            Controls.Add(clbTypes);
            Controls.Add(lblType);
            Controls.Add(lblDifficultyFilter);
            Controls.Add(ddlDifficultyFilter);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnAdd);
            Controls.Add(lblIsFavorite);
            Controls.Add(lblDifficulty);
            Controls.Add(lblMainrole);
            Controls.Add(lblCharName);
            Controls.Add(chkIsFavorite);
            Controls.Add(ddlDifficulty);
            Controls.Add(ddlMainRole);
            Controls.Add(txtChampion);
            Controls.Add(lblRole);
            Controls.Add(lblSearch);
            Controls.Add(ddlFilterTypes);
            Controls.Add(txtSearch);
            Controls.Add(dgvChamps);
            Name = "ChampForm";
            Text = "ChampForm";
            ((System.ComponentModel.ISupportInitialize)dgvChamps).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClear;
        private Button btnDelete;
        private Button btnSave;
        private Button btnAdd;
        private Label lblDesc;
        private Label lblIsFavorite;
        private Label lblDifficulty;
        private Label lblMainrole;
        private Label lblCharName;
        private RichTextBox rtxtDescription;
        private CheckBox chkIsFavorite;
        private ComboBox ddlDifficulty;
        private ComboBox ddlMainRole;
        private TextBox txtChampion;
        private Label lblRole;
        private Label lblSearch;
        private ComboBox ddlFilterTypes;
        private TextBox txtSearch;
        private DataGridView dgvChamps;
        private Label lblDifficultyFilter;
        private ComboBox ddlDifficultyFilter;
        private Label lblType;
        private CheckedListBox clbTypes;
        private Label lblRoleFilter;
        private ComboBox ddlFilterRoles;
        private Label label1;
    }
}