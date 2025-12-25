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
using Microsoft.EntityFrameworkCore;

namespace LunevPractic.EditForms
{
    public partial class EditEquipmentForm : Form
    {
        private readonly EquipmentContext _context;
        private readonly int _equipmentId;
        private Equipment _equipment; 

        public EditEquipmentForm(int equipmentId)
        {
            InitializeComponent();
            _context = new EquipmentContext();
            _equipmentId = equipmentId;
        }

        private void EditEquipmentForm_Load(object sender, EventArgs e)
        {
            
            var types = _context.EquipmentTypes.ToList();
            cmbType.DataSource = types;
            cmbType.DisplayMember = "Name";
            cmbType.ValueMember = "Id";

            var deps = _context.Departments.ToList();
            comboBoxDep.DataSource = deps;
            comboBoxDep.DisplayMember = "Name";
            comboBoxDep.ValueMember = "Id";

            var employees = _context.Employees.ToList();
            employees.Insert(0, new Employee { Id = 0, Name = "<не выбран>" });
            cmbEmployee.DataSource = employees;
            cmbEmployee.DisplayMember = "Name";
            cmbEmployee.ValueMember = "Id";

            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("В работе");
            cmbStatus.Items.Add("На списании");
            cmbStatus.Items.Add("В ремонте");

            
            _equipment = _context.Equipments
                .Include(e => e.EquipmentType)
                .Include(e => e.Employee)
                .FirstOrDefault(e => e.Id == _equipmentId);

            if (_equipment == null)
            {
                MessageBox.Show("Оборудование не найдено");
                DialogResult = DialogResult.Cancel;
                Close();
                return;
            }

           
            txtName.Text = _equipment.Name;
            txtInventory.Text = _equipment.InventoryNumber;
            txtSerial.Text = _equipment.SerialNumber;
            dtpRegistration.Value = _equipment.RegistrationDate;

            cmbType.SelectedValue = _equipment.EquipmentTypeId;
            if (_equipment.EmployeeId.HasValue)
                cmbEmployee.SelectedValue = _equipment.EmployeeId.Value;
            else
                cmbEmployee.SelectedValue = 0;

            
            int statusIndex = cmbStatus.Items.IndexOf(_equipment.Status);
            cmbStatus.SelectedIndex = statusIndex >= 0 ? statusIndex : 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int? oldEmployeeId = _equipment.EmployeeId;

            if (_equipment == null)
            {
                MessageBox.Show("Оборудование не загружено");
                return;
            }

            var inv = txtInventory.Text.Trim();
            var name = txtName.Text.Trim();
            var serial = txtSerial.Text.Trim();

            if (string.IsNullOrWhiteSpace(inv) ||
                string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(serial))
            {
                MessageBox.Show("Заполните инвентарный номер, название и серийный номер");
                return;
            }

            if (cmbType.SelectedValue == null)
            {
                MessageBox.Show("Выберите тип оборудования");
                return;
            }
            if (cmbStatus.SelectedItem == null)
            {
                MessageBox.Show("Выберите статус");
                return;
            }

            bool invExists = _context.Equipments
                .Any(e => e.InventoryNumber == inv && e.Id != _equipment.Id);
            if (invExists)
            {
                MessageBox.Show("Оборудование с таким инвентарным номером уже существует");
                return;
            }

            
            _equipment.InventoryNumber = inv;
            _equipment.Name = name;
            _equipment.SerialNumber = serial;
            _equipment.EquipmentTypeId = (int)cmbType.SelectedValue;
            _equipment.RegistrationDate = dtpRegistration.Value.Date;
            _equipment.Status = cmbStatus.SelectedItem.ToString();

            int? newEmployeeId = null;
            if (cmbEmployee.SelectedValue is int empId && empId != 0)
                newEmployeeId = empId;
            _equipment.EmployeeId = newEmployeeId;

            
            if (oldEmployeeId != newEmployeeId)
            {
                var move = new EquipmentMoveHistory
                {
                    EquipmentId = _equipment.Id,
                    MoveDate = DateTime.Now,
                    OldEmployeeId = oldEmployeeId,
                    NewEmployeeId = newEmployeeId
                };

                _context.EquipmentMoveHistories.Add(move);
            }

            
            _context.SaveChanges(); 
            DialogResult = DialogResult.OK;
            Close();

        }
    }
}
