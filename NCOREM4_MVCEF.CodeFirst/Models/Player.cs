using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NCOREM4_MVCEF.CodeFirst.Models
{
    [Table("Player")]
    public class Player
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Futbolista")]
        public string FullName { get; set; }
        [Column(TypeName = "int")]
        [Display(Name = "N° Camiseta")]
        public int Dorsal { get; set; }
        //[Column(TypeName = "date")]
        //public DateTime DateOfBirth { get; set; }
        //[Column(TypeName = "int")]
        [Display(Name = "Posición")]
        public int SoccerPositionId { get; set; }

        public virtual SoccerPosition SoccerPosition { get; set; }
        //public virtual List<Team> Teams { get; set; }


    }
}
