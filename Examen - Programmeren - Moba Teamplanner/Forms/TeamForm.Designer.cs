namespace Examen___Programmeren___Moba_Teamplanner.Forms
{
    partial class TeamForm
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
            btnNew = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnAdd = new Button();
            lblDesc = new Label();
            lblADC = new Label();
            lblMid = new Label();
            lblJungle = new Label();
            lblTop = new Label();
            lblTeamname = new Label();
            rtxtDescription = new RichTextBox();
            ddlADC = new ComboBox();
            ddlMid = new ComboBox();
            ddlJungle = new ComboBox();
            txtTeamName = new TextBox();
            dgvTeams = new DataGridView();
            lblSup = new Label();
            ddlSupport = new ComboBox();
            ddlTop = new ComboBox();
            lblTitel = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTeams).BeginInit();
            SuspendLayout();
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNew.Location = new Point(1050, 604);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(100, 80);
            btnNew.TabIndex = 51;
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
            btnDelete.TabIndex = 50;
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
            btnSave.TabIndex = 49;
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
            btnAdd.TabIndex = 48;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblDesc
            // 
            lblDesc.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDesc.Location = new Point(775, 546);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(121, 23);
            lblDesc.TabIndex = 47;
            lblDesc.Text = "Description";
            // 
            // lblADC
            // 
            lblADC.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblADC.Location = new Point(775, 417);
            lblADC.Name = "lblADC";
            lblADC.Size = new Size(121, 23);
            lblADC.TabIndex = 45;
            lblADC.Text = "ADC";
            // 
            // lblMid
            // 
            lblMid.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMid.Location = new Point(775, 357);
            lblMid.Name = "lblMid";
            lblMid.Size = new Size(121, 23);
            lblMid.TabIndex = 44;
            lblMid.Text = "Midlaner";
            // 
            // lblJungle
            // 
            lblJungle.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJungle.Location = new Point(775, 297);
            lblJungle.Name = "lblJungle";
            lblJungle.Size = new Size(121, 23);
            lblJungle.TabIndex = 43;
            lblJungle.Text = "Jungler";
            // 
            // lblTop
            // 
            lblTop.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTop.Location = new Point(775, 232);
            lblTop.Name = "lblTop";
            lblTop.Size = new Size(121, 23);
            lblTop.TabIndex = 42;
            lblTop.Text = "Top laner";
            // 
            // lblTeamname
            // 
            lblTeamname.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTeamname.Location = new Point(775, 172);
            lblTeamname.Name = "lblTeamname";
            lblTeamname.Size = new Size(121, 23);
            lblTeamname.TabIndex = 41;
            lblTeamname.Text = "Teamname";
            // 
            // rtxtDescription
            // 
            rtxtDescription.Location = new Point(775, 572);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.Size = new Size(193, 150);
            rtxtDescription.TabIndex = 40;
            rtxtDescription.Text = "";
            // 
            // ddlADC
            // 
            ddlADC.DropDownStyle = ComboBoxStyle.DropDownList;
            ddlADC.FormattingEnabled = true;
            ddlADC.Location = new Point(775, 447);
            ddlADC.Name = "ddlADC";
            ddlADC.Size = new Size(147, 23);
            ddlADC.TabIndex = 39;
            // 
            // ddlMid
            // 
            ddlMid.DropDownStyle = ComboBoxStyle.DropDownList;
            ddlMid.FormattingEnabled = true;
            ddlMid.Location = new Point(775, 387);
            ddlMid.Name = "ddlMid";
            ddlMid.Size = new Size(147, 23);
            ddlMid.TabIndex = 37;
            // 
            // ddlJungle
            // 
            ddlJungle.DropDownStyle = ComboBoxStyle.DropDownList;
            ddlJungle.FormattingEnabled = true;
            ddlJungle.Location = new Point(775, 327);
            ddlJungle.Name = "ddlJungle";
            ddlJungle.Size = new Size(147, 23);
            ddlJungle.TabIndex = 36;
            // 
            // txtTeamName
            // 
            txtTeamName.Location = new Point(775, 202);
            txtTeamName.Name = "txtTeamName";
            txtTeamName.Size = new Size(147, 23);
            txtTeamName.TabIndex = 34;
            // 
            // dgvTeams
            // 
            dgvTeams.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTeams.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTeams.Location = new Point(50, 115);
            dgvTeams.MultiSelect = false;
            dgvTeams.Name = "dgvTeams";
            dgvTeams.ReadOnly = true;
            dgvTeams.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTeams.Size = new Size(650, 619);
            dgvTeams.TabIndex = 28;
            dgvTeams.SelectionChanged += dgvTeams_SelectionChanged;
            // 
            // lblSup
            // 
            lblSup.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSup.Location = new Point(775, 487);
            lblSup.Name = "lblSup";
            lblSup.Size = new Size(121, 23);
            lblSup.TabIndex = 54;
            lblSup.Text = "Support";
            // 
            // ddlSupport
            // 
            ddlSupport.DropDownStyle = ComboBoxStyle.DropDownList;
            ddlSupport.FormattingEnabled = true;
            ddlSupport.Location = new Point(775, 513);
            ddlSupport.Name = "ddlSupport";
            ddlSupport.Size = new Size(147, 23);
            ddlSupport.TabIndex = 53;
            // 
            // ddlTop
            // 
            ddlTop.DropDownStyle = ComboBoxStyle.DropDownList;
            ddlTop.FormattingEnabled = true;
            ddlTop.Location = new Point(775, 262);
            ddlTop.Name = "ddlTop";
            ddlTop.Size = new Size(147, 23);
            ddlTop.TabIndex = 55;
            // 
            // lblTitel
            // 
            lblTitel.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitel.Location = new Point(775, 25);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(371, 134);
            lblTitel.TabIndex = 56;
            lblTitel.Text = "Team Manager";
            lblTitel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TeamForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1204, 761);
            Controls.Add(lblTitel);
            Controls.Add(ddlTop);
            Controls.Add(lblSup);
            Controls.Add(ddlSupport);
            Controls.Add(btnNew);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnAdd);
            Controls.Add(lblDesc);
            Controls.Add(lblADC);
            Controls.Add(lblMid);
            Controls.Add(lblJungle);
            Controls.Add(lblTop);
            Controls.Add(lblTeamname);
            Controls.Add(rtxtDescription);
            Controls.Add(ddlADC);
            Controls.Add(ddlMid);
            Controls.Add(ddlJungle);
            Controls.Add(txtTeamName);
            Controls.Add(dgvTeams);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "TeamForm";
            Text = "Manage teams";
            ((System.ComponentModel.ISupportInitialize)dgvTeams).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSortRank;
        private Button btnNew;
        private Button btnDelete;
        private Button btnSave;
        private Button btnAdd;
        private Label lblDesc;
        private Label lblADC;
        private Label lblMid;
        private Label lblJungle;
        private Label lblTop;
        private Label lblTeamname;
        private RichTextBox rtxtDescription;
        private ComboBox ddlADC;
        private ComboBox ddlMid;
        private ComboBox ddlJungle;
        private TextBox txtTeamName;
        private Label lblRole;
        private Label lblSearch;
        private CheckBox chkActiveOnly;
        private ComboBox ddlFilterRoles;
        private DataGridView dgvTeams;
        private Label lblSup;
        private ComboBox ddlSupport;
        private ComboBox ddlTop;
        private Label lblTitel;
    }
}