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

namespace LunevPractic.Forms.EditForms
{
    public partial class EditInstalledSoftwareForm : Form
    {
        private readonly EquipmentContext _context;
        private readonly InstalledSoftware _installedSoftware;
        private readonly Action _onUpdated;

        public EditInstalledSoftwareForm(EquipmentContext context, InstalledSoftware installedSoftware, Action onUpdated)
        {
            InitializeComponent();
            _context = context;
            _installedSoftware = installedSoftware;
            _onUpdated = onUpdated;
        }





        private void EditInstalledSoftwareForm_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = _context.Equipments.ToList();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
            comboBox1.SelectedValue = _installedSoftware.EquipmentId;

            comboBox2.DataSource = _context.SoftwareLicenses.ToList();
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "Id";
            comboBox2.SelectedValue = _installedSoftware.SoftwareLicenseId;


            dateTimePicker1.Value = _installedSoftware.InstallDate;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null || comboBox2.SelectedValue == null)
                return;

            _installedSoftware.EquipmentId = (int)comboBox1.SelectedValue;
            _installedSoftware.SoftwareLicenseId = (int)comboBox2.SelectedValue;
            _installedSoftware.InstallDate = dateTimePicker1.Value.Date;

            _context.SaveChanges();

            MessageBox.Show("Запись обновлена.");
            _onUpdated?.Invoke();
            Close();
        }
    }

}
