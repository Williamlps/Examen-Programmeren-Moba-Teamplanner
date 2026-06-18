namespace Examen___Programmeren___Moba_Teamplanner.Forms
{
    partial class StatForm
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
            lblTotalPlayers = new Label();
            lblActivePlayers = new Label();
            lblTotalTeams = new Label();
            lblTotalMatches = new Label();
            lblTotalWinrate = new Label();
            lblAverageDuration = new Label();
            lblMostPlayedChampion = new Label();
            lblFavoriteChampions = new Label();
            lblRoleStats = new Label();
            lblTeamStats = new Label();
            lblChampionStats = new Label();
            dgvPlayersPerRole = new DataGridView();
            dgvTeamWinrates = new DataGridView();
            dgvMostPlayedChampions = new DataGridView();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPlayersPerRole).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTeamWinrates).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMostPlayedChampions).BeginInit();
            SuspendLayout();
            // 
            // lblTitel
            // 
            lblTitel.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitel.Location = new Point(775, 25);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(371, 134);
            lblTitel.TabIndex = 0;
            lblTitel.Text = "Statistics";
            lblTitel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalPlayers
            // 
            lblTotalPlayers.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalPlayers.Location = new Point(50, 60);
            lblTotalPlayers.Name = "lblTotalPlayers";
            lblTotalPlayers.Size = new Size(300, 30);
            lblTotalPlayers.TabIndex = 1;
            lblTotalPlayers.Text = "Total players: 0";
            // 
            // lblActivePlayers
            // 
            lblActivePlayers.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblActivePlayers.Location = new Point(50, 100);
            lblActivePlayers.Name = "lblActivePlayers";
            lblActivePlayers.Size = new Size(300, 30);
            lblActivePlayers.TabIndex = 2;
            lblActivePlayers.Text = "Active players: 0";
            // 
            // lblTotalTeams
            // 
            lblTotalTeams.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalTeams.Location = new Point(50, 140);
            lblTotalTeams.Name = "lblTotalTeams";
            lblTotalTeams.Size = new Size(300, 30);
            lblTotalTeams.TabIndex = 3;
            lblTotalTeams.Text = "Total teams: 0";
            // 
            // lblTotalMatches
            // 
            lblTotalMatches.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalMatches.Location = new Point(50, 180);
            lblTotalMatches.Name = "lblTotalMatches";
            lblTotalMatches.Size = new Size(300, 30);
            lblTotalMatches.TabIndex = 4;
            lblTotalMatches.Text = "Played matches: 0";
            // 
            // lblTotalWinrate
            // 
            lblTotalWinrate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalWinrate.Location = new Point(380, 60);
            lblTotalWinrate.Name = "lblTotalWinrate";
            lblTotalWinrate.Size = new Size(320, 30);
            lblTotalWinrate.TabIndex = 5;
            lblTotalWinrate.Text = "Total winrate: 0%";
            // 
            // lblAverageDuration
            // 
            lblAverageDuration.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAverageDuration.Location = new Point(380, 100);
            lblAverageDuration.Name = "lblAverageDuration";
            lblAverageDuration.Size = new Size(320, 30);
            lblAverageDuration.TabIndex = 6;
            lblAverageDuration.Text = "Average duration: -";
            // 
            // lblMostPlayedChampion
            // 
            lblMostPlayedChampion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMostPlayedChampion.Location = new Point(380, 140);
            lblMostPlayedChampion.Name = "lblMostPlayedChampion";
            lblMostPlayedChampion.Size = new Size(320, 30);
            lblMostPlayedChampion.TabIndex = 7;
            lblMostPlayedChampion.Text = "Most played champion: -";
            // 
            // lblFavoriteChampions
            // 
            lblFavoriteChampions.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFavoriteChampions.Location = new Point(380, 180);
            lblFavoriteChampions.Name = "lblFavoriteChampions";
            lblFavoriteChampions.Size = new Size(320, 30);
            lblFavoriteChampions.TabIndex = 8;
            lblFavoriteChampions.Text = "Favorite champions: 0";
            // 
            // lblRoleStats
            // 
            lblRoleStats.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRoleStats.Location = new Point(50, 245);
            lblRoleStats.Name = "lblRoleStats";
            lblRoleStats.Size = new Size(200, 25);
            lblRoleStats.TabIndex = 9;
            lblRoleStats.Text = "Players per role";
            // 
            // lblTeamStats
            // 
            lblTeamStats.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTeamStats.Location = new Point(380, 245);
            lblTeamStats.Name = "lblTeamStats";
            lblTeamStats.Size = new Size(200, 25);
            lblTeamStats.TabIndex = 10;
            lblTeamStats.Text = "Winrate per team";
            // 
            // lblChampionStats
            // 
            lblChampionStats.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChampionStats.Location = new Point(775, 245);
            lblChampionStats.Name = "lblChampionStats";
            lblChampionStats.Size = new Size(220, 25);
            lblChampionStats.TabIndex = 11;
            lblChampionStats.Text = "Most played champions";
            // 
            // dgvPlayersPerRole
            // 
            dgvPlayersPerRole.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPlayersPerRole.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlayersPerRole.Location = new Point(50, 275);
            dgvPlayersPerRole.MultiSelect = false;
            dgvPlayersPerRole.Name = "dgvPlayersPerRole";
            dgvPlayersPerRole.ReadOnly = true;
            dgvPlayersPerRole.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPlayersPerRole.Size = new Size(270, 360);
            dgvPlayersPerRole.TabIndex = 12;
            // 
            // dgvTeamWinrates
            // 
            dgvTeamWinrates.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTeamWinrates.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTeamWinrates.Location = new Point(380, 275);
            dgvTeamWinrates.MultiSelect = false;
            dgvTeamWinrates.Name = "dgvTeamWinrates";
            dgvTeamWinrates.ReadOnly = true;
            dgvTeamWinrates.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTeamWinrates.Size = new Size(320, 360);
            dgvTeamWinrates.TabIndex = 13;
            // 
            // dgvMostPlayedChampions
            // 
            dgvMostPlayedChampions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMostPlayedChampions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMostPlayedChampions.Location = new Point(775, 275);
            dgvMostPlayedChampions.MultiSelect = false;
            dgvMostPlayedChampions.Name = "dgvMostPlayedChampions";
            dgvMostPlayedChampions.ReadOnly = true;
            dgvMostPlayedChampions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMostPlayedChampions.Size = new Size(370, 360);
            dgvMostPlayedChampions.TabIndex = 14;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(50, 660);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(160, 50);
            btnRefresh.TabIndex = 15;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // StatForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1204, 761);
            Controls.Add(btnRefresh);
            Controls.Add(dgvMostPlayedChampions);
            Controls.Add(dgvTeamWinrates);
            Controls.Add(dgvPlayersPerRole);
            Controls.Add(lblChampionStats);
            Controls.Add(lblTeamStats);
            Controls.Add(lblRoleStats);
            Controls.Add(lblFavoriteChampions);
            Controls.Add(lblMostPlayedChampion);
            Controls.Add(lblAverageDuration);
            Controls.Add(lblTotalWinrate);
            Controls.Add(lblTotalMatches);
            Controls.Add(lblTotalTeams);
            Controls.Add(lblActivePlayers);
            Controls.Add(lblTotalPlayers);
            Controls.Add(lblTitel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "StatForm";
            Text = "Statistics";
            ((System.ComponentModel.ISupportInitialize)dgvPlayersPerRole).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTeamWinrates).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMostPlayedChampions).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitel;
        private Label lblTotalPlayers;
        private Label lblActivePlayers;
        private Label lblTotalTeams;
        private Label lblTotalMatches;
        private Label lblTotalWinrate;
        private Label lblAverageDuration;
        private Label lblMostPlayedChampion;
        private Label lblFavoriteChampions;
        private Label lblRoleStats;
        private Label lblTeamStats;
        private Label lblChampionStats;
        private DataGridView dgvPlayersPerRole;
        private DataGridView dgvTeamWinrates;
        private DataGridView dgvMostPlayedChampions;
        private Button btnRefresh;
    }
}
