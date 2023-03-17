namespace WorkRecordSystem
{
    partial class FormLogin
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
            label2 = new Label();
            label3 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(41, 21);
            label1.Name = "label1";
            label1.Size = new Size(313, 45);
            label1.TabIndex = 0;
            label1.Text = "WorkRecordSystem";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 81);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 1;
            label2.Text = "Uživatelské jméno";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 110);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 2;
            label3.Text = "Heslo";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(120, 78);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(216, 23);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(120, 107);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(216, 23);
            txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Location = new Point(231, 147);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(105, 23);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Přihlásit se";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            btnLogin.KeyDown += btnLogin_KeyDown;
            // 
            // btnCancel
            // 
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Location = new Point(120, 147);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(105, 23);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Zrušit";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 200);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormLogin";
            Text = "FormLogin";
            KeyDown += FormLogin_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnCancel;
    }
}