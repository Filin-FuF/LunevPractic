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
    public partial class EditDepartmentForm : Form
    {
        private readonly Department _department;

        public EditDepartmentForm(Department department)
        {
            InitializeComponent();
            _department = department;
        }

        private void EditDepartmentForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = _department.Name;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var name = textBox1.Text.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Введите название");
                return;
            }

            _department.Name = name;   
            DialogResult = DialogResult.OK;
            Close();
        }

        
    }
}
