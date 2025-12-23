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
    public partial class AddDepartmentForm : Form
    {
        public AddDepartmentForm()
        {
            InitializeComponent();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            var name = textBox1.Text.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Введите название подразделения");
                return;
            }

            using (var ctx = new EquipmentContext())
            {
                ctx.Departments.Add(new Department { Name = name });
                ctx.SaveChanges();
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
