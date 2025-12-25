namespace LunevPractic.Forms.EditForms
{
    partial class EditSoftwareLisenceForm
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
            label4 = new Label();
            dtpExpiry = new DateTimePicker();
            txtLicenseKey = new TextBox();
            label3 = new Label();
            txtManufacturer = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtName = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 134);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 17;
            label4.Text = "Дата окончания";
            // 
            // dtpExpiry
            // 
            dtpExpiry.Location = new Point(12, 152);
            dtpExpiry.Name = "dtpExpiry";
            dtpExpiry.Size = new Size(189, 23);
            dtpExpiry.TabIndex = 16;
            // 
            // txtLicenseKey
            // 
            txtLicenseKey.Location = new Point(12, 108);
            txtLicenseKey.Name = "txtLicenseKey";
            txtLicenseKey.Size = new Size(189, 23);
            txtLicenseKey.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 90);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 14;
            label3.Text = "Ключ лицензии";
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(12, 64);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(189, 23);
            txtManufacturer.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 12;
            label2.Text = "Производитель";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 2);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 11;
            label1.Text = "Название ПО";
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 20);
            txtName.Name = "txtName";
            txtName.Size = new Size(189, 23);
            txtName.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(12, 181);
            button1.Name = "button1";
            button1.Size = new Size(189, 48);
            button1.TabIndex = 9;
            button1.Text = "Изменить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // EditSoftwareLisenceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(211, 239);
            Controls.Add(label4);
            Controls.Add(dtpExpiry);
            Controls.Add(txtLicenseKey);
            Controls.Add(label3);
            Controls.Add(txtManufacturer);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(button1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditSoftwareLisenceForm";
            Text = "EditSoftwareLisenceForm";
            Load += EditSoftwareLisenceForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private DateTimePicker dtpExpiry;
        private TextBox txtLicenseKey;
        private Label label3;
        private TextBox txtManufacturer;
        private Label label2;
        private Label label1;
        private TextBox txtName;
        private Button button1;
    }
}