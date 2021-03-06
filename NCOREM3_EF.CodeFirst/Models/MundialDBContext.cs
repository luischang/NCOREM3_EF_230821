using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCOREM3_EF.CodeFirst.Models
{
    public class MundialDBContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            //string cnx = "Server=DESKTOP-S1DROK0\\SQLEXPRESS;Database=MundialDB230821;User=MyUser;Pwd=MyPassword";
            string cnx = "Server=DESKTOP-S1DROK0\\SQLEXPRESS;Database=MundialDB230821;Trusted_Connection=true;MultipleActiveResultSets=true";

            builder
                .UseSqlServer(cnx)
                .LogTo(Console.WriteLine, LogLevel.Information);



            base.OnConfiguring(builder);

        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<PlayerTeam>(entity =>
        //    {
        //        entity.HasKey(x => new { x.PlayersId, x.TeamsId });
                
        //    });

        //    modelBuilder.Entity<Player>(entity =>
        //    {
        //        entity.HasKey(x => new { x.Id });
                

        //    });

        //}





        public virtual DbSet<Player> Player { get; set; }
        public virtual DbSet<Team> Team { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<SoccerPosition> SoccerPosition { get; set; }
        //public virtual DbSet<PlayerTeam> PlayerTeam { get; set; }

    }
}
