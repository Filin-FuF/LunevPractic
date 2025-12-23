using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using DAL;
namespace LunevPractic.Forms.AddForms
{
    public partial class AddInstalledSoftwareForm : Form
    {
        private readonly EquipmentContext _context = new EquipmentContext();
        public AddInstalledSoftwareForm()
        {
            InitializeComponent();
        }

        private void AddInstalledSoftwareForm_Load(object sender, EventArgs e)
        {

        }
    }
}
