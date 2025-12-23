using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Domain;

namespace LunevPractic
{
    public partial class AddEmployeeForm : Form
    {
        
        public AddEmployeeForm()
        {
            InitializeComponent();
        }
        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            using (var ctx = new EquipmentContext())
            {
                comboBoxDep.DataSource = ctx.Departments.ToList();
                comboBoxDep.DisplayMember = "Name";
                comboBoxDep.ValueMember = "Id";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var fio = textBox1.Text.Trim();
            if (string.IsNullOrWhiteSpace(fio))
            {
                MessageBox.Show("Введите ФИО сотрудника");
                return;
            }

            if (comboBoxDep.SelectedValue == null)
            {
                MessageBox.Show("Выберите подразделение");
                return;
            }

            int deptId = (int)comboBoxDep.SelectedValue;

            using (var ctx = new EquipmentContext())
            {
                ctx.Employees.Add(new Employee
                {
                    Name = fio,
                    DepartmentId = deptId   
                });

                ctx.SaveChanges();
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
