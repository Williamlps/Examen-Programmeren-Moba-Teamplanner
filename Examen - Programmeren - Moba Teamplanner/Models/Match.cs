using Examen___Programmeren___Moba_Teamplanner.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Examen___Programmeren___Moba_Teamplanner.Enums.MatchResult;

namespace Examen___Programmeren___Moba_Teamplanner.Models
{
    public class Match
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public int TeamId { get; set; }
        public string Opponent { get; set; } = string.Empty;
        public MatchResult Result { get; set; } = MatchResult.Planned;
        public TimeSpan? Duration { get; set; }
        public string? Notes { get; set; }

        public Team Team { get; set; } = null!;
        public List<GameParticipation> Participations { get; set; } = new();
    }
}
