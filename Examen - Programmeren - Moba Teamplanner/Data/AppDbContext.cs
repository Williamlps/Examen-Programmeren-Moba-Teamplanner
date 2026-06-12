// Data/AppDbContext.cs
using Examen___Programmeren___Moba_Teamplanner.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Examen___Programmeren___Moba_Teamplanner.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Champ> Champions { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<PlayerTeam> PlayerTeams { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<GameParticipation> GameParticipations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(DataBaseConfig.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlayerTeam>()
                .HasOne(pt => pt.Player)
                .WithMany(p => p.PlayersTeam)
                .HasForeignKey(pt => pt.PlayerId);

            modelBuilder.Entity<PlayerTeam>()
                .HasOne(pt => pt.Team)
                .WithMany(t => t.PlayersTeam)
                .HasForeignKey(pt => pt.TeamId);

            modelBuilder.Entity<GameParticipation>()
                .HasOne(gp => gp.Match)
                .WithMany(m => m.Participations)
                .HasForeignKey(gp => gp.MatchId);

            modelBuilder.Entity<GameParticipation>()
                .HasOne(gp => gp.Player)
                .WithMany(p => p.Participation)
                .HasForeignKey(gp => gp.PlayerId);

            modelBuilder.Entity<GameParticipation>()
                .HasOne(gp => gp.Champ)
                .WithMany(c => c.Games)
                .HasForeignKey(gp => gp.ChampId);

            modelBuilder.Entity<Match>()
                .HasOne(m => m.Team)
                .WithMany(t => t.Games)
                .HasForeignKey(m => m.TeamId);
        }
    }
}