using Examen___Programmeren___Moba_Teamplanner.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen___Programmeren___Moba_Teamplanner.Models
{
    public class Champ
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Role MainRole { get; set; }
        public Difficulty Difficulty { get; set; }
        public ChampionType Type { get; set; }
        public bool IsFavorite { get; set; } = false;

        public List<GameParticipation> Games { get; set; } = new();
    }
}
