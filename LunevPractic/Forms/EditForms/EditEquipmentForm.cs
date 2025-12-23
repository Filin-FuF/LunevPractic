using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DAL;
using Domain;

namespace LunevPractic.EditForms
{
    public partial class EditEquipmentForm : Form
    {
        private readonly EquipmentContext _context = new EquipmentContext();
        private readonly Equipment _equipment;

        public EditEquipmentForm(Equipment equipment)
        {
            InitializeComponent();
            _equipment = equipment;
        }

        private void EditEquipmentForm_Load(object sender, EventArgs e)
        {
            
            textBoxName.Text = _equipment.Name;
            textBoxName.Text = _equipment.InventoryNumber;

            
            var types = _context.EquipmentTypes.ToList();
            comboBoxType.DataSource = types;
            comboBoxType.DisplayMember = "Name";
            comboBoxType.ValueMember = "Id";

            if (_equipment.EquipmentType != null)
                comboBoxType.SelectedValue = _equipment.EquipmentType.Id;

            
            var deps = _context.Departments.ToList();
            comboBoxDep.DataSource = deps;
            comboBoxDep.DisplayMember = "Name";
            comboBoxDep.ValueMember = "Id";

            

            
            var emps = _context.Employees.ToList();
            emps.Insert(0, new Employee { Id = 0, Name = "<не выбрано>" });

            comboBoxEmp.DataSource = emps;
            comboBoxEmp.DisplayMember = "Name";
            comboBoxEmp.ValueMember = "Id";

            if (_equipment.Employee != null)
                comboBoxEmp.SelectedValue = _equipment.Employee.Id;
            else
                comboBoxEmp.SelectedValue = 0;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var name = textBoxName.Text.Trim();
            var inv = textBoxNum.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(inv))
            {
                MessageBox.Show("Заполните название и инвентарный номер");
                return;
            }

            if (comboBoxType.SelectedValue == null || comboBoxDep.SelectedValue == null)
            {
                MessageBox.Show("Выберите тип и подразделение");
                return;
            }

            int typeId = (int)comboBoxType.SelectedValue;
            int deptId = (int)comboBoxDep.SelectedValue;

            int? employeeId = null;
            if (comboBoxEmp.SelectedValue is int empId && empId != 0)
                employeeId = empId;

           
            _equipment.Name = name;
            _equipment.InventoryNumber = inv;
            _equipment.EquipmentType = _context.EquipmentTypes.First(t => t.Id == typeId);
            

            if (employeeId.HasValue)
                _equipment.Employee = _context.Employees.First(e1 => e1.Id == employeeId.Value);
            else
                _equipment.Employee = null;

            DialogResult = DialogResult.OK;
            Close();
        }

        
    }
}
