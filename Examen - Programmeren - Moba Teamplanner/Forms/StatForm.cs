using Examen___Programmeren___Moba_Teamplanner.Data;
using Examen___Programmeren___Moba_Teamplanner.Enums;
using Microsoft.EntityFrameworkCore;

namespace Examen___Programmeren___Moba_Teamplanner.Forms
{
    public partial class StatForm : Form
    {
        private readonly AppDbContext _context;

        public StatForm()
        {
            InitializeComponent();
            _context = new AppDbContext();
            LoadStats();
        }

        private void LoadStats()
        {
            LoadOverviewStats();
            LoadPlayersPerRole();
            LoadTeamWinrates();
            LoadMostPlayedChampions();
        }

        private void LoadOverviewStats()
        {
            int totalPlayers = _context.Players.Count();
            int activePlayers = _context.Players.Count(p => p.IsActive);
            int totalTeams = _context.Teams.Count();
            int favoriteChampions = _context.Champions.Count(c => c.IsFavorite);

            var playedMatches = _context.Matches
                .Where(m => m.Result == MatchResult.Win || m.Result == MatchResult.Loss)
                .ToList();

            int totalPlayedMatches = playedMatches.Count;
            int totalWins = playedMatches.Count(m => m.Result == MatchResult.Win);
            double winrate = totalPlayedMatches == 0 ? 0 : (double)totalWins / totalPlayedMatches * 100;

            var matchesWithDuration = playedMatches
                .Where(m => m.Duration.HasValue)
                .ToList();

            double averageDuration = matchesWithDuration.Count == 0
                ? 0
                : matchesWithDuration.Average(m => m.Duration!.Value.TotalMinutes);

            var mostPlayedChampion = _context.GameParticipations
                .Include(gp => gp.Champ)
                .GroupBy(gp => gp.Champ.Name)
                .Select(g => new
                {
                    Champion = g.Key,
                    Games = g.Count()
                })
                .OrderByDescending(c => c.Games)
                .FirstOrDefault();

            lblTotalPlayers.Text = $"Total players: {totalPlayers}";
            lblActivePlayers.Text = $"Active players: {activePlayers}";
            lblTotalTeams.Text = $"Total teams: {totalTeams}";
            lblTotalMatches.Text = $"Played matches: {totalPlayedMatches}";
            lblTotalWinrate.Text = $"Total winrate: {winrate:0.0}%";
            lblAverageDuration.Text = averageDuration == 0
                ? "Average duration: -"
                : $"Average duration: {averageDuration:0} min";
            lblMostPlayedChampion.Text = mostPlayedChampion == null
                ? "Most played champion: -"
                : $"Most played champion: {mostPlayedChampion.Champion}";
            lblFavoriteChampions.Text = $"Favorite champions: {favoriteChampions}";
        }

        private void LoadPlayersPerRole()
        {
            dgvPlayersPerRole.DataSource = _context.Players
                .ToList()
                .GroupBy(p => p.BestRole)
                .Select(g => new
                {
                    Role = g.Key.ToString(),
                    Players = g.Count(),
                    Active = g.Count(p => p.IsActive)
                })
                .OrderBy(r => r.Role)
                .ToList();
        }

        private void LoadTeamWinrates()
        {
            var teams = _context.Teams
                .Include(t => t.Games)
                .ToList();

            dgvTeamWinrates.DataSource = teams.Select(t =>
            {
                var playedMatches = t.Games
                    .Where(m => m.Result == MatchResult.Win || m.Result == MatchResult.Loss)
                    .ToList();

                int games = playedMatches.Count;
                int wins = playedMatches.Count(m => m.Result == MatchResult.Win);
                int losses = playedMatches.Count(m => m.Result == MatchResult.Loss);
                double winrate = games == 0 ? 0 : (double)wins / games * 100;

                return new
                {
                    Team = t.Name,
                    Games = games,
                    Wins = wins,
                    Losses = losses,
                    Winrate = $"{winrate:0.0}%"
                };
            })
            .OrderByDescending(t => t.Wins)
            .ToList();
        }

        private void LoadMostPlayedChampions()
        {
            dgvMostPlayedChampions.DataSource = _context.GameParticipations
                .Include(gp => gp.Champ)
                .ToList()
                .GroupBy(gp => gp.Champ.Name)
                .Select(g => new
                {
                    Champion = g.Key,
                    Games = g.Count()
                })
                .OrderByDescending(c => c.Games)
                .Take(10)
                .ToList();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadStats();
        }
    }
}
