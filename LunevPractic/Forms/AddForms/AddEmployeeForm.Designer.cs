namespace LunevPractic
{
    partial class AddEmployeeForm
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
            components = new System.ComponentModel.Container();
            toolTip1 = new ToolTip(components);
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            comboBoxDep = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 104);
            button1.Name = "button1";
            button1.Size = new Size(229, 40);
            button1.TabIndex = 0;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 1;
            label1.Text = "ФИО Работника";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(229, 23);
            textBox1.TabIndex = 2;
            // 
            // comboBoxDep
            // 
            comboBoxDep.FormattingEnabled = true;
            comboBoxDep.Location = new Point(12, 75);
            comboBoxDep.Name = "comboBoxDep";
            comboBoxDep.Size = new Size(229, 23);
            comboBoxDep.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 4;
            label2.Text = "Подразделение";
            // 
            // AddEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(253, 156);
            Controls.Add(label2);
            Controls.Add(comboBoxDep);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddEmployeeForm";
            Text = "Добавить работника";
            Load += this.AddEmployeeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolTip toolTip1;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private ComboBox comboBoxDep;
        private Label label2;
    }
}