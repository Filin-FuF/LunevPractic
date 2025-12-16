using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LunevPractic.Models
{
    public class EquipmentContext : DbContext
    {

        public EquipmentContext() 
        {
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EquipmentType> EquipmentTypes { get; set; }
        public DbSet<Equipment> Equipments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=svin;Database=EquipmentAccounting;Trusted_Connection=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<EquipmentType>().HasData(
            new EquipmentType { Id = 1, Name = "Компьютер" },
            new EquipmentType { Id = 2, Name = "Принтер" },
            new
   
);
        }
    }
}
