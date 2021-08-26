using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace NCOREM3_EF.DatabaseFirst.Models
{
    public partial class MundialDB230821Context : DbContext
    {
        public MundialDB230821Context()
        {
        }

        public MundialDB230821Context(DbContextOptions<MundialDB230821Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Player> Player { get; set; }
        public virtual DbSet<PlayerTeam> PlayerTeam { get; set; }
        public virtual DbSet<SoccerPosition> SoccerPosition { get; set; }
        public virtual DbSet<Team> Team { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-S1DROK0\\SQLEXPRESS;Database=MundialDB230821;Trusted_Connection=true;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Person>(entity =>
            {
                entity.Property(e => e.FullName).HasMaxLength(50);
            });

            modelBuilder.Entity<Player>(entity =>
            {
                entity.HasIndex(e => e.SoccerPositionId, "IX_Player_SoccerPositionId");

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.FullName).HasMaxLength(100);

                entity.HasOne(d => d.SoccerPosition)
                    .WithMany(p => p.Player)
                    .HasForeignKey(d => d.SoccerPositionId);
            });

            modelBuilder.Entity<PlayerTeam>(entity =>
            {
                entity.HasKey(e => new { e.PlayersId, e.TeamsId });

                entity.HasIndex(e => e.TeamsId, "IX_PlayerTeam_TeamsId");

                entity.HasOne(d => d.Players)
                    .WithMany(p => p.PlayerTeam)
                    .HasForeignKey(d => d.PlayersId);

                entity.HasOne(d => d.Teams)
                    .WithMany(p => p.PlayerTeam)
                    .HasForeignKey(d => d.TeamsId);
            });

            modelBuilder.Entity<SoccerPosition>(entity =>
            {
                entity.Property(e => e.Code).HasMaxLength(3);

                entity.Property(e => e.Description).HasMaxLength(100);
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.Property(e => e.Country).HasMaxLength(80);

                entity.Property(e => e.Description).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
