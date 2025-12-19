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

        
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EquipmentType> EquipmentTypes { get; set; }
        public DbSet<Equipment> Equipments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(
                    "Data Source=.\\SQLEXPRESS01;Initial Catalog=EquipmentAccounting;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");
        }



    }
}
