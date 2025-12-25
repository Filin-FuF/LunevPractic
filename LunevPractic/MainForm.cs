using System.Data;
using System.Windows.Forms;
using DAL;
using LunevPractic.Forms;
using LunevPractic.Forms.AddForms;
using LunevPractic.Forms.EditForms;
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
            comboBox1.Items.Add("Установленное ПО");
            comboBox1.Items.Add("Лицензия ПО");

            comboBox1.SelectedIndex = 0;
            RefreshListBox();
            UpdateToolStatus();





        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshListBox();
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
                    AddEquipmentTypeForm addFormEqpT = new AddEquipmentTypeForm();
                    if (addFormEqpT.ShowDialog() == DialogResult.OK)
                    {
                        RefreshListBox();
                    }
                    break;
                case "Установленное ПО":
                    using (var addInsSoft = new AddInstalledSoftwareForm())
                    {
                        if (addInsSoft.ShowDialog() == DialogResult.OK)
                        {
                            RefreshListBox();
                        }
                    }
                    break;
                case "Лицензия ПО":
                    AddSoftwareLicenseForm addSoftwareLicense = new AddSoftwareLicenseForm();
                    if (addSoftwareLicense.ShowDialog() == DialogResult.OK)
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
                if (listBox1.SelectedItem == null)
                {
                    MessageBox.Show("Выберите запись для удаления");
                    return;
                }

                // Определяем, какой тип данных отображается
                var selectedText = listBox1.SelectedItem.ToString();
                var selectedId = GetIdFromSelectedText(selectedText); // функция для извлечения Id

                if (selectedId == null)
                {
                    MessageBox.Show("Не удалось определить ID записи");
                    return;
                }

                switch (comboBox1.SelectedItem?.ToString())
                {
                    case "Сотрудник":
                        var employee = ctx.Employees.FirstOrDefault(e => e.Id == selectedId.Value);
                        if (employee != null)
                        {
                            ctx.Employees.Remove(employee);
                            ctx.SaveChanges();
                        }
                        break;

                    case "Подразделение":
                        var department = ctx.Departments.FirstOrDefault(d => d.Id == selectedId.Value);
                        if (department != null)
                        {
                            ctx.Departments.Remove(department);
                            ctx.SaveChanges();
                        }
                        break;

                    case "Оборудование":
                        var equipment = ctx.Equipments.FirstOrDefault(q => q.Id == selectedId.Value);
                        if (equipment != null)
                        {
                            ctx.Equipments.Remove(equipment);
                            ctx.SaveChanges();
                        }
                        break;

                    case "Установленное ПО":
                        var installedSoftware = ctx.InstalledSoftwares.FirstOrDefault(s => s.Id == selectedId.Value);
                        if (installedSoftware != null)
                        {
                            ctx.InstalledSoftwares.Remove(installedSoftware);
                            ctx.SaveChanges();
                        }
                        break;
                    case "Лицензия ПО":
                        var softwareLicense = ctx.SoftwareLicenses.FirstOrDefault(sl => sl.Id == selectedId.Value);
                        if (softwareLicense != null)
                        {
                            ctx.SoftwareLicenses.Remove(softwareLicense);
                            ctx.SaveChanges();
                        }
                        break;

                }

                RefreshListBox();
            }
        }
        private int? GetIdFromSelectedText(string text)
        {
            if (string.IsNullOrEmpty(text))
                return null;

            var parts = text.Split(':');
            if (parts.Length > 0 && int.TryParse(parts[0], out int id))
                return id;

            return null;
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
                    case "Подразделение":
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

                    case "Сотрудник":
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

                            break;
                        }

                    case "Оборудование":
                        {
                            var eq = ctx.Equipments
                                       .Include(x => x.EquipmentType)
                                       .Include(x => x.Employee)
                                       .FirstOrDefault(x => x.Id == id.Value);

                            if (eq == null)
                            {
                                MessageBox.Show("Запись не найдена");
                                return;
                            }

                            using (var f = new EditForms.EditEquipmentForm(eq.Id))
                            {
                                if (f.ShowDialog() == DialogResult.OK)
                                {
                                    ctx.SaveChanges();
                                    RefreshListBox();
                                }
                            }
                            break;
                        }


                    case "Тип оборудования":
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
                    case "Установленное ПО":

                        {
                            var @is = ctx.InstalledSoftwares.FirstOrDefault(x => x.Id == id.Value);
                            if (@is == null)
                            {
                                MessageBox.Show("Запись не найдена");
                                return;
                            }

                            using (var f = new EditInstalledSoftwareForm(ctx, @is, RefreshListBox))
                            {
                                if (f.ShowDialog() == DialogResult.OK)
                                {

                                    RefreshListBox();
                                }
                            }
                            break;
                        }
                    case "Лицензия ПО":

                        {
                            var sl = ctx.SoftwareLicenses.FirstOrDefault(x => x.Id == id.Value);
                            if (sl == null)
                            {
                                MessageBox.Show("Запись не найдена");
                                return;
                            }

                            using (var f = new EditSoftwareLisenceForm(sl.Id))
                            {
                                if (f.ShowDialog() == DialogResult.OK)
                                {

                                    RefreshListBox();
                                }
                            }
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
                case "Подразделение":
                    foreach (var d in ctx.Departments)
                        listBox1.Items.Add($"{d.Id}: {d.Name}");
                    break;

                case "Сотрудник":
                    foreach (var e in ctx.Employees)
                        listBox1.Items.Add($"{e.Id}: {e.Name}");
                    break;

                case "Оборудование":
                    foreach (var q in ctx.Equipments)
                        listBox1.Items.Add($"{q.Id}: {q.InventoryNumber} - {q.Name}");
                    break;

                case "Тип оборудования":
                    foreach (var t in ctx.EquipmentTypes)
                        listBox1.Items.Add($"{t.Id}: {t.Name}");
                    break;

                case "Установленное ПО":
                    foreach (var s in ctx.InstalledSoftwares)
                        listBox1.Items.Add($"{s.Id}: {s.EquipmentId} - {s.SoftwareLicenseId} - {s.InstallDate}");
                    break;

                case "Лицензия ПО":
                    foreach (var s in ctx.SoftwareLicenses)
                        listBox1.Items.Add($"{s.Id}: {s.Name} - {s.Manufacturer} - {s.LicenseKey} - {s.ExpiryDate}");
                    break;
                default:
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

        private int? GetSelectedEquipmentId()
        {
            if (comboBox1.SelectedItem?.ToString() != "Оборудование")
                return null;

            if (listBox1.SelectedItem == null)
                return null;

            var text = listBox1.SelectedItem.ToString();
            var parts = text.Split(':');
            if (int.TryParse(parts[0], out int id))
                return id;

            return null;
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            var id = GetSelectedEquipmentId();
            if (id == null)
            {
                MessageBox.Show("Выберите оборудование в списке");
                return;
            }

            using (var f = new EquipmentHistoryForm(id.Value))
            {
                f.ShowDialog();
            }
        }

    }
}
