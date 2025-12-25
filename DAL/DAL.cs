using Domain;
using Microsoft.EntityFrameworkCore;


namespace DAL
{
    public class EquipmentContext : DbContext
    {


        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EquipmentType> EquipmentTypes { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<SoftwareLicense> SoftwareLicenses { get; set; }
        public DbSet<InstalledSoftware> InstalledSoftwares { get; set; }

        public DbSet<EquipmentMoveHistory> EquipmentMoveHistories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EquipmentAccounting;Integrated Security=True;");
            }
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
