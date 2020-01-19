using FitHubWebApi.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace FitHubWebApi.Infrastructure.DbContext
{
    public class FitHubWebApiContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public FitHubWebApiContext()
        {
        }

        public FitHubWebApiContext(DbContextOptions<FitHubWebApiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountType> AccountType { get; set; }
        public virtual DbSet<Height> Height { get; set; }
        public virtual DbSet<Kcal> Kcal { get; set; }
        public virtual DbSet<Steps> Steps { get; set; }
        public virtual DbSet<Log> Log { get; set; }
        public virtual DbSet<Password> Password { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Weight> Weight { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AccountType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Height>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK_HEIGHT");

                entity.Property(e => e.UserId)
                    .HasColumnName("userId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Value).HasColumnName("value");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.Height)
                    .HasForeignKey<Height>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Height_fk0");
            });

            modelBuilder.Entity<Kcal>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PK_KCAL");

                entity.Property(e => e.LogId).ValueGeneratedNever();

                entity.HasOne(d => d.Log)
                    .WithOne(p => p.Kcal)
                    .HasForeignKey<Kcal>(d => d.LogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Kcal_fk0");
            });

            modelBuilder.Entity<Steps>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PK_STEPS");

                entity.Property(e => e.LogId).ValueGeneratedNever();

                entity.HasOne(d => d.Log)
                    .WithOne(p => p.Steps)
                    .HasForeignKey<Steps>(d => d.LogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Steps_fk0");
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedAt).HasColumnType("date");

                entity.Property(e => e.UserId).HasColumnType("date");
            });

            modelBuilder.Entity<Password>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK_PASSWORD");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.HasOne(d => d.User)
                    .WithOne(p => p.Password)
                    .HasForeignKey<Password>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Password_fk0");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Email)
                    .HasName("UQ__User__A9D1053460CBCAE1")
                    .IsUnique();

                entity.HasIndex(e => e.Login)
                    .HasName("UQ__User__5E55825B9D5067A8")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.AccountType)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.AccountTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("User_fk0");
            });

            modelBuilder.Entity<Weight>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PK_WEIGHT");

                entity.Property(e => e.LogId).ValueGeneratedNever();

                entity.HasOne(d => d.Log)
                    .WithOne(p => p.Weight)
                    .HasForeignKey<Weight>(d => d.LogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Weight_fk0");
            });

        }

    }
}
