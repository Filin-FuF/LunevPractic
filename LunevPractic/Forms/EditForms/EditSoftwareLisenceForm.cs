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

namespace LunevPractic.Forms.EditForms
{
    public partial class EditSoftwareLisenceForm : Form
    {
        private readonly EquipmentContext _context;
        private readonly int _licenseId;
        private SoftwareLicense _license;

        public EditSoftwareLisenceForm(int licenseId)
        {
            InitializeComponent();
            _context = new EquipmentContext();
            _licenseId = licenseId;
        }

        private void EditSoftwareLisenceForm_Load(object sender, EventArgs e)
        {

            _license = _context.SoftwareLicenses
                .FirstOrDefault(x => x.Id == _licenseId);

            if (_license == null)
            {
                MessageBox.Show("Лицензия не найдена");
                DialogResult = DialogResult.Cancel;
                Close();
                return;
            }


            txtName.Text = _license.Name;
            txtManufacturer.Text = _license.Manufacturer;
            txtLicenseKey.Text = _license.LicenseKey;
            dtpExpiry.Value = _license.ExpiryDate;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (_license == null)
            {
                MessageBox.Show("Лицензия не загружена");
                return;
            }

            var name = txtName.Text.Trim();
            var manufacturer = txtManufacturer.Text.Trim();
            var key = txtLicenseKey.Text.Trim();
            var expiry = dtpExpiry.Value.Date;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Укажите название ПО");
                return;
            }

            if (string.IsNullOrWhiteSpace(key))
            {
                MessageBox.Show("Укажите лицензионный ключ");
                return;
            }


            _license.Name = name;
            _license.Manufacturer = manufacturer;
            _license.LicenseKey = key;
            _license.ExpiryDate = expiry;

            _context.SaveChanges();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
