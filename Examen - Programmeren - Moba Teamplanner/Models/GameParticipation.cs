using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen___Programmeren___Moba_Teamplanner.Models
{
    public class GameParticipation
    {
        public int id {  get; set; }
        public int MatchId { get; set; }
        public int PlayerId { get; set; }
        public int ChampId { get; set; }

        public Match Match { get; set; } = null!;
        public Player Player { get; set; } = null!;
        public Champ Champ { get; set; } = null!;
    }
}
