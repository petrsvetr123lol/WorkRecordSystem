namespace WorkRecordSystem.Forms
{
    partial class EditUserForm
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
            label4 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            label3 = new Label();
            txtPassword = new TextBox();
            txtName = new TextBox();
            comboRole = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(64, 19);
            label4.Name = "label4";
            label4.Size = new Size(207, 32);
            label4.TabIndex = 17;
            label4.Text = "Editace uživatelů";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(64, 201);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(108, 23);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Zrušit";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(178, 201);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(108, 23);
            btnSave.TabIndex = 15;
            btnSave.Text = "Uložit";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 153);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 14;
            label3.Text = "Role";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(64, 113);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(222, 23);
            txtPassword.TabIndex = 13;
            // 
            // txtName
            // 
            txtName.Location = new Point(64, 80);
            txtName.Name = "txtName";
            txtName.Size = new Size(222, 23);
            txtName.TabIndex = 12;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // comboRole
            // 
            comboRole.FormattingEnabled = true;
            comboRole.Items.AddRange(new object[] { "Admin", "Uživatel" });
            comboRole.Location = new Point(64, 150);
            comboRole.Name = "comboRole";
            comboRole.Size = new Size(222, 23);
            comboRole.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 121);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 10;
            label2.Text = "Heslo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 88);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 9;
            label1.Text = "Jméno";
            // 
            // EditUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 249);
            Controls.Add(label4);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(txtName);
            Controls.Add(comboRole);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditUserForm";
            Text = "EditUserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button btnCancel;
        private Button btnSave;
        private Label label3;
        private TextBox txtPassword;
        private TextBox txtName;
        private ComboBox comboRole;
        private Label label2;
        private Label label1;
    }
}