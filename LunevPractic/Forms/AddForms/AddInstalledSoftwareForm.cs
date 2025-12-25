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

namespace LunevPractic.Forms.AddForms
{
    public partial class AddInstalledSoftwareForm : Form
    {
        private readonly EquipmentContext _context;

        public AddInstalledSoftwareForm()
        {
            InitializeComponent();
            _context = new EquipmentContext();
        }






        private void AddInstalledSoftwareForm_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = _context.Equipments.ToList();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";

            comboBox2.DataSource = _context.SoftwareLicenses.ToList();
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "Id";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null || comboBox2.SelectedValue == null)
                return;

            var installedSoftware = new InstalledSoftware
            {
                EquipmentId = (int)comboBox1.SelectedValue,
                SoftwareLicenseId = (int)comboBox2.SelectedValue,
                InstallDate = dateTimePicker1.Value.Date
            };

            _context.InstalledSoftwares.Add(installedSoftware);
            _context.SaveChanges();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
