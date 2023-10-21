namespace HistoricalGuide
{
    partial class Request6
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
            textBox1 = new TextBox();
            label3 = new Label();
            textBoxDatTwo = new TextBox();
            textBoxDateOne = new TextBox();
            dataGridView1 = new DataGridView();
            buttonSearchDateCountry = new Button();
            label2 = new Label();
            labelGovermentForm = new Label();
            label1 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(238, 122);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(132, 26);
            textBox1.TabIndex = 25;
            textBox1.Text = "1914-01-01";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(12, 122);
            label3.Name = "label3";
            label3.Size = new Size(220, 26);
            label3.TabIndex = 24;
            label3.Text = "Приклад введеня дати:";
            // 
            // textBoxDatTwo
            // 
            textBoxDatTwo.Location = new Point(157, 84);
            textBoxDatTwo.Name = "textBoxDatTwo";
            textBoxDatTwo.Size = new Size(213, 26);
            textBoxDatTwo.TabIndex = 23;
            // 
            // textBoxDateOne
            // 
            textBoxDateOne.Location = new Point(157, 45);
            textBoxDateOne.Name = "textBoxDateOne";
            textBoxDateOne.Size = new Size(213, 26);
            textBoxDateOne.TabIndex = 22;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 220);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 49;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(977, 287);
            dataGridView1.TabIndex = 21;
            // 
            // buttonSearchDateCountry
            // 
            buttonSearchDateCountry.Font = new Font("Arial Narrow", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSearchDateCountry.ForeColor = Color.DarkGreen;
            buttonSearchDateCountry.Location = new Point(12, 166);
            buttonSearchDateCountry.Name = "buttonSearchDateCountry";
            buttonSearchDateCountry.Size = new Size(90, 48);
            buttonSearchDateCountry.TabIndex = 20;
            buttonSearchDateCountry.Text = "Знайти";
            buttonSearchDateCountry.UseVisualStyleBackColor = true;
            buttonSearchDateCountry.Click += buttonSearchDateCountry_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(12, 84);
            label2.Name = "label2";
            label2.Size = new Size(132, 26);
            label2.TabIndex = 19;
            label2.Text = "Друга дата Y:";
            // 
            // labelGovermentForm
            // 
            labelGovermentForm.AutoSize = true;
            labelGovermentForm.Font = new Font("Arial Narrow", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point);
            labelGovermentForm.ForeColor = Color.DarkGreen;
            labelGovermentForm.Location = new Point(12, 45);
            labelGovermentForm.Name = "labelGovermentForm";
            labelGovermentForm.Size = new Size(139, 26);
            labelGovermentForm.TabIndex = 18;
            labelGovermentForm.Text = "Перша дата Х:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(157, -34);
            label1.Name = "label1";
            label1.Size = new Size(464, 26);
            label1.TabIndex = 17;
            label1.Text = "Список подій, які сталися між датою X та датою Y.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(157, 9);
            label4.Name = "label4";
            label4.Size = new Size(643, 26);
            label4.TabIndex = 26;
            label4.Text = "Вибірка всіх держав, які існували між двома вказаними датами: X та Y";
            // 
            // Request6
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 508);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(textBoxDatTwo);
            Controls.Add(textBoxDateOne);
            Controls.Add(dataGridView1);
            Controls.Add(buttonSearchDateCountry);
            Controls.Add(label2);
            Controls.Add(labelGovermentForm);
            Controls.Add(label1);
            Name = "Request6";
            Text = "Request6";
            FormClosing += Request6_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label3;
        private TextBox textBoxDatTwo;
        private TextBox textBoxDateOne;
        private DataGridView dataGridView1;
        private Button buttonSearchDateCountry;
        private Label label2;
        private Label labelGovermentForm;
        private Label label1;
        private Label label4;
    }
}