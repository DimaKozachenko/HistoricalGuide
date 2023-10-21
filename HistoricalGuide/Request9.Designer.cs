namespace HistoricalGuide
{
    partial class Request9
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
            buttonSearchDateCountry = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(843, 26);
            label4.TabIndex = 31;
            label4.Text = "Визначити кількість подій, в яких приймала участь кожна держава, виведіть назву держави.";
            // 
            // buttonSearchDateCountry
            // 
            buttonSearchDateCountry.Font = new Font("Arial Narrow", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSearchDateCountry.ForeColor = Color.DarkGreen;
            buttonSearchDateCountry.Location = new Point(12, 58);
            buttonSearchDateCountry.Name = "buttonSearchDateCountry";
            buttonSearchDateCountry.Size = new Size(90, 48);
            buttonSearchDateCountry.TabIndex = 32;
            buttonSearchDateCountry.Text = "Знайти";
            buttonSearchDateCountry.UseVisualStyleBackColor = true;
            buttonSearchDateCountry.Click += buttonSearchDateCountry_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 122);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 49;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(856, 338);
            dataGridView1.TabIndex = 33;
            // 
            // Request9
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 472);
            Controls.Add(dataGridView1);
            Controls.Add(buttonSearchDateCountry);
            Controls.Add(label4);
            Name = "Request9";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Request9";
            FormClosing += Request9_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button buttonSearchDateCountry;
        private DataGridView dataGridView1;
    }
}