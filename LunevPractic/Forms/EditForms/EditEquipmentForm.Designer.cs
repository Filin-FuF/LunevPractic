namespace LunevPractic.EditForms
{
    partial class EditEquipmentForm
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
            label7 = new Label();
            cmbStatus = new ComboBox();
            lable = new Label();
            dtpRegistration = new DateTimePicker();
            txtSerial = new TextBox();
            label6 = new Label();
            cmbType = new ComboBox();
            label1 = new Label();
            txtInventory = new TextBox();
            label5 = new Label();
            cmbEmployee = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            comboBoxDep = new ComboBox();
            label2 = new Label();
            txtName = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(193, 147);
            label7.Name = "label7";
            label7.Size = new Size(82, 15);
            label7.TabIndex = 36;
            label7.Text = "Новый статус";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(193, 165);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(175, 23);
            cmbStatus.TabIndex = 35;
            // 
            // lable
            // 
            lable.AutoSize = true;
            lable.Location = new Point(12, 147);
            lable.Name = "lable";
            lable.Size = new Size(142, 15);
            lable.TabIndex = 34;
            lable.Text = "Дата постановки на учёт";
            // 
            // dtpRegistration
            // 
            dtpRegistration.Location = new Point(12, 165);
            dtpRegistration.Name = "dtpRegistration";
            dtpRegistration.Size = new Size(175, 23);
            dtpRegistration.TabIndex = 33;
            // 
            // txtSerial
            // 
            txtSerial.Location = new Point(12, 119);
            txtSerial.Name = "txtSerial";
            txtSerial.Size = new Size(175, 23);
            txtSerial.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 99);
            label6.Name = "label6";
            label6.Size = new Size(104, 15);
            label6.TabIndex = 31;
            label6.Text = "Серийный номер";
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(193, 26);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(175, 23);
            cmbType.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(193, 8);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 29;
            label1.Text = "Новый тип";
            // 
            // txtInventory
            // 
            txtInventory.Location = new Point(12, 72);
            txtInventory.Name = "txtInventory";
            txtInventory.Size = new Size(175, 23);
            txtInventory.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(193, 101);
            label5.Name = "label5";
            label5.Size = new Size(154, 15);
            label5.TabIndex = 27;
            label5.Text = "Работник (Необязательно)";
            // 
            // cmbEmployee
            // 
            cmbEmployee.FormattingEnabled = true;
            cmbEmployee.Location = new Point(193, 119);
            cmbEmployee.Name = "cmbEmployee";
            cmbEmployee.Size = new Size(175, 23);
            cmbEmployee.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 52);
            label4.Name = "label4";
            label4.Size = new Size(122, 15);
            label4.TabIndex = 25;
            label4.Text = "Инвертарный номер";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(193, 54);
            label3.Name = "label3";
            label3.Size = new Size(128, 15);
            label3.TabIndex = 24;
            label3.Text = "Новое подразделение";
            // 
            // comboBoxDep
            // 
            comboBoxDep.FormattingEnabled = true;
            comboBoxDep.Location = new Point(193, 72);
            comboBoxDep.Name = "comboBoxDep";
            comboBoxDep.Size = new Size(175, 23);
            comboBoxDep.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(141, 15);
            label2.TabIndex = 22;
            label2.Text = "Название оборудования";
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 26);
            txtName.Name = "txtName";
            txtName.Size = new Size(175, 23);
            txtName.TabIndex = 21;
            // 
            // button1
            // 
            button1.Location = new Point(12, 194);
            button1.Name = "button1";
            button1.Size = new Size(356, 52);
            button1.TabIndex = 20;
            button1.Text = "Изменить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // EditEquipmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 256);
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
            Name = "EditEquipmentForm";
            Text = "EditEquipmentForm";
            Load += EditEquipmentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private ComboBox cmbStatus;
        private Label lable;
        private DateTimePicker dtpRegistration;
        private TextBox txtSerial;
        private Label label6;
        private ComboBox cmbType;
        private Label label1;
        private TextBox txtInventory;
        private Label label5;
        private ComboBox cmbEmployee;
        private Label label4;
        private Label label3;
        private ComboBox comboBoxDep;
        private Label label2;
        private TextBox txtName;
        private Button button1;
    }
}