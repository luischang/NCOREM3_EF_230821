using System;
using System.Collections.Generic;

#nullable disable

namespace NCOREM3_EF.DatabaseFirst.Models
{
    public partial class SoccerPosition
    {
        public SoccerPosition()
        {
            Player = new HashSet<Player>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }

        public virtual ICollection<Player> Player { get; set; }
    }
}
