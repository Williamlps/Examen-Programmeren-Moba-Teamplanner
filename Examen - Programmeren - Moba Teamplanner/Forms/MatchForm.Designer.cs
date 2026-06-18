namespace Examen___Programmeren___Moba_Teamplanner.Forms
{
    partial class MatchForm
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
            lblTitel = new Label();
            ddlTeam = new ComboBox();
            btnNew = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnAdd = new Button();
            lblDuration = new Label();
            lblResult = new Label();
            lblTeam = new Label();
            lblDate = new Label();
            ddlResult = new ComboBox();
            dgvMatches = new DataGridView();
            dtpDate = new DateTimePicker();
            txtDuration = new TextBox();
            lblDesc = new Label();
            rtxtDescription = new RichTextBox();
            lblOpponent = new Label();
            ddlOpponent = new ComboBox();
            lblSearch = new Label();
            txtSearch = new TextBox();
            lblResultFilter = new Label();
            ddlFilterResult = new ComboBox();
            btnChampions = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMatches).BeginInit();
            SuspendLayout();
            // 
            // lblTitel
            // 
            lblTitel.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitel.Location = new Point(775, 25);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(371, 134);
            lblTitel.TabIndex = 76;
            lblTitel.Text = "Match Manager";
            lblTitel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ddlTeam
            // 
            ddlTeam.DropDownStyle = ComboBoxStyle.DropDownList;
            ddlTeam.FormattingEnabled = true;
            ddlTeam.Location = new Point(775, 262);
            ddlTeam.Name = "ddlTeam";
            ddlTeam.Size = new Size(147, 23);
            ddlTeam.TabIndex = 75;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNew.Location = new Point(1050, 604);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(100, 80);
            btnNew.TabIndex = 72;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(1050, 487);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 80);
            btnDelete.TabIndex = 71;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(1050, 360);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 80);
            btnSave.TabIndex = 70;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(1050, 240);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 80);
            btnAdd.TabIndex = 69;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblDuration
            // 
            lblDuration.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDuration.Location = new Point(775, 417);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(121, 23);
            lblDuration.TabIndex = 66;
            lblDuration.Text = "Duration";
            // 
            // lblResult
            // 
            lblResult.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(775, 357);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(121, 23);
            lblResult.TabIndex = 65;
            lblResult.Text = "Result";
            // 
            // lblTeam
            // 
            lblTeam.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTeam.Location = new Point(775, 232);
            lblTeam.Name = "lblTeam";
            lblTeam.Size = new Size(121, 23);
            lblTeam.TabIndex = 64;
            lblTeam.Text = "Team";
            // 
            // lblDate
            // 
            lblDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(775, 172);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(121, 23);
            lblDate.TabIndex = 63;
            lblDate.Text = "Game date";
            // 
            // ddlResult
            // 
            ddlResult.DropDownStyle = ComboBoxStyle.DropDownList;
            ddlResult.FormattingEnabled = true;
            ddlResult.Location = new Point(775, 387);
            ddlResult.Name = "ddlResult";
            ddlResult.Size = new Size(147, 23);
            ddlResult.TabIndex = 59;
            // 
            // dgvMatches
            // 
            dgvMatches.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMatches.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMatches.Location = new Point(50, 115);
            dgvMatches.MultiSelect = false;
            dgvMatches.Name = "dgvMatches";
            dgvMatches.ReadOnly = true;
            dgvMatches.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMatches.Size = new Size(650, 619);
            dgvMatches.TabIndex = 57;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(775, 202);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 77;
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(775, 447);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(144, 23);
            txtDuration.TabIndex = 78;
            // 
            // lblDesc
            // 
            lblDesc.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDesc.Location = new Point(775, 487);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(121, 23);
            lblDesc.TabIndex = 68;
            lblDesc.Text = "Description";
            // 
            // rtxtDescription
            // 
            rtxtDescription.Location = new Point(775, 513);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.Size = new Size(193, 150);
            rtxtDescription.TabIndex = 62;
            rtxtDescription.Text = "";
            // 
            // lblOpponent
            // 
            lblOpponent.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOpponent.Location = new Point(775, 297);
            lblOpponent.Name = "lblOpponent";
            lblOpponent.Size = new Size(121, 23);
            lblOpponent.TabIndex = 80;
            lblOpponent.Text = "Opponent";
            // 
            // ddlOpponent
            // 
            ddlOpponent.DropDownStyle = ComboBoxStyle.DropDownList;
            ddlOpponent.FormattingEnabled = true;
            ddlOpponent.Location = new Point(775, 327);
            ddlOpponent.Name = "ddlOpponent";
            ddlOpponent.Size = new Size(147, 23);
            ddlOpponent.TabIndex = 79;
            // 
            // lblSearch
            // 
            lblSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(50, 50);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(152, 23);
            lblSearch.TabIndex = 82;
            lblSearch.Text = "Search team";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(50, 75);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(152, 23);
            txtSearch.TabIndex = 81;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblResultFilter
            // 
            lblResultFilter.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultFilter.Location = new Point(250, 50);
            lblResultFilter.Name = "lblResultFilter";
            lblResultFilter.Size = new Size(121, 23);
            lblResultFilter.TabIndex = 84;
            lblResultFilter.Text = "Result";
            // 
            // ddlFilterResult
            // 
            ddlFilterResult.DropDownStyle = ComboBoxStyle.DropDownList;
            ddlFilterResult.FormattingEnabled = true;
            ddlFilterResult.Location = new Point(250, 75);
            ddlFilterResult.Name = "ddlFilterResult";
            ddlFilterResult.Size = new Size(121, 23);
            ddlFilterResult.TabIndex = 83;
            ddlFilterResult.SelectedIndexChanged += ddlFilterResult_SelectedIndexChanged;
            // 
            // btnChampions
            // 
            btnChampions.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChampions.Location = new Point(775, 682);
            btnChampions.Name = "btnChampions";
            btnChampions.Size = new Size(193, 52);
            btnChampions.TabIndex = 85;
            btnChampions.Text = "Champions";
            btnChampions.UseVisualStyleBackColor = true;
            btnChampions.Click += btnChampions_Click;
            // 
            // MatchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1204, 761);
            Controls.Add(btnChampions);
            Controls.Add(lblResultFilter);
            Controls.Add(ddlFilterResult);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblOpponent);
            Controls.Add(ddlOpponent);
            Controls.Add(txtDuration);
            Controls.Add(dtpDate);
            Controls.Add(lblTitel);
            Controls.Add(ddlTeam);
            Controls.Add(btnNew);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnAdd);
            Controls.Add(lblDesc);
            Controls.Add(lblDuration);
            Controls.Add(lblResult);
            Controls.Add(lblTeam);
            Controls.Add(lblDate);
            Controls.Add(rtxtDescription);
            Controls.Add(ddlResult);
            Controls.Add(dgvMatches);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "MatchForm";
            Text = "Manage matches";
            ((System.ComponentModel.ISupportInitialize)dgvMatches).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitel;
        private ComboBox ddlTeam;
        private Label lblSup;
        private ComboBox ddlSupport;
        private Button btnNew;
        private Button btnDelete;
        private Button btnSave;
        private Button btnAdd;
        private Label lblADC;
        private Label lblDuration;
        private Label lblResult;
        private Label lblTeam;
        private Label lblDate;
        private ComboBox ddlADC;
        private ComboBox ddlMid;
        private ComboBox ddlResult;
        private DataGridView dgvMatches;
        private DateTimePicker dtpDate;
        private TextBox txtDuration;
        private Label lblDesc;
        private RichTextBox rtxtDescription;
        private Label lblOpponent;
        private ComboBox ddlOpponent;
        private Label lblSearch;
        private TextBox txtSearch;
        private Label lblResultFilter;
        private ComboBox ddlFilterResult;
        private Button btnChampions;
    }
}
