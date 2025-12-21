namespace LunevPractic
{
    partial class AddEquipmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            txtName = new TextBox();
            label2 = new Label();
            comboBoxDep = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            cmbEmployee = new ComboBox();
            label5 = new Label();
            txtInventory = new TextBox();
            label1 = new Label();
            cmbType = new ComboBox();
            txtSerial = new TextBox();
            label6 = new Label();
            dtpRegistration = new DateTimePicker();
            lable = new Label();
            cmbStatus = new ComboBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 194);
            button1.Name = "button1";
            button1.Size = new Size(356, 52);
            button1.TabIndex = 1;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 26);
            txtName.Name = "txtName";
            txtName.Size = new Size(175, 23);
            txtName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(141, 15);
            label2.TabIndex = 4;
            label2.Text = "Название оборудования";
            // 
            // comboBoxDep
            // 
            comboBoxDep.FormattingEnabled = true;
            comboBoxDep.Location = new Point(193, 72);
            comboBoxDep.Name = "comboBoxDep";
            comboBoxDep.Size = new Size(175, 23);
            comboBoxDep.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(193, 54);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 6;
            label3.Text = "Подразделение";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 52);
            label4.Name = "label4";
            label4.Size = new Size(122, 15);
            label4.TabIndex = 7;
            label4.Text = "Инвертарный номер";
            // 
            // cmbEmployee
            // 
            cmbEmployee.FormattingEnabled = true;
            cmbEmployee.Location = new Point(193, 119);
            cmbEmployee.Name = "cmbEmployee";
            cmbEmployee.Size = new Size(175, 23);
            cmbEmployee.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(193, 101);
            label5.Name = "label5";
            label5.Size = new Size(154, 15);
            label5.TabIndex = 10;
            label5.Text = "Работник (Необязательно)";
            // 
            // txtInventory
            // 
            txtInventory.Location = new Point(12, 72);
            txtInventory.Name = "txtInventory";
            txtInventory.Size = new Size(175, 23);
            txtInventory.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(193, 8);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 12;
            label1.Text = "Тип оборудования";
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(193, 26);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(175, 23);
            cmbType.TabIndex = 13;
            // 
            // txtSerial
            // 
            txtSerial.Location = new Point(12, 119);
            txtSerial.Name = "txtSerial";
            txtSerial.Size = new Size(175, 23);
            txtSerial.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 99);
            label6.Name = "label6";
            label6.Size = new Size(104, 15);
            label6.TabIndex = 14;
            label6.Text = "Серийный номер";
            // 
            // dtpRegistration
            // 
            dtpRegistration.Location = new Point(12, 165);
            dtpRegistration.Name = "dtpRegistration";
            dtpRegistration.Size = new Size(175, 23);
            dtpRegistration.TabIndex = 16;
            // 
            // lable
            // 
            lable.AutoSize = true;
            lable.Location = new Point(12, 147);
            lable.Name = "lable";
            lable.Size = new Size(142, 15);
            lable.TabIndex = 17;
            lable.Text = "Дата постановки на учёт";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(193, 165);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(175, 23);
            cmbStatus.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(193, 147);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 19;
            label7.Text = "Статус";
            // 
            // AddEquipmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 253);
            Controls.Add(label7);
            Controls.Add(cmbStatus);
            Controls.Add(lable);
            Controls.Add(dtpRegistration);
            Controls.Add(txtSerial);
            Controls.Add(label6);
            Controls.Add(cmbType);
            Controls.Add(label1);
            Controls.Add(txtInventory);
            Controls.Add(label5);
            Controls.Add(cmbEmployee);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBoxDep);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(button1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddEquipmentForm";
            Text = "Добавить оборудование";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private TextBox txtName;
        private Label label2;
        private ComboBox comboBoxDep;
        private Label label3;
        private Label label4;
        private ComboBox cmbEmployee;
        private Label label5;
        private TextBox txtInventory;
        private Label label1;
        private ComboBox cmbType;
        private TextBox txtSerial;
        private Label label6;
        private DateTimePicker dtpRegistration;
        private Label lable;
        private ComboBox cmbStatus;
        private Label label7;
    }
}