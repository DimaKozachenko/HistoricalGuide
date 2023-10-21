namespace HistoricalGuide
{
    partial class Request3
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
            label1 = new Label();
            labelEmployeeSurname = new Label();
            textBoxEmployeeSurname = new TextBox();
            dataGridView1 = new DataGridView();
            buttonSearchEmployee = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(30, 26);
            label1.Name = "label1";
            label1.Size = new Size(686, 26);
            label1.TabIndex = 4;
            label1.Text = "Знайти всіх співробітників, чиє прізвище починається на задану букву «Y»";
            // 
            // labelEmployeeSurname
            // 
            labelEmployeeSurname.AutoSize = true;
            labelEmployeeSurname.Font = new Font("Arial Narrow", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmployeeSurname.ForeColor = Color.DarkGreen;
            labelEmployeeSurname.Location = new Point(30, 79);
            labelEmployeeSurname.Name = "labelEmployeeSurname";
            labelEmployeeSurname.Size = new Size(236, 26);
            labelEmployeeSurname.TabIndex = 5;
            labelEmployeeSurname.Text = "Призвіще Співробітника:";
            // 
            // textBoxEmployeeSurname
            // 
            textBoxEmployeeSurname.Location = new Point(272, 82);
            textBoxEmployeeSurname.Name = "textBoxEmployeeSurname";
            textBoxEmployeeSurname.Size = new Size(213, 26);
            textBoxEmployeeSurname.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 179);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 49;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(800, 316);
            dataGridView1.TabIndex = 7;
            // 
            // buttonSearchEmployee
            // 
            buttonSearchEmployee.Font = new Font("Arial Narrow", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSearchEmployee.ForeColor = Color.DarkGreen;
            buttonSearchEmployee.Location = new Point(30, 125);
            buttonSearchEmployee.Name = "buttonSearchEmployee";
            buttonSearchEmployee.Size = new Size(90, 48);
            buttonSearchEmployee.TabIndex = 8;
            buttonSearchEmployee.Text = "Знайти";
            buttonSearchEmployee.UseVisualStyleBackColor = true;
            buttonSearchEmployee.Click += buttonSearchEmployee_Click;
            // 
            // Request3
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 507);
            Controls.Add(buttonSearchEmployee);
            Controls.Add(dataGridView1);
            Controls.Add(textBoxEmployeeSurname);
            Controls.Add(labelEmployeeSurname);
            Controls.Add(label1);
            Name = "Request3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Request3";
            FormClosing += Request3_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelEmployeeSurname;
        private TextBox textBoxEmployeeSurname;
        private DataGridView dataGridView1;
        private Button buttonSearchEmployee;
    }
}