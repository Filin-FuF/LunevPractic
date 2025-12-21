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

namespace LunevPractic.EditForms
{
    public partial class EditEquipmentTypeForm : Form
    {
        private readonly EquipmentType _equipmentType;

        public EditEquipmentTypeForm(EquipmentType equipmentType)
        {
            InitializeComponent();
            _equipmentType = equipmentType;
        }

        private void EditEquipmentTypeForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = _equipmentType.Name;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var name = textBox1.Text.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Введите название");
                return;
            }

            _equipmentType.Name = name;   
            DialogResult = DialogResult.OK;
            Close();
        }

        private void EditEquipmentTypeForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}

