namespace Examen___Programmeren___Moba_Teamplanner.Forms
{
    partial class PlayerForms
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
            dgvPlayers = new DataGridView();
            txtSearch = new TextBox();
            ddlFilterRoles = new ComboBox();
            chkActiveOnly = new CheckBox();
            lblSearch = new Label();
            lblRole = new Label();
            txtIGN = new TextBox();
            txtName = new TextBox();
            ddlBestRole = new ComboBox();
            ddlSecondaryRole = new ComboBox();
            chkIsActive = new CheckBox();
            ddlRank = new ComboBox();
            rtxtDescription = new RichTextBox();
            lblIGN = new Label();
            lblName = new Label();
            lblBestRole = new Label();
            lblSecondaryRole = new Label();
            lblRank = new Label();
            lblActive = new Label();
            lblDesc = new Label();
            btnAdd = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            btnNew = new Button();
            btnSortRank = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPlayers).BeginInit();
            SuspendLayout();
            // 
            // dgvPlayers
            // 
            dgvPlayers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPlayers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlayers.Location = new Point(50, 115);
            dgvPlayers.MultiSelect = false;
            dgvPlayers.Name = "dgvPlayers";
            dgvPlayers.ReadOnly = true;
            dgvPlayers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPlayers.Size = new Size(650, 619);
            dgvPlayers.TabIndex = 0;
            dgvPlayers.SelectionChanged += dgvPlayers_SelectionChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(50, 75);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(152, 23);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // ddlFilterRoles
            // 
            ddlFilterRoles.DropDownStyle = ComboBoxStyle.DropDownList;
            ddlFilterRoles.FormattingEnabled = true;
            ddlFilterRoles.Location = new Point(250, 73);
            ddlFilterRoles.Name = "ddlFilterRoles";
            ddlFilterRoles.Size = new Size(121, 23);
            ddlFilterRoles.TabIndex = 2;
            ddlFilterRoles.SelectedIndexChanged += ddlFilterRoles_SelectedIndexChanged;
            // 
            // chkActiveOnly
            // 
            chkActiveOnly.AutoSize = true;
            chkActiveOnly.Location = new Point(400, 75);
            chkActiveOnly.Name = "chkActiveOnly";
            chkActiveOnly.Size = new Size(59, 19);
            chkActiveOnly.TabIndex = 3;
            chkActiveOnly.Text = "Active";
            chkActiveOnly.UseVisualStyleBackColor = true;
            chkActiveOnly.CheckedChanged += chkActiveOnly_CheckedChanged;
            // 
            // lblSearch
            // 
            lblSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(50, 50);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(152, 23);
            lblSearch.TabIndex = 4;
            lblSearch.Text = "Search username";
            // 
            // lblRole
            // 
            lblRole.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(250, 50);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(121, 23);
            lblRole.TabIndex = 5;
            lblRole.Text = "Role";
            // 
            // txtIGN
            // 
            txtIGN.Location = new Point(775, 202);
            txtIGN.Name = "txtIGN";
            txtIGN.Size = new Size(147, 23);
            txtIGN.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Location = new Point(775, 262);
            txtName.Name = "txtName";
            txtName.Size = new Size(147, 23);
            txtName.TabIndex = 7;
            // 
            // ddlBestRole
            // 
            ddlBestRole.DropDownStyle = ComboBoxStyle.DropDownList;
            ddlBestRole.FormattingEnabled = true;
            ddlBestRole.Location = new Point(775, 327);
            ddlBestRole.Name = "ddlBestRole";
            ddlBestRole.Size = new Size(147, 23);
            ddlBestRole.TabIndex = 10;
            // 
            // ddlSecondaryRole
            // 
            ddlSecondaryRole.DropDownStyle = ComboBoxStyle.DropDownList;
            ddlSecondaryRole.FormattingEnabled = true;
            ddlSecondaryRole.Location = new Point(775, 387);
            ddlSecondaryRole.Name = "ddlSecondaryRole";
            ddlSecondaryRole.Size = new Size(147, 23);
            ddlSecondaryRole.TabIndex = 12;
            // 
            // chkIsActive
            // 
            chkIsActive.Location = new Point(775, 513);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(147, 19);
            chkIsActive.TabIndex = 13;
            chkIsActive.Text = "Active";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // ddlRank
            // 
            ddlRank.DropDownStyle = ComboBoxStyle.DropDownList;
            ddlRank.FormattingEnabled = true;
            ddlRank.Location = new Point(775, 447);
            ddlRank.Name = "ddlRank";
            ddlRank.Size = new Size(147, 23);
            ddlRank.TabIndex = 14;
            // 
            // rtxtDescription
            // 
            rtxtDescription.Location = new Point(775, 583);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.Size = new Size(193, 151);
            rtxtDescription.TabIndex = 15;
            rtxtDescription.Text = "";
            // 
            // lblIGN
            // 
            lblIGN.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIGN.Location = new Point(775, 172);
            lblIGN.Name = "lblIGN";
            lblIGN.Size = new Size(121, 23);
            lblIGN.TabIndex = 16;
            lblIGN.Text = "Username";
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(775, 232);
            lblName.Name = "lblName";
            lblName.Size = new Size(121, 23);
            lblName.TabIndex = 17;
            lblName.Text = "Name";
            // 
            // lblBestRole
            // 
            lblBestRole.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBestRole.Location = new Point(775, 297);
            lblBestRole.Name = "lblBestRole";
            lblBestRole.Size = new Size(121, 23);
            lblBestRole.TabIndex = 18;
            lblBestRole.Text = "Main role";
            // 
            // lblSecondaryRole
            // 
            lblSecondaryRole.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSecondaryRole.Location = new Point(775, 357);
            lblSecondaryRole.Name = "lblSecondaryRole";
            lblSecondaryRole.Size = new Size(121, 23);
            lblSecondaryRole.TabIndex = 19;
            lblSecondaryRole.Text = "Secondary role";
            // 
            // lblRank
            // 
            lblRank.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRank.Location = new Point(775, 417);
            lblRank.Name = "lblRank";
            lblRank.Size = new Size(121, 23);
            lblRank.TabIndex = 20;
            lblRank.Text = "Rank";
            // 
            // lblActive
            // 
            lblActive.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblActive.Location = new Point(775, 487);
            lblActive.Name = "lblActive";
            lblActive.Size = new Size(121, 23);
            lblActive.TabIndex = 21;
            lblActive.Text = "Active player";
            // 
            // lblDesc
            // 
            lblDesc.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDesc.Location = new Point(775, 546);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(121, 23);
            lblDesc.TabIndex = 22;
            lblDesc.Text = "Description";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(1050, 240);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 80);
            btnAdd.TabIndex = 23;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(1050, 360);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 80);
            btnSave.TabIndex = 24;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(1050, 487);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 80);
            btnDelete.TabIndex = 25;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNew.Location = new Point(1050, 604);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(100, 80);
            btnNew.TabIndex = 26;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnCancel_Click;
            // 
            // btnSortRank
            // 
            btnSortRank.Location = new Point(506, 63);
            btnSortRank.Name = "btnSortRank";
            btnSortRank.Size = new Size(90, 33);
            btnSortRank.TabIndex = 27;
            btnSortRank.Text = "Sort by rank";
            btnSortRank.UseVisualStyleBackColor = true;
            btnSortRank.Click += btnSortRank_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(775, 25);
            label1.Name = "label1";
            label1.Size = new Size(371, 134);
            label1.TabIndex = 28;
            label1.Text = "Player Manager\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PlayerForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1204, 761);
            Controls.Add(label1);
            Controls.Add(btnSortRank);
            Controls.Add(btnNew);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnAdd);
            Controls.Add(lblDesc);
            Controls.Add(lblActive);
            Controls.Add(lblRank);
            Controls.Add(lblSecondaryRole);
            Controls.Add(lblBestRole);
            Controls.Add(lblName);
            Controls.Add(lblIGN);
            Controls.Add(rtxtDescription);
            Controls.Add(ddlRank);
            Controls.Add(chkIsActive);
            Controls.Add(ddlSecondaryRole);
            Controls.Add(ddlBestRole);
            Controls.Add(txtName);
            Controls.Add(txtIGN);
            Controls.Add(lblRole);
            Controls.Add(lblSearch);
            Controls.Add(chkActiveOnly);
            Controls.Add(ddlFilterRoles);
            Controls.Add(txtSearch);
            Controls.Add(dgvPlayers);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
                                    Name = "PlayerForms";
            Text = "Manage players";
            ((System.ComponentModel.ISupportInitialize)dgvPlayers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPlayers;
        private TextBox txtSearch;
        private ComboBox ddlFilterRoles;
        private CheckBox chkActiveOnly;
        private Label lblSearch;
        private Label lblRole;
        private TextBox txtIGN;
        private TextBox txtName;
        private TextBox txtR;
        private TextBox textBox4;
        private ComboBox ddlBestRole;
        private ComboBox comboBox2;
        private ComboBox ddlSecondaryRole;
        private CheckBox chkIsActive;
        private ComboBox ddlRank;
        private RichTextBox rtxtDescription;
        private Label lblIGN;
        private Label lblName;
        private Label lblBestRole;
        private Label lblSecondaryRole;
        private Label lblRank;
        private Label lblActive;
        private Label lblDesc;
        private Button btnAdd;
        private Button btnSave;
        private Button btnDelete;
        private Button btnNew;
        private Button btnSortRank;
        private Label label1;
    }
}