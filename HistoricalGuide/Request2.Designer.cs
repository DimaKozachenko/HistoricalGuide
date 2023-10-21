namespace HistoricalGuide
{
    partial class Request2
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
            labelCountryName = new Label();
            textBoxCountryName = new TextBox();
            dataGridView1 = new DataGridView();
            buttonSearchCountry = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(35, 9);
            label1.Name = "label1";
            label1.Size = new Size(860, 26);
            label1.TabIndex = 3;
            label1.Text = "Список періодів з назвою, формою правління та політичним режимом для заданої держави X ";
            // 
            // labelCountryName
            // 
            labelCountryName.AutoSize = true;
            labelCountryName.Font = new Font("Arial Narrow", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point);
            labelCountryName.ForeColor = Color.DarkGreen;
            labelCountryName.Location = new Point(35, 65);
            labelCountryName.Name = "labelCountryName";
            labelCountryName.Size = new Size(155, 26);
            labelCountryName.TabIndex = 4;
            labelCountryName.Text = "Назва Держави:";
            // 
            // textBoxCountryName
            // 
            textBoxCountryName.Location = new Point(196, 65);
            textBoxCountryName.Name = "textBoxCountryName";
            textBoxCountryName.Size = new Size(213, 26);
            textBoxCountryName.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 162);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 49;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(905, 370);
            dataGridView1.TabIndex = 6;
            // 
            // buttonSearchCountry
            // 
            buttonSearchCountry.Font = new Font("Arial Narrow", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSearchCountry.ForeColor = Color.DarkGreen;
            buttonSearchCountry.Location = new Point(35, 108);
            buttonSearchCountry.Name = "buttonSearchCountry";
            buttonSearchCountry.Size = new Size(90, 48);
            buttonSearchCountry.TabIndex = 7;
            buttonSearchCountry.Text = "Знайти";
            buttonSearchCountry.UseVisualStyleBackColor = true;
            buttonSearchCountry.Click += buttonSearchCountry_Click;
            // 
            // Request2
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 544);
            Controls.Add(buttonSearchCountry);
            Controls.Add(dataGridView1);
            Controls.Add(textBoxCountryName);
            Controls.Add(labelCountryName);
            Controls.Add(label1);
            Name = "Request2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Request2";
            FormClosing += Request2_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelCountryName;
        private TextBox textBoxCountryName;
        private DataGridView dataGridView1;
        private Button buttonSearchCountry;
    }
}