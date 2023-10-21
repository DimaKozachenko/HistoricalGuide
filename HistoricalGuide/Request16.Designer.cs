namespace HistoricalGuide
{
    partial class Request16
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
            buttonSearchCountry = new Button();
            dataGridView1 = new DataGridView();
            textBoxCountryName = new TextBox();
            labelCountryName = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonSearchCountry
            // 
            buttonSearchCountry.Font = new Font("Arial Narrow", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSearchCountry.ForeColor = Color.DarkGreen;
            buttonSearchCountry.Location = new Point(2, 93);
            buttonSearchCountry.Name = "buttonSearchCountry";
            buttonSearchCountry.Size = new Size(90, 48);
            buttonSearchCountry.TabIndex = 12;
            buttonSearchCountry.Text = "Знайти";
            buttonSearchCountry.UseVisualStyleBackColor = true;
            buttonSearchCountry.Click += buttonSearchCountry_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 147);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 49;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(885, 370);
            dataGridView1.TabIndex = 11;
            // 
            // textBoxCountryName
            // 
            textBoxCountryName.Location = new Point(77, 53);
            textBoxCountryName.Name = "textBoxCountryName";
            textBoxCountryName.Size = new Size(213, 26);
            textBoxCountryName.TabIndex = 10;
            // 
            // labelCountryName
            // 
            labelCountryName.AutoSize = true;
            labelCountryName.Font = new Font("Arial Narrow", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point);
            labelCountryName.ForeColor = Color.DarkGreen;
            labelCountryName.Location = new Point(2, 50);
            labelCountryName.Name = "labelCountryName";
            labelCountryName.Size = new Size(69, 26);
            labelCountryName.TabIndex = 9;
            labelCountryName.Text = "Подія:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(2, 9);
            label1.Name = "label1";
            label1.Size = new Size(540, 26);
            label1.TabIndex = 8;
            label1.Text = "Покажіть всі держави, які не брали участь у певній події Х.";
            // 
            // Request16
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 521);
            Controls.Add(buttonSearchCountry);
            Controls.Add(dataGridView1);
            Controls.Add(textBoxCountryName);
            Controls.Add(labelCountryName);
            Controls.Add(label1);
            Name = "Request16";
            Text = "Request16";
            FormClosing += Request16_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSearchCountry;
        private DataGridView dataGridView1;
        private TextBox textBoxCountryName;
        private Label labelCountryName;
        private Label label1;
    }
}