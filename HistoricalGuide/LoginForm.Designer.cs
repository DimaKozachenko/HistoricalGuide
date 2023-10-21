namespace HistoricalGuide
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonlogin = new Button();
            label1 = new Label();
            label2 = new Label();
            loginFild = new TextBox();
            passwordFild = new TextBox();
            SuspendLayout();
            // 
            // buttonlogin
            // 
            buttonlogin.Font = new Font("Arial Narrow", 16.2782612F, FontStyle.Bold, GraphicsUnit.Point);
            buttonlogin.ForeColor = Color.DarkGreen;
            buttonlogin.Location = new Point(249, 60);
            buttonlogin.Name = "buttonlogin";
            buttonlogin.Size = new Size(116, 91);
            buttonlogin.TabIndex = 0;
            buttonlogin.Text = "Увійти";
            buttonlogin.UseVisualStyleBackColor = true;
            buttonlogin.Click += buttonlogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 16.2782612F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(23, 23);
            label1.Name = "label1";
            label1.Size = new Size(70, 31);
            label1.TabIndex = 1;
            label1.Text = "Логін";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 16.2782612F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(22, 91);
            label2.Name = "label2";
            label2.Size = new Size(94, 31);
            label2.TabIndex = 2;
            label2.Text = "Пароль";
            // 
            // loginFild
            // 
            loginFild.Location = new Point(22, 52);
            loginFild.Name = "loginFild";
            loginFild.Size = new Size(120, 26);
            loginFild.TabIndex = 3;
            // 
            // passwordFild
            // 
            passwordFild.Location = new Point(23, 125);
            passwordFild.Name = "passwordFild";
            passwordFild.Size = new Size(120, 26);
            passwordFild.TabIndex = 4;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 182);
            Controls.Add(passwordFild);
            Controls.Add(loginFild);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonlogin);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonlogin;
        private Label label1;
        private Label label2;
        private TextBox loginFild;
        private TextBox passwordFild;
    }
}