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
        private readonly EquipmentContext _ctx = new EquipmentContext();
        public AddDepartmentForm()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
            var department = new Department
            {
                Name = textBox1.Text.Trim()
            };

            if (string.IsNullOrEmpty(department.Name))
            {
                MessageBox.Show("Введите название подразделения");
                return;
            }

            try
            {
                _ctx.Departments.Add(department);
                _ctx.SaveChanges();
                MessageBox.Show("Подразделение добавлено");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении: {ex.Message}");
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
