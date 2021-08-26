using System;
using System.Collections.Generic;

#nullable disable

namespace NCOREM3_EF.DatabaseFirst.Models
{
    public partial class PlayerTeam
    {
        public int PlayersId { get; set; }
        public int TeamsId { get; set; }

        public virtual Player Players { get; set; }
        public virtual Team Teams { get; set; }
    }
}
