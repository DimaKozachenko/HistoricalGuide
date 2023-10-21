using System.Text;

namespace HistoricalGuide
{
    partial class Request1
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
            label1 = new Label();
            labelPersonName = new Label();
            textBoxPersonName = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            labelPersonSurname = new Label();
            labelPersonMiddleName = new Label();
            textBoxPersonSurname = new TextBox();
            textBoxPersonMiddleName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(112, 9);
            label1.Name = "label1";
            label1.Size = new Size(874, 26);
            label1.TabIndex = 2;
            label1.Text = "Список подій з їх назвами, початком та кінцем, які відбувались за участю заданої особистості X";
            // 
            // labelPersonName
            // 
            labelPersonName.AutoSize = true;
            labelPersonName.Font = new Font("Arial Narrow", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point);
            labelPersonName.ForeColor = Color.DarkGreen;
            labelPersonName.Location = new Point(12, 77);
            labelPersonName.Name = "labelPersonName";
            labelPersonName.Size = new Size(164, 26);
            labelPersonName.TabIndex = 3;
            labelPersonName.Text = "Ім'я особистість:";
            // 
            // textBoxPersonName
            // 
            textBoxPersonName.Location = new Point(182, 77);
            textBoxPersonName.Name = "textBoxPersonName";
            textBoxPersonName.Size = new Size(213, 26);
            textBoxPersonName.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Narrow", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkGreen;
            button1.Location = new Point(12, 204);
            button1.Name = "button1";
            button1.Size = new Size(90, 48);
            button1.TabIndex = 5;
            button1.Text = "Знайти";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 267);
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
            dataGridView1.Size = new Size(1041, 270);
            dataGridView1.TabIndex = 6;
            // 
            // labelPersonSurname
            // 
            labelPersonSurname.AutoSize = true;
            labelPersonSurname.Font = new Font("Arial Narrow", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point);
            labelPersonSurname.ForeColor = Color.DarkGreen;
            labelPersonSurname.Location = new Point(12, 160);
            labelPersonSurname.Name = "labelPersonSurname";
            labelPersonSurname.Size = new Size(216, 26);
            labelPersonSurname.TabIndex = 7;
            labelPersonSurname.Text = "Призвіще особистість:";
            // 
            // labelPersonMiddleName
            // 
            labelPersonMiddleName.AutoSize = true;
            labelPersonMiddleName.Font = new Font("Arial Narrow", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point);
            labelPersonMiddleName.ForeColor = Color.DarkGreen;
            labelPersonMiddleName.Location = new Point(12, 121);
            labelPersonMiddleName.Name = "labelPersonMiddleName";
            labelPersonMiddleName.Size = new Size(238, 26);
            labelPersonMiddleName.TabIndex = 8;
            labelPersonMiddleName.Text = "По-батькові особистість:";
            // 
            // textBoxPersonSurname
            // 
            textBoxPersonSurname.Location = new Point(234, 160);
            textBoxPersonSurname.Name = "textBoxPersonSurname";
            textBoxPersonSurname.Size = new Size(213, 26);
            textBoxPersonSurname.TabIndex = 9;
            // 
            // textBoxPersonMiddleName
            // 
            textBoxPersonMiddleName.Location = new Point(256, 121);
            textBoxPersonMiddleName.Name = "textBoxPersonMiddleName";
            textBoxPersonMiddleName.Size = new Size(213, 26);
            textBoxPersonMiddleName.TabIndex = 10;
            // 
            // Request1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 541);
            Controls.Add(textBoxPersonMiddleName);
            Controls.Add(textBoxPersonSurname);
            Controls.Add(labelPersonMiddleName);
            Controls.Add(labelPersonSurname);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBoxPersonName);
            Controls.Add(labelPersonName);
            Controls.Add(label1);
            Name = "Request1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Request1";
            FormClosing += Request1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelPersonName;
        private TextBox textBoxPersonName;
        private Button button1;
        private DataGridView dataGridView1;

        private Label labelPersonSurname;
        private Label labelPersonMiddleName;
        private TextBox textBoxPersonSurname;
        private TextBox textBoxPersonMiddleName;
    }
}