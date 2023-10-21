namespace HistoricalGuide
{
    partial class Request15
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
            dataGridView1 = new DataGridView();
            buttonSearchDateCountry = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 132);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 49;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(872, 399);
            dataGridView1.TabIndex = 42;
            // 
            // buttonSearchDateCountry
            // 
            buttonSearchDateCountry.Font = new Font("Arial Narrow", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSearchDateCountry.ForeColor = Color.DarkGreen;
            buttonSearchDateCountry.Location = new Point(6, 68);
            buttonSearchDateCountry.Name = "buttonSearchDateCountry";
            buttonSearchDateCountry.Size = new Size(90, 48);
            buttonSearchDateCountry.TabIndex = 41;
            buttonSearchDateCountry.Text = "Знайти";
            buttonSearchDateCountry.UseVisualStyleBackColor = true;
            buttonSearchDateCountry.Click += buttonSearchDateCountry_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(6, 19);
            label4.Name = "label4";
            label4.Size = new Size(645, 26);
            label4.TabIndex = 40;
            label4.Text = "Покажіть всі історичні особистості, які не взяли участь в жодній події.";
            // 
            // Request15
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 551);
            Controls.Add(dataGridView1);
            Controls.Add(buttonSearchDateCountry);
            Controls.Add(label4);
            Name = "Request15";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Request15";
            FormClosing += Request15_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonSearchDateCountry;
        private Label label4;
    }
}