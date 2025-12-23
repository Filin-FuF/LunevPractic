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
using DAL;
using Domain;

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
            // Типы оборудования
            var types = _context.EquipmentTypes.ToList();
            cmbType.DataSource = types;
            cmbType.DisplayMember = "Name";
            cmbType.ValueMember = "Id";

            // Сотрудники (первый пункт – не выбран)
            var employees = _context.Employees.ToList();
            employees.Insert(0, new Employee { Id = 0, Name = "<не выбран>" });

            cmbEmployee.DataSource = employees;
            cmbEmployee.DisplayMember = "Name";
            cmbEmployee.ValueMember = "Id";

            // Статусы
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("В работе");
            cmbStatus.Items.Add("На списании");
            cmbStatus.Items.Add("В ремонте");
            cmbStatus.SelectedIndex = 0;

            // Дата постановки на учет по умолчанию – сегодня
            dtpRegistration.Value = DateTime.Today;
        }

        private void button1_Click(object sender, EventArgs e)
        {
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

            int typeId = (int)cmbType.SelectedValue;

            int? employeeId = null;
            if (cmbEmployee.SelectedValue is int empId && empId != 0)
                employeeId = empId;

            var regDate = dtpRegistration.Value.Date;
            var status = cmbStatus.SelectedItem.ToString();

            // Проверка уникальности инвентарного номера (опционально, но полезно)
            if (_context.Equipments.Any(e => e.InventoryNumber == inv))
            {
                MessageBox.Show("Оборудование с таким инвентарным номером уже существует");
                return;
            }

            var eq = new Equipment
            {
                InventoryNumber = inv,
                Name = name,
                EquipmentTypeId = typeId,
                SerialNumber = serial,
                EmployeeId = employeeId,
                RegistrationDate = regDate,
                Status = status
            };

            _context.Equipments.Add(eq);
            _context.SaveChanges();

            DialogResult = DialogResult.OK;
            Close();
        }



    }
}
