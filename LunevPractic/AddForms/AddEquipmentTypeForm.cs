using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LunevPractic.Models;

namespace LunevPractic
{
    public partial class AddEquipmentTypeForm : Form
    {

        public AddEquipmentTypeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var name = textBox1.Text.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Введите название типа");
                return;
            }

            using (var context = new EquipmentContext())
            {
                context.EquipmentTypes.Add(new EquipmentType { Name = name });
                context.SaveChanges();
            }

            
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

