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


namespace LunevPractic.Forms
{
    public partial class EquipmentHistoryForm : Form
    {
        private readonly int _equipmentId;
        private readonly EquipmentContext _ctx = new EquipmentContext();

        public EquipmentHistoryForm(int equipmentId)
        {
            InitializeComponent();
            _equipmentId = equipmentId;
        }
        private void EquipmentHistoryForm_Load(object sender, EventArgs e)
        {
            var history = _ctx.EquipmentMoveHistories
                .Where(h => h.EquipmentId == _equipmentId)
                .OrderByDescending(h => h.MoveDate)
                .Select(h => new
                {
                    Дата = h.MoveDate,
                    Старый = h.OldEmployee != null ? h.OldEmployee.Name : "<нет>",
                    Новый = h.NewEmployee != null ? h.NewEmployee.Name : "<нет>"
                })
                .ToList();

            dataGridViewHistory.DataSource = history;
            dataGridViewHistory.ReadOnly = true;
            dataGridViewHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

    }

}
