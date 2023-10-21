namespace HistoricalGuide
{
    partial class Request20
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            textBoxPersonMiddleName = new TextBox();
            textBoxPersonSurname = new TextBox();
            labelPersonMiddleName = new Label();
            labelPersonSurname = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            textBoxPersonName = new TextBox();
            labelPersonName = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBoxPersonMiddleName
            // 
            textBoxPersonMiddleName.Location = new Point(270, 98);
            textBoxPersonMiddleName.Name = "textBoxPersonMiddleName";
            textBoxPersonMiddleName.Size = new Size(213, 26);
            textBoxPersonMiddleName.TabIndex = 19;
            // 
            // textBoxPersonSurname
            // 
            textBoxPersonSurname.Location = new Point(248, 135);
            textBoxPersonSurname.Name = "textBoxPersonSurname";
            textBoxPersonSurname.Size = new Size(213, 26);
            textBoxPersonSurname.TabIndex = 18;
            // 
            // labelPersonMiddleName
            // 
            labelPersonMiddleName.AutoSize = true;
            labelPersonMiddleName.Font = new Font("Arial Narrow", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point);
            labelPersonMiddleName.ForeColor = Color.DarkGreen;
            labelPersonMiddleName.Location = new Point(26, 95);
            labelPersonMiddleName.Name = "labelPersonMiddleName";
            labelPersonMiddleName.Size = new Size(238, 26);
            labelPersonMiddleName.TabIndex = 17;
            labelPersonMiddleName.Text = "По-батькові особистість:";
            // 
            // labelPersonSurname
            // 
            labelPersonSurname.AutoSize = true;
            labelPersonSurname.Font = new Font("Arial Narrow", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point);
            labelPersonSurname.ForeColor = Color.DarkGreen;
            labelPersonSurname.Location = new Point(26, 132);
            labelPersonSurname.Name = "labelPersonSurname";
            labelPersonSurname.Size = new Size(216, 26);
            labelPersonSurname.TabIndex = 16;
            labelPersonSurname.Text = "Призвіще особистість:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 237);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 8.765218F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.RowHeadersWidth = 49;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(1065, 290);
            dataGridView1.TabIndex = 15;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Narrow", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkGreen;
            button1.Location = new Point(26, 183);
            button1.Name = "button1";
            button1.Size = new Size(90, 48);
            button1.TabIndex = 14;
            button1.Text = "Знайти";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxPersonName
            // 
            textBoxPersonName.Location = new Point(196, 52);
            textBoxPersonName.Name = "textBoxPersonName";
            textBoxPersonName.Size = new Size(213, 26);
            textBoxPersonName.TabIndex = 13;
            // 
            // labelPersonName
            // 
            labelPersonName.AutoSize = true;
            labelPersonName.Font = new Font("Arial Narrow", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point);
            labelPersonName.ForeColor = Color.DarkGreen;
            labelPersonName.Location = new Point(26, 52);
            labelPersonName.Name = "labelPersonName";
            labelPersonName.Size = new Size(164, 26);
            labelPersonName.TabIndex = 12;
            labelPersonName.Text = "Ім'я особистість:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(126, 5);
            label1.Name = "label1";
            label1.Size = new Size(869, 26);
            label1.TabIndex = 11;
            label1.Text = "Вивести всі держави, які брали участь у події з участю певної історичної особистості з ім’ям X ";
            // 
            // Request20
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 539);
            Controls.Add(textBoxPersonMiddleName);
            Controls.Add(textBoxPersonSurname);
            Controls.Add(labelPersonMiddleName);
            Controls.Add(labelPersonSurname);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBoxPersonName);
            Controls.Add(labelPersonName);
            Controls.Add(label1);
            Name = "Request20";
            Text = "Request20";
            FormClosing += Request20_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPersonMiddleName;
        private TextBox textBoxPersonSurname;
        private Label labelPersonMiddleName;
        private Label labelPersonSurname;
        private DataGridView dataGridView1;
        private Button button1;
        private TextBox textBoxPersonName;
        private Label labelPersonName;
        private Label label1;
    }
}