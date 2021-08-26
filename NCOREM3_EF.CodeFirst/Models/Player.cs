using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCOREM3_EF.CodeFirst.Models
{
    [Table("Player")]
    public class Player
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName ="nvarchar(100)")]
        public string FullName { get; set; }
        [Column(TypeName = "int")]
        public int Dorsal { get; set; }
        [Column(TypeName = "date")]
        public DateTime DateOfBirth { get; set; }
        [Column(TypeName = "int")]
        public int SoccerPositionId { get; set; }
        
        public virtual SoccerPosition SoccerPosition { get; set; }
        public virtual List<Team> Teams { get; set; }


    }
}
