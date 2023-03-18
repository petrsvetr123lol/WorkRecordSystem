namespace WorkRecordSystem.Forms
{
    partial class EmployeeForm
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
            popis = new Label();
            btnLogout = new Button();
            label3 = new Label();
            lblUser = new Label();
            SuspendLayout();
            // 
            // popis
            // 
            popis.AutoSize = true;
            popis.Location = new Point(583, 20);
            popis.Name = "popis";
            popis.Size = new Size(104, 15);
            popis.TabIndex = 0;
            popis.Text = "Přihlášený uživatel";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(777, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Odhlásit se";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 12);
            label3.Name = "label3";
            label3.Size = new Size(211, 32);
            label3.TabIndex = 5;
            label3.Text = "Uživatelská sekce";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = SystemColors.Control;
            lblUser.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser.Location = new Point(693, 15);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(51, 20);
            lblUser.TabIndex = 6;
            lblUser.Text = "label1";
            lblUser.Click += label1_Click;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 521);
            Controls.Add(lblUser);
            Controls.Add(label3);
            Controls.Add(btnLogout);
            Controls.Add(popis);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "EmployeeForm";
            Text = "EmployeeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label popis;
        private Button btnLogout;
        private Label label3;
        private Label lblUser;
    }
}