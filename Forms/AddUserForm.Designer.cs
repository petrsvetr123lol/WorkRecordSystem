namespace WorkRecordSystem.Forms
{
    partial class AddUserForm
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
            comboRole = new ComboBox();
            txtName = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 83);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Jméno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 116);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 1;
            label2.Text = "Heslo";
            // 
            // comboRole
            // 
            comboRole.FormattingEnabled = true;
            comboRole.Items.AddRange(new object[] { "Admin", "Uživatel" });
            comboRole.Location = new Point(68, 145);
            comboRole.Name = "comboRole";
            comboRole.Size = new Size(140, 23);
            comboRole.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(68, 75);
            txtName.Name = "txtName";
            txtName.Size = new Size(140, 23);
            txtName.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(68, 108);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(140, 23);
            txtPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 148);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 5;
            label3.Text = "Role";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(133, 196);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Uložit";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(52, 196);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Zrušit";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(52, 18);
            label4.Name = "label4";
            label4.Size = new Size(144, 32);
            label4.TabIndex = 8;
            label4.Text = "User dialog";
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(236, 242);
            Controls.Add(label4);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(txtName);
            Controls.Add(comboRole);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "AddUserForm";
            Text = "UserDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboRole;
        private TextBox txtName;
        private TextBox txtPassword;
        private Label label3;
        private Button btnSave;
        private Button btnCancel;
        private Label label4;
    }
}