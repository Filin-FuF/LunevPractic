namespace DAL
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
    public class Equipment
    {
        public int Id { get; set; }
        public string InventoryNumber { get; set; }
        public string Name { get; set; }
        public int EquipmentTypeId { get; set; }
        public EquipmentType EquipmentType { get; set; }
        public string SerialNumber { get; set; }

        public int? EmployeeId { get; set; }
        public Employee? Employee { get; set; }

        public DateTime RegistrationDate { get; set; }

        public string Status { get; set; }
    }
    public class EquipmentMoveHistory
    {
        public int Id { get; set; }
        public int EquipmentId { get; set; }
        public Equipment Equipment { get; set; }
        public DateTime MoveDate { get; set; }
        public int? OldEmployeeId { get; set; }
        public Employee? OldEmployee { get; set; }
        public int? NewEmployeeId { get; set; }
        public Employee? NewEmployee { get; set; }
    }
    public class EquipmentType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class InstalledSoftware
    {
        public int EquipmentId { get; set; }
        public Equipment Equipment { get; set; }

        public int SoftwareLicenseId { get; set; }
        public SoftwareLicense SoftwareLicense { get; set; }

        public DateTime InstallDate { get; set; }
    }
    public class SoftwareLicense
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string LicenseKey { get; set; }
        public DateTime ExpiryDate { get; set; }

        public ICollection<InstalledSoftware> InstalledSoftwares { get; set; }
    }
}
