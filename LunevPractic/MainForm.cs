using System.Data;
using System.Windows.Forms;
using LunevPractic.Models;
using Microsoft.EntityFrameworkCore;

namespace LunevPractic
{
    public partial class MainForm : Form
    {
        private readonly EquipmentContext _context = new EquipmentContext();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Add("Сотрудник");
            comboBox1.Items.Add("Подразделение");
            comboBox1.Items.Add("Оборудование");
            comboBox1.Items.Add("Тип оборудования");
            comboBox1.SelectedIndex = 0;
            
            UpdateToolStatus();





        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshListBox();
            listBox1.Items.Clear();
            switch (comboBox1.SelectedItem?.ToString())
            {
                case "Подразделение":
                    foreach (var d in _context.Departments.ToList())
                        listBox1.Items.Add($"{d.Id}: {d.Name}");
                    break;

                case "Сотрудник":
                    foreach (var e1 in _context.Employees.ToList())
                        listBox1.Items.Add($"{e1.Id}: {e1.Name} (Dept {e1.DepartmentId})");
                    break;

                case "Оборудование":
                    foreach (var eq in _context.Equipments.ToList())
                        listBox1.Items.Add($"{eq.Id}: {eq.InventoryNumber} - {eq.Name}");
                    break;
                case "Тип оборудования":
                    foreach (var et in _context.EquipmentTypes.ToList())
                    {
                        listBox1.Items.Add($"{et.Id}: {et.Name}");
                    }
                    break;
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var selected = comboBox1.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selected))
                return;

            switch (selected)
            {
                case "Сотрудник":
                    AddEmployeeForm addFormEmp = new AddEmployeeForm();
                    if (addFormEmp.ShowDialog() == DialogResult.OK)
                    {
                        RefreshListBox();
                    }
                    break;
                case "Подразделение":
                    AddDepartmentForm addFormDep = new AddDepartmentForm();
                    if (addFormDep.ShowDialog() == DialogResult.OK)
                    {
                        RefreshListBox();
                    }
                    break;
                case "Оборудование":
                    AddEquipmentForm addFormEqp = new AddEquipmentForm();
                    if (addFormEqp.ShowDialog() == DialogResult.OK)
                    {
                        RefreshListBox();
                    }
                    break;
                case "Тип оборудования":
                    AddEmployeeForm addFormEqpT = new AddEmployeeForm();
                    if (addFormEqpT.ShowDialog() == DialogResult.OK)
                    {
                        RefreshListBox();
                    }
                    break;
                default:
                    return;
            }


        }
        private void UpdateToolStatus()
        {
            if (CheckDbConnection())
            {
                toolStripStatusLabel1.Text = "БД: подключено";
                toolStripStatusLabel1.ForeColor = Color.Green;
            }
            else
            {
                toolStripStatusLabel1.Text = "БД: нет подключения";
                toolStripStatusLabel1.ForeColor = Color.Red;
            }
        }

        private bool CheckDbConnection()
        {
            try
            {
                using (var ctx = new EquipmentContext())
                {
                    ctx.Departments.FirstOrDefault();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        private int? GetSelectedDepartmentId()
        {
            if (listBox1.SelectedItem == null)
                return null;

            var text = listBox1.SelectedItem.ToString();
            var parts = text.Split(':');
            if (int.TryParse(parts[0], out int id))
                return id;

            return null;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            var id = GetSelectedDepartmentId();
            if (id == null)
            {
                MessageBox.Show("Выберите элемент для удаления");
                return;
            }

            using (var ctx = new EquipmentContext())
            {
                var dep = ctx.Departments.FirstOrDefault(d => d.Id == id.Value);
                if (dep == null)
                {
                    MessageBox.Show("Элемент не найден в базе");
                    return;
                }

                ctx.Departments.Remove(dep);
                ctx.SaveChanges();
            }


            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            var id = GetSelectedIdFromListBox();
            if (id == null)
            {
                MessageBox.Show("Выберите запись для изменения");
                return;
            }

            var selectedTable = comboBox1.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedTable))
                return;

            using (var ctx = new EquipmentContext())
            {
                switch (selectedTable)
                {
                    case "Подразделения":
                        {
                            var dep = ctx.Departments.FirstOrDefault(d => d.Id == id.Value);
                            if (dep == null) { MessageBox.Show("Запись не найдена"); return; }

                            using (var f = new EditForms.EditDepartmentForm(dep))
                            {
                                if (f.ShowDialog() == DialogResult.OK)
                                {
                                    ctx.SaveChanges();
                                    RefreshListBox();
                                }
                            }
                            RefreshListBox();
                            break;
                        }

                    case "Сотрудники":
                        {
                            var emp = ctx.Employees.FirstOrDefault(x => x.Id == id.Value);
                            if (emp == null) { MessageBox.Show("Запись не найдена"); return; }

                            using (var f = new EditForms.EditEmployeeForm(emp))
                            {
                                if (f.ShowDialog() == DialogResult.OK)
                                {
                                    ctx.SaveChanges();
                                    RefreshListBox();
                                }
                            }
                            RefreshListBox();
                            break;
                        }

                    case "Оборудование":
                        {
                            var eq = ctx.Equipments
                                       .Include(x => x.EquipmentType)
                                       .Include(x => x.Department)
                                       .Include(x => x.Employee)
                                       .FirstOrDefault(x => x.Id == id.Value);
                            if (eq == null) { MessageBox.Show("Запись не найдена"); return; }

                            using (var f = new EditForms.EditEquipmentForm(eq))
                            {
                                if (f.ShowDialog() == DialogResult.OK)
                                {
                                    ctx.SaveChanges();
                                    RefreshListBox();
                                }
                            }
                            RefreshListBox();
                            break;
                        }

                    case "Типы оборудования":
                        {
                            var tp = ctx.EquipmentTypes.FirstOrDefault(x => x.Id == id.Value);
                            if (tp == null) { MessageBox.Show("Запись не найдена"); return; }

                            using (var f = new EditForms.EditEquipmentTypeForm(tp))
                            {
                                if (f.ShowDialog() == DialogResult.OK)
                                {
                                    ctx.SaveChanges();
                                    RefreshListBox();
                                }
                            }
                            RefreshListBox();
                            break;
                        }
                }
            }
        }
        private void RefreshListBox()
        {
            listBox1.Items.Clear();

            using var ctx = new EquipmentContext();

            var selected = comboBox1.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selected))
                return;

            switch (selected)
            {
                case "Подразделения":
                    foreach (var d in ctx.Departments)
                        listBox1.Items.Add($"{d.Id}: {d.Name}");
                    break;

                case "Сотрудники":
                    foreach (var e in ctx.Employees)
                        listBox1.Items.Add($"{e.Id}: {e.Name}");
                    break;

                case "Оборудование":
                    foreach (var q in ctx.Equipments)
                        listBox1.Items.Add($"{q.Id}: {q.InventoryNumber} - {q.Name}");
                    break;

                case "Типы оборудования":
                    foreach (var t in ctx.EquipmentTypes)
                        listBox1.Items.Add($"{t.Id}: {t.Name}");
                    break;
            }
        }
        private int? GetSelectedIdFromListBox()
        {
            if (listBox1.SelectedItem == null)
                return null;

            var text = listBox1.SelectedItem.ToString();   
            var parts = text.Split(':');
            if (int.TryParse(parts[0], out int id))
                return id;

            return null;
        }


    }
}
