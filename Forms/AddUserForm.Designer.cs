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
            panel1 = new Panel();
            txtPasswordAgain = new TextBox();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 79);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Jméno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 113);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 1;
            label2.Text = "Heslo";
            // 
            // comboRole
            // 
            comboRole.FormattingEnabled = true;
            comboRole.Items.AddRange(new object[] { "Admin", "Uživatel" });
            comboRole.Location = new Point(100, 179);
            comboRole.Name = "comboRole";
            comboRole.Size = new Size(200, 23);
            comboRole.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(100, 76);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 23);
            txtName.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(100, 110);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 23);
            txtPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 187);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 5;
            label3.Text = "Role";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(154, 224);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(146, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Uložit";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(11, 224);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(137, 23);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Zrušit";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 11);
            label4.Name = "label4";
            label4.Size = new Size(297, 32);
            label4.TabIndex = 8;
            label4.Text = "Přidání nového uživatele";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(txtPasswordAgain);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboRole);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(313, 260);
            panel1.TabIndex = 9;
            // 
            // txtPasswordAgain
            // 
            txtPasswordAgain.Location = new Point(100, 143);
            txtPasswordAgain.Name = "txtPasswordAgain";
            txtPasswordAgain.Size = new Size(200, 23);
            txtPasswordAgain.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 151);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 9;
            label5.Text = "Heslo znovu";
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(334, 284);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "AddUserForm";
            Text = "UserDialog";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
        private Panel panel1;
        private TextBox txtPasswordAgain;
        private Label label5;
    }
}