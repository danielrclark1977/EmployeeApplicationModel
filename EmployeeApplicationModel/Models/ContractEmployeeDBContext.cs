using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EmployeeApplicationModel.Models
{
    public partial class ContractEmployeeDBContext : DbContext
    {
        public ContractEmployeeDBContext()
        {
        }

        public ContractEmployeeDBContext(DbContextOptions<ContractEmployeeDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EmployeeJobLink> EmployeeJobLink { get; set; }
        public virtual DbSet<EmployeeSkillLink> EmployeeSkillLink { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<EmployerJobLink> EmployerJobLink { get; set; }
        public virtual DbSet<Employers> Employers { get; set; }
        public virtual DbSet<Jobs> Jobs { get; set; }
        public virtual DbSet<Skills> Skills { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=ContractEmployeeDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeJobLink>(entity =>
            {
                entity.HasKey(e => e.JobLinkId);
            });

            modelBuilder.Entity<EmployeeSkillLink>(entity =>
            {
                entity.HasKey(e => new { e.Employee, e.Skill })
                    .HasName("PK_EmployeeSkillLink_1");

                entity.Property(e => e.SkillLinkId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.EmployeeNavigation)
                    .WithMany(p => p.EmployeeSkillLink)
                    .HasForeignKey(d => d.Employee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeSkillLink_Employees");
            });

            modelBuilder.Entity<Employees>(entity =>
            {
                entity.Property(e => e.AddressCity)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.AddressState)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.AddressStreet)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<EmployerJobLink>(entity =>
            {
                entity.HasKey(e => e.JobLinkId);
            });

            modelBuilder.Entity<Employers>(entity =>
            {
                entity.Property(e => e.Address)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Phone)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Jobs>(entity =>
            {
                entity.Property(e => e.JobEndDate).HasColumnType("datetime");

                entity.Property(e => e.JobLocation)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.JobName)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.JobRate).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.JobStartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Skills>(entity =>
            {
                entity.Property(e => e.SkillName)
                    .HasColumnName("Skill_Name")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
