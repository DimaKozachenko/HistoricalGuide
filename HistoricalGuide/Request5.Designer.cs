namespace HistoricalGuide
{
    partial class Request5
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
            labelGovermentForm = new Label();
            label2 = new Label();
            buttonSearchDateEvent = new Button();
            dataGridView1 = new DataGridView();
            textBoxDateOne = new TextBox();
            textBoxDatTwo = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(178, 9);
            label1.Name = "label1";
            label1.Size = new Size(464, 26);
            label1.TabIndex = 6;
            label1.Text = "Список подій, які сталися між датою X та датою Y.";
            // 
            // labelGovermentForm
            // 
            labelGovermentForm.AutoSize = true;
            labelGovermentForm.Font = new Font("Arial Narrow", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point);
            labelGovermentForm.ForeColor = Color.DarkGreen;
            labelGovermentForm.Location = new Point(33, 52);
            labelGovermentForm.Name = "labelGovermentForm";
            labelGovermentForm.Size = new Size(139, 26);
            labelGovermentForm.TabIndex = 7;
            labelGovermentForm.Text = "Перша дата Х:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(33, 91);
            label2.Name = "label2";
            label2.Size = new Size(132, 26);
            label2.TabIndex = 8;
            label2.Text = "Друга дата Y:";
            // 
            // buttonSearchDateEvent
            // 
            buttonSearchDateEvent.Font = new Font("Arial Narrow", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSearchDateEvent.ForeColor = Color.DarkGreen;
            buttonSearchDateEvent.Location = new Point(33, 173);
            buttonSearchDateEvent.Name = "buttonSearchDateEvent";
            buttonSearchDateEvent.Size = new Size(90, 48);
            buttonSearchDateEvent.TabIndex = 10;
            buttonSearchDateEvent.Text = "Знайти";
            buttonSearchDateEvent.UseVisualStyleBackColor = true;
            buttonSearchDateEvent.Click += buttonSearchDateEvent_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 227);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 49;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(823, 287);
            dataGridView1.TabIndex = 12;
            // 
            // textBoxDateOne
            // 
            textBoxDateOne.Location = new Point(178, 52);
            textBoxDateOne.Name = "textBoxDateOne";
            textBoxDateOne.Size = new Size(213, 26);
            textBoxDateOne.TabIndex = 13;
            // 
            // textBoxDatTwo
            // 
            textBoxDatTwo.Location = new Point(178, 91);
            textBoxDatTwo.Name = "textBoxDatTwo";
            textBoxDatTwo.Size = new Size(213, 26);
            textBoxDatTwo.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(33, 129);
            label3.Name = "label3";
            label3.Size = new Size(220, 26);
            label3.TabIndex = 15;
            label3.Text = "Приклад введеня дати:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(259, 129);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(132, 26);
            textBox1.TabIndex = 16;
            textBox1.Text = "1914-01-01";
            // 
            // Request5
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 526);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(textBoxDatTwo);
            Controls.Add(textBoxDateOne);
            Controls.Add(dataGridView1);
            Controls.Add(buttonSearchDateEvent);
            Controls.Add(label2);
            Controls.Add(labelGovermentForm);
            Controls.Add(label1);
            Name = "Request5";
            Text = "Request5";
            FormClosing += Request5_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelGovermentForm;
        private Label label2;
        private Button buttonSearchDateEvent;
        private DataGridView dataGridView1;
        private TextBox textBoxDateOne;
        private TextBox textBoxDatTwo;
        private Label label3;
        private TextBox textBox1;
    }
}