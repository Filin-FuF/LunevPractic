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
            textBoxName = new TextBox();
            label2 = new Label();
            comboBoxDep = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            comboBoxEmp = new ComboBox();
            label5 = new Label();
            textBoxNum = new TextBox();
            label1 = new Label();
            comboBoxEqpTp = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(42, 264);
            button1.Name = "button1";
            button1.Size = new Size(111, 52);
            button1.TabIndex = 1;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 29);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(175, 23);
            textBoxName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 11);
            label2.Name = "label2";
            label2.Size = new Size(141, 15);
            label2.TabIndex = 4;
            label2.Text = "Название оборудования";
            // 
            // comboBoxDep
            // 
            comboBoxDep.FormattingEnabled = true;
            comboBoxDep.Location = new Point(12, 161);
            comboBoxDep.Name = "comboBoxDep";
            comboBoxDep.Size = new Size(175, 23);
            comboBoxDep.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 143);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 6;
            label3.Text = "Подразделение";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 55);
            label4.Name = "label4";
            label4.Size = new Size(115, 15);
            label4.TabIndex = 7;
            label4.Text = "Уникальный номер";
            // 
            // comboBoxEmp
            // 
            comboBoxEmp.FormattingEnabled = true;
            comboBoxEmp.Location = new Point(12, 205);
            comboBoxEmp.Name = "comboBoxEmp";
            comboBoxEmp.Size = new Size(175, 23);
            comboBoxEmp.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 187);
            label5.Name = "label5";
            label5.Size = new Size(154, 15);
            label5.TabIndex = 10;
            label5.Text = "Работник (Необязательно)";
            // 
            // textBoxNum
            // 
            textBoxNum.Location = new Point(12, 73);
            textBoxNum.Name = "textBoxNum";
            textBoxNum.Size = new Size(175, 23);
            textBoxNum.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 99);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 12;
            label1.Text = "Тип оборудования";
            // 
            // comboBoxEqpTp
            // 
            comboBoxEqpTp.FormattingEnabled = true;
            comboBoxEqpTp.Location = new Point(12, 117);
            comboBoxEqpTp.Name = "comboBoxEqpTp";
            comboBoxEqpTp.Size = new Size(175, 23);
            comboBoxEqpTp.TabIndex = 13;
            // 
            // AddEquipmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(201, 328);
            Controls.Add(comboBoxEqpTp);
            Controls.Add(label1);
            Controls.Add(textBoxNum);
            Controls.Add(label5);
            Controls.Add(comboBoxEmp);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBoxDep);
            Controls.Add(label2);
            Controls.Add(textBoxName);
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
        private TextBox textBoxName;
        private Label label2;
        private ComboBox comboBoxDep;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxEmp;
        private Label label5;
        private TextBox textBoxNum;
        private Label label1;
        private ComboBox comboBoxEqpTp;
    }
}