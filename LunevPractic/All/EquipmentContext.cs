using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DAL;

namespace LunevPractic.All
{
    public class EquipmentContext : DbContext
    {
            

        public DbSet<DAL.Department> Departments { get; set; }
        public DbSet<DAL.Employee> Employees { get; set; }
        public DbSet<DAL.EquipmentType> EquipmentTypes { get; set; }
        public DbSet<DAL.Equipment> Equipments { get; set; }
        public DbSet<DAL.SoftwareLicense> SoftwareLicenses { get; set; }
        public DbSet<DAL.InstalledSoftware> InstalledSoftwares { get; set; }

        public DbSet<DAL.EquipmentMoveHistory> EquipmentMoveHistories { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(
                    "Data Source=.\\SQLEXPRESS01;Initial Catalog=EquipmentAccounting;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Equipment>()
                .Property(e => e.Status)
                .HasMaxLength(20);

            modelBuilder.Entity<EquipmentMoveHistory>()
                .HasOne(h => h.Equipment)
                .WithMany()
                .HasForeignKey(h => h.EquipmentId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<EquipmentMoveHistory>()
                .HasOne(h => h.OldEmployee)
                .WithMany()
                .HasForeignKey(h => h.OldEmployeeId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<EquipmentMoveHistory>()
                .HasOne(h => h.NewEmployee)
                .WithMany()
                .HasForeignKey(h => h.NewEmployeeId)
                .OnDelete(DeleteBehavior.NoAction);

           


        }
    }
}
