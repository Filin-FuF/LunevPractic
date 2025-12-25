namespace LunevPractic.Forms.EditForms
{
    partial class EditInstalledSoftwareForm
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
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 92);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 20;
            label3.Text = "Лицензия ПО";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 110);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(215, 23);
            dateTimePicker1.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 18;
            label2.Text = "Лицензия ПО";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(12, 66);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(215, 23);
            comboBox2.TabIndex = 17;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(215, 23);
            comboBox1.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 4);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 15;
            label1.Text = "Оборудование";
            // 
            // button1
            // 
            button1.Location = new Point(12, 139);
            button1.Name = "button1";
            button1.Size = new Size(215, 51);
            button1.TabIndex = 14;
            button1.Text = "Изменить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // EditInstalledSoftwareForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(239, 197);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "EditInstalledSoftwareForm";
            Text = "EditInstalledSoftwareForm";
            Load += EditInstalledSoftwareForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label1;
        private Button button1;
    }
}