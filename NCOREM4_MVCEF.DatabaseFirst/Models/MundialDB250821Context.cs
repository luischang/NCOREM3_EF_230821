using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace NCOREM4_MVCEF.DatabaseFirst.Models
{
    public partial class MundialDB250821Context : DbContext
    {
        public MundialDB250821Context()
        {
        }

        public MundialDB250821Context(DbContextOptions<MundialDB250821Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Player> Player { get; set; }
        public virtual DbSet<SoccerPosition> SoccerPosition { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-S1DROK0\\SQLEXPRESS;Database=MundialDB250821;Trusted_Connection=true;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Player>(entity =>
            {
                entity.HasIndex(e => e.SoccerPositionId, "IX_Player_SoccerPositionId");

                entity.Property(e => e.FullName).HasMaxLength(100);

                entity.HasOne(d => d.SoccerPosition)
                    .WithMany(p => p.Player)
                    .HasForeignKey(d => d.SoccerPositionId);
            });

            modelBuilder.Entity<SoccerPosition>(entity =>
            {
                entity.Property(e => e.Code).HasMaxLength(3);

                entity.Property(e => e.Description).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
