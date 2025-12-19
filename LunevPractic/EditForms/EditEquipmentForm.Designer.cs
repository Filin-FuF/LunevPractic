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
            comboBoxType = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            textBoxName = new TextBox();
            textBoxNum = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBoxDep = new ComboBox();
            label5 = new Label();
            comboBoxEmp = new ComboBox();
            SuspendLayout();
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(12, 115);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(221, 23);
            comboBoxType.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(12, 232);
            button1.Name = "button1";
            button1.Size = new Size(224, 35);
            button1.TabIndex = 1;
            button1.Text = "Изменить";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 2;
            label1.Text = "Новое название";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 27);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(221, 23);
            textBoxName.TabIndex = 3;
            // 
            // textBoxNum
            // 
            textBoxNum.Location = new Point(12, 71);
            textBoxNum.Name = "textBoxNum";
            textBoxNum.Size = new Size(221, 23);
            textBoxNum.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(155, 15);
            label2.TabIndex = 4;
            label2.Text = "Новый уникальный номер";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 6;
            label3.Text = "Новый тип";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 141);
            label4.Name = "label4";
            label4.Size = new Size(128, 15);
            label4.TabIndex = 7;
            label4.Text = "Новое подразделение";
            // 
            // comboBoxDep
            // 
            comboBoxDep.FormattingEnabled = true;
            comboBoxDep.Location = new Point(12, 159);
            comboBoxDep.Name = "comboBoxDep";
            comboBoxDep.Size = new Size(221, 23);
            comboBoxDep.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 185);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 9;
            label5.Text = "Сотрудник";
            // 
            // comboBoxEmp
            // 
            comboBoxEmp.FormattingEnabled = true;
            comboBoxEmp.Location = new Point(12, 203);
            comboBoxEmp.Name = "comboBoxEmp";
            comboBoxEmp.Size = new Size(221, 23);
            comboBoxEmp.TabIndex = 10;
            // 
            // EditEquipmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(248, 272);
            Controls.Add(comboBoxEmp);
            Controls.Add(label5);
            Controls.Add(comboBoxDep);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxNum);
            Controls.Add(label2);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(comboBoxType);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditEquipmentForm";
            Text = "EditEquipmentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxType;
        private Button button1;
        private Label label1;
        private TextBox textBoxName;
        private TextBox textBoxNum;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxDep;
        private Label label5;
        private ComboBox comboBoxEmp;
    }
}