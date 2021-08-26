using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NCOREM4_MVCEF.CodeFirst.Models
{
    public class MundialDBContext : DbContext
    {

        public MundialDBContext(DbContextOptions<MundialDBContext> options): base(options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder builder)
        //{
        //    //string cnx = "Server=DESKTOP-S1DROK0\\SQLEXPRESS;Database=MundialDB230821;User=MyUser;Pwd=MyPassword";
        //    string cnx = "Server=DESKTOP-S1DROK0\\SQLEXPRESS;Database=MundialDB250821;Trusted_Connection=true;MultipleActiveResultSets=true";

        //    builder
        //        .UseSqlServer(cnx);
        //    base.OnConfiguring(builder);

        //}
          
        public virtual DbSet<Player> Player { get; set; }       
        public virtual DbSet<SoccerPosition> SoccerPosition { get; set; }        

    }
}
