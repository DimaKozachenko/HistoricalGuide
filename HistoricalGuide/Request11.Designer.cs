namespace HistoricalGuide
{
    partial class Request11
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
            textBoxEventName = new TextBox();
            buttonSearchGovermentForm = new Button();
            labelGovermentForm = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 164);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 49;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(804, 344);
            dataGridView1.TabIndex = 16;
            // 
            // textBoxEventName
            // 
            textBoxEventName.Location = new Point(139, 50);
            textBoxEventName.Name = "textBoxEventName";
            textBoxEventName.Size = new Size(213, 26);
            textBoxEventName.TabIndex = 15;
            // 
            // buttonSearchGovermentForm
            // 
            buttonSearchGovermentForm.Font = new Font("Arial Narrow", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSearchGovermentForm.ForeColor = Color.DarkGreen;
            buttonSearchGovermentForm.Location = new Point(12, 95);
            buttonSearchGovermentForm.Name = "buttonSearchGovermentForm";
            buttonSearchGovermentForm.Size = new Size(90, 48);
            buttonSearchGovermentForm.TabIndex = 14;
            buttonSearchGovermentForm.Text = "Знайти";
            buttonSearchGovermentForm.UseVisualStyleBackColor = true;
            buttonSearchGovermentForm.Click += buttonSearchGovermentForm_Click;
            // 
            // labelGovermentForm
            // 
            labelGovermentForm.AutoSize = true;
            labelGovermentForm.Font = new Font("Arial Narrow", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point);
            labelGovermentForm.ForeColor = Color.DarkGreen;
            labelGovermentForm.Location = new Point(12, 50);
            labelGovermentForm.Name = "labelGovermentForm";
            labelGovermentForm.Size = new Size(121, 26);
            labelGovermentForm.TabIndex = 13;
            labelGovermentForm.Text = "Назва Події:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(525, 26);
            label1.TabIndex = 12;
            label1.Text = "Вивести всі держави які брали участь у події  з назвою X";
            // 
            // Request11
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 517);
            Controls.Add(dataGridView1);
            Controls.Add(textBoxEventName);
            Controls.Add(buttonSearchGovermentForm);
            Controls.Add(labelGovermentForm);
            Controls.Add(label1);
            Name = "Request11";
            Text = "Request11";
            FormClosing += Request11_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBoxEventName;
        private Button buttonSearchGovermentForm;
        private Label labelGovermentForm;
        private Label label1;
    }
}