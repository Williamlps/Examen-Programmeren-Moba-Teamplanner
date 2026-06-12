using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen___Programmeren___Moba_Teamplanner.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public List<Match> Games { get; set; } = new();
        public List<PlayerTeam> PlayersTeam { get; set; } = new();

        public int TotalPlayers => PlayersTeam.Count;

    }
}
