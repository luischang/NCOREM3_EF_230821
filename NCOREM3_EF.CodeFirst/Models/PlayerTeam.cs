using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCOREM3_EF.CodeFirst.Models
{
    [Table("PlayerTeam")]

    public class PlayerTeam
    {
        [Key]  
        [Column(Order=1)]
        public int PlayersId { get; set; }
        [Key]
        [Column(Order = 2)]
        public int TeamsId { get; set; }        

        public virtual Player Player { get; set; }
        public virtual Team Team { get; set; }
    }
}
