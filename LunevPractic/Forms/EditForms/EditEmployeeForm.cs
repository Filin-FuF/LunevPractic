using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DAL;
using Domain;


namespace LunevPractic.EditForms
{
    public partial class EditEmployeeForm : Form
    {
        private readonly Employee _employee;

        public EditEmployeeForm(Employee employee)
        {
            InitializeComponent();
            _employee = employee;
        }

        private void EditEmployeeForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = _employee.Name;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var name = textBox1.Text.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Введите ФИО");
                return;
            }

            _employee.Name = name;   
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
