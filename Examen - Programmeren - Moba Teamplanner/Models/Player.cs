using Examen___Programmeren___Moba_Teamplanner.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen___Programmeren___Moba_Teamplanner.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string IGN { get; set; } = string.Empty;
        public string? Name { get; set; }
        public Role BestRole { get; set; }
        public Role? SecondaryRole { get; set; }
        public Rank Rank { get; set; } = Rank.Unranked;
        public bool IsActive { get; set; } = true;
        public string? Description { get; set; }

        public List<PlayerTeam> PlayersTeam { get; set; } = new();
        public List<GameParticipation> Participation { get; set; } = new();
    }
}
