using System;
using System.Collections.Generic;

#nullable disable

namespace NCOREM4_MVCEF.DatabaseFirst.Models
{
    public partial class Player
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Dorsal { get; set; }
        public int? SoccerPositionId { get; set; }

        public virtual SoccerPosition SoccerPosition { get; set; }
    }
}
