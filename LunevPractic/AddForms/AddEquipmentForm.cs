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
using LunevPractic.Models;

namespace LunevPractic
{
    public partial class AddEquipmentForm : Form
    {
        private readonly EquipmentContext _context = new EquipmentContext();
        public AddEquipmentForm()
        {
            InitializeComponent();
        }
        private void AddEquipmentForm_Load(object sender, EventArgs e)
        {
            comboBoxEqpTp.DataSource = _context.EquipmentTypes.ToList();
            comboBoxEqpTp.DisplayMember = "Name";
            comboBoxEqpTp.ValueMember = "Id";

            comboBoxDep.DataSource = _context.Departments.ToList();
            comboBoxDep.DisplayMember = "Name";
            comboBoxDep.ValueMember = "Id";

            var employees = _context.Employees.ToList();
            employees.Insert(0, new Employee { Id = 0, Name = "<не выбрано>" });
            comboBoxEmp.DataSource = employees;
            comboBoxEmp.DisplayMember = "Name";
            comboBoxEmp.ValueMember = "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var name = textBoxName.Text.Trim();
            var inv = textBoxNum.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(inv))
            {
                MessageBox.Show("Заполните название и инвентарный номер");
                return;
            }

            if (comboBoxEqpTp.SelectedValue == null || comboBoxDep.SelectedValue == null)
            {
                MessageBox.Show("Выберите тип и подразделение");
                return;
            }

            int typeId = (int)comboBoxEqpTp.SelectedValue;
            int deptId = (int)comboBoxDep.SelectedValue;

            int? employeeId = null;
            if (comboBoxEmp.SelectedValue is int empId && empId != 0)
                employeeId = empId;

            
            var type = _context.EquipmentTypes.First(t => t.Id == typeId);
            var dept = _context.Departments.First(d => d.Id == deptId);
            Employee emp = null;
            if (employeeId.HasValue)
                emp = _context.Employees.First(e => e.Id == employeeId.Value);

            var eq = new Equipment
            {
                Name = name,
                InventoryNumber = inv,
                EquipmentType = type,
                Department = dept,
                Employee = emp   
            };

            _context.Equipments.Add(eq);
            _context.SaveChanges();

            DialogResult = DialogResult.OK;
            Close();


        }
    }
}
