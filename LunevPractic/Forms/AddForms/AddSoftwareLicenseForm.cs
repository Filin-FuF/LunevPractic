using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using DAL;
using Domain;

namespace LunevPractic.Forms.AddForms
{
    public partial class AddSoftwareLicenseForm : Form
    {
        private readonly EquipmentContext _context = new EquipmentContext();
        public AddSoftwareLicenseForm()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e) 
        {
            var name = txtName.Text.Trim();
            var manufacturer = txtManufacturer.Text.Trim();
            var key = txtLicenseKey.Text.Trim();
            var expiry = dtpExpiry.Value;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(manufacturer) || string.IsNullOrWhiteSpace(key))
            {
                MessageBox.Show("Заполните все обязательные поля");
                return;
            }

            
            if (_context.SoftwareLicenses.Any(sl => sl.LicenseKey == key))
            {
                MessageBox.Show("Лицензия с таким ключом уже существует");
                return;
            }

            var license = new SoftwareLicense
            {
                Name = name,
                Manufacturer = manufacturer,
                LicenseKey = key,
                ExpiryDate = expiry
            };

            _context.SoftwareLicenses.Add(license);
            _context.SaveChanges();

            DialogResult = DialogResult.OK;
            Close();
        }

    }
}

