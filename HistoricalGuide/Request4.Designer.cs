namespace HistoricalGuide
{
    partial class Request4
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
            buttonSearchGovermentForm = new Button();
            textBoxGovermentForm = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(32, 19);
            label1.Name = "label1";
            label1.Size = new Size(626, 26);
            label1.TabIndex = 5;
            label1.Text = "Знайти всі періоди, де форма правління містить заданий рядок «X».";
            // 
            // labelGovermentForm
            // 
            labelGovermentForm.AutoSize = true;
            labelGovermentForm.Font = new Font("Arial Narrow", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point);
            labelGovermentForm.ForeColor = Color.DarkGreen;
            labelGovermentForm.Location = new Point(32, 60);
            labelGovermentForm.Name = "labelGovermentForm";
            labelGovermentForm.Size = new Size(175, 26);
            labelGovermentForm.TabIndex = 6;
            labelGovermentForm.Text = "Форма правління:";
            // 
            // buttonSearchGovermentForm
            // 
            buttonSearchGovermentForm.Font = new Font("Arial Narrow", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSearchGovermentForm.ForeColor = Color.DarkGreen;
            buttonSearchGovermentForm.Location = new Point(32, 105);
            buttonSearchGovermentForm.Name = "buttonSearchGovermentForm";
            buttonSearchGovermentForm.Size = new Size(90, 48);
            buttonSearchGovermentForm.TabIndex = 9;
            buttonSearchGovermentForm.Text = "Знайти";
            buttonSearchGovermentForm.UseVisualStyleBackColor = true;
            buttonSearchGovermentForm.Click += buttonSearchGovermentForm_Click;
            // 
            // textBoxGovermentForm
            // 
            textBoxGovermentForm.Location = new Point(213, 60);
            textBoxGovermentForm.Name = "textBoxGovermentForm";
            textBoxGovermentForm.Size = new Size(213, 26);
            textBoxGovermentForm.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 174);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 49;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(804, 344);
            dataGridView1.TabIndex = 11;
            // 
            // Request4
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 530);
            Controls.Add(dataGridView1);
            Controls.Add(textBoxGovermentForm);
            Controls.Add(buttonSearchGovermentForm);
            Controls.Add(labelGovermentForm);
            Controls.Add(label1);
            Name = "Request4";
            Text = "Request4";
            FormClosing += Request4_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelGovermentForm;
        private Button buttonSearchGovermentForm;
        private TextBox textBoxGovermentForm;
        private DataGridView dataGridView1;
    }
}