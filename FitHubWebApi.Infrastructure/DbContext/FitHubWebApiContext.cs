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
        public virtual DbSet<Entries> Entries { get; set; }
        public virtual DbSet<EntryType> EntryType { get; set; }
        public virtual DbSet<Height> Height { get; set; }
        public virtual DbSet<Kcal> Kcal { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<Measurement> Measurement { get; set; }
        public virtual DbSet<Password> Passwords { get; set; }
        public virtual DbSet<User> Users { get; set; }
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
                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Entries>(entity =>
            {
                entity.HasOne(d => d.EntryType)
                    .WithMany(p => p.Entries)
                    .HasForeignKey(d => d.EntryTypeId)
                    .HasConstraintName("FK__Entries__EntryTy__440B1D61");

                entity.HasOne(d => d.Log)
                    .WithMany(p => p.Entries)
                    .HasForeignKey(d => d.LogId)
                    .HasConstraintName("FK__Entries__LogId__4316F928");
            });

            modelBuilder.Entity<EntryType>(entity =>
            {
                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Height>(entity =>
            {
                entity.HasOne(d => d.Entry)
                    .WithMany(p => p.Height)
                    .HasForeignKey(d => d.EntryId)
                    .HasConstraintName("FK__Height__EntryId__46E78A0C");
            });

            modelBuilder.Entity<Kcal>(entity =>
            {
                entity.HasOne(d => d.Entry)
                    .WithMany(p => p.Kcal)
                    .HasForeignKey(d => d.EntryId)
                    .HasConstraintName("FK__Kcal__EntryId__4F7CD00D");
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Logs)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Logs__UserId__403A8C7D");
            });

            modelBuilder.Entity<Measurement>(entity =>
            {
                entity.HasOne(d => d.Entry)
                    .WithMany(p => p.Measurement)
                    .HasForeignKey(d => d.EntryId)
                    .HasConstraintName("FK__Measureme__Entry__4CA06362");
            });

            modelBuilder.Entity<Password>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Password__1788CC4CE9E307DC");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.HasOne(d => d.User)
                    .WithOne(p => p.Password)
                    .HasForeignKey<Password>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Passwords__UserI__3D5E1FD2");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.AccountType)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.AccountTypeId)
                    .HasConstraintName("FK__Users__AccountTy__3A81B327");
            });

            modelBuilder.Entity<Weight>(entity =>
            {
                entity.HasOne(d => d.Entry)
                    .WithMany(p => p.Weight)
                    .HasForeignKey(d => d.EntryId)
                    .HasConstraintName("FK__Weight__EntryId__49C3F6B7");
            });

        }

    }
}
