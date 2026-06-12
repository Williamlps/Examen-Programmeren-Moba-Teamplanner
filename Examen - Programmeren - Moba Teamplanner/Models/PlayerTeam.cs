using Examen___Programmeren___Moba_Teamplanner.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen___Programmeren___Moba_Teamplanner.Models
{
    public class PlayerTeam
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public int PlayerId { get; set; }
        public Role AssignedRole { get; set; }

        public Team Team { get; set; } = null!;
        public Player Player { get; set; } = null!;
    }
}
