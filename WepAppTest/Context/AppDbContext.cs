using Microsoft.EntityFrameworkCore;
using WepAppTest.Models;

namespace WepAppTest.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<User> Users { get; set; }

        public AppDbContext(DbContextOptions opt) : base(opt) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>(x =>
            {
                x.HasIndex(y => y.Id).IsUnique();
                x.Property(y => y.Name).HasMaxLength(10).HasComment("10 simvoldan cox ola bilmez"); 
                x.Property(y => y.Surname).HasMaxLength(10).HasComment("10 simvoldan cox ola bilmez"); 
            });

            modelBuilder.Entity<Department>(x =>
            {
                x.HasIndex(y => y.Id).IsUnique();
                x.Property(y => y.DepartmentName).HasMaxLength(20).HasComment("20 simvoldan cox ola bilmez");
            });

            modelBuilder.Entity<User>(x =>
            {
                x.HasIndex(y => y.Id).IsUnique();
                x.Property(y => y.Name).HasMaxLength(20).HasComment("20 simvoldan cox ola bilmez");
                x.Property(y => y.Surname).HasMaxLength(20).HasComment("20 simvoldan cox ola bilmez");
                x.Property(y => y.Email).IsRequired().HasComment("Email daxil et");
            });
        }
    }
}
