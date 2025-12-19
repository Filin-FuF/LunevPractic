namespace LunevPractic
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            buttonAdd = new Button();
            listBox1 = new ListBox();
            buttonDelete = new Button();
            buttonChange = new Button();
            comboBox1 = new ComboBox();
            statusStrip1 = new StatusStrip();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.ForeColor = Color.Red;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(95, 17);
            toolStripStatusLabel1.Text = "Не подключено";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(12, 397);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(106, 41);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(559, 379);
            listBox1.TabIndex = 1;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(352, 397);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(106, 41);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonChange
            // 
            buttonChange.Location = new Point(464, 397);
            buttonChange.Name = "buttonChange";
            buttonChange.Size = new Size(106, 41);
            buttonChange.TabIndex = 3;
            buttonChange.Text = "Изменить";
            buttonChange.UseVisualStyleBackColor = true;
            buttonChange.Click += buttonChange_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(124, 407);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 440);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(588, 22);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 462);
            Controls.Add(statusStrip1);
            Controls.Add(comboBox1);
            Controls.Add(buttonChange);
            Controls.Add(buttonDelete);
            Controls.Add(listBox1);
            Controls.Add(buttonAdd);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAdd;
        private ListBox listBox1;
        private Button buttonDelete;
        private Button buttonChange;
        private ComboBox comboBox1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}
