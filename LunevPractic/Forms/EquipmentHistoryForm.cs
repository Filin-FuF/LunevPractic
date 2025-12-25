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
using Microsoft.EntityFrameworkCore;


namespace LunevPractic.Forms
{
    public partial class EquipmentHistoryForm : Form
    {
        private readonly EquipmentContext _context = new EquipmentContext();
        private readonly int _equipmentId;

        public EquipmentHistoryForm(int equipmentId)
        {
            InitializeComponent();
            _equipmentId = equipmentId;
        }

        private void EquipmentHistoryForm_Load(object sender, EventArgs e)
        {
            var history = _context.EquipmentMoveHistories
                .Include(h => h.Equipment)
                .Include(h => h.OldEmployee)
                .Include(h => h.NewEmployee)
                .Where(h => h.EquipmentId == _equipmentId)
                .OrderByDescending(h => h.MoveDate)
                .ToList();

            var data = history.Select(h => new
            {
                h.Id,
                Оборудование = h.Equipment.Name,
                ДатаПеремещения = h.MoveDate,
                СтарыйСотрудник = h.OldEmployee != null ? h.OldEmployee.Name : "<не задан>",
                НовыйСотрудник = h.NewEmployee != null ? h.NewEmployee.Name : "<не задан>"
            }).ToList();

            dataGridViewHistory.AutoGenerateColumns = true;
            dataGridViewHistory.DataSource = data;
        }
    }

}

