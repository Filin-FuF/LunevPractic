using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunevPractic.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public string InventoryNumber { get; set; }
        public string Name { get; set; }
        public EquipmentType EquipmentType { get; set; }
        public Department Department { get; set; }
        public Employee? Employee { get; set; }
    }
}
