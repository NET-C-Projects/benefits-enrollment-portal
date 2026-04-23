using BenefitsEnrollment.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenefitsEnrollment.Infrastructure.Persistence.Contexts
{
    public class BenefitsEnrollmentDbContext : DbContext
    {
        public BenefitsEnrollmentDbContext(DbContextOptions<BenefitsEnrollmentDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees => Set<Employee>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employees");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.EmployeeNumber)
                .IsRequired()
                .HasMaxLength(50);

                entity.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(100);

                entity.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(100);

                entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(150);

                entity.Property(e => e.WorkState)
                .HasMaxLength(50)
                .IsRequired();

            });
        }
    
    }
}
