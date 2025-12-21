namespace LunevPractic.Forms.AddForms
{
    partial class AddSoftwareLicenseForm
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
            label1 = new Label();
            label2 = new Label();
            txtManufacturer = new TextBox();
            label3 = new Label();
            txtLicenseKey = new TextBox();
            dtpExpiry = new DateTimePicker();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 188);
            button1.Name = "button1";
            button1.Size = new Size(189, 48);
            button1.TabIndex = 0;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 27);
            txtName.Name = "txtName";
            txtName.Size = new Size(189, 23);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 2;
            label1.Text = "Название ПО";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 3;
            label2.Text = "Производитель";
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(12, 71);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(189, 23);
            txtManufacturer.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 5;
            label3.Text = "Ключ лицензии";
            // 
            // txtLicenseKey
            // 
            txtLicenseKey.Location = new Point(12, 115);
            txtLicenseKey.Name = "txtLicenseKey";
            txtLicenseKey.Size = new Size(189, 23);
            txtLicenseKey.TabIndex = 6;
            // 
            // dtpExpiry
            // 
            dtpExpiry.Location = new Point(12, 159);
            dtpExpiry.Name = "dtpExpiry";
            dtpExpiry.Size = new Size(189, 23);
            dtpExpiry.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 141);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 8;
            label4.Text = "Дата окончания";
            // 
            // AddSoftwareLicenseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(226, 250);
            Controls.Add(label4);
            Controls.Add(dtpExpiry);
            Controls.Add(txtLicenseKey);
            Controls.Add(label3);
            Controls.Add(txtManufacturer);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(button1);
            Name = "AddSoftwareLicenseForm";
            Text = "AddSoftwareLicenseForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtName;
        private Label label1;
        private Label label2;
        private TextBox txtManufacturer;
        private Label label3;
        private TextBox txtLicenseKey;
        private DateTimePicker dtpExpiry;
        private Label label4;
    }
}