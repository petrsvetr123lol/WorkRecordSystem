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
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            txtPasswordAgain = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(83, 14);
            label4.Name = "label4";
            label4.Size = new Size(157, 32);
            label4.TabIndex = 17;
            label4.Text = "Změna hesla";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(14, 190);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(155, 23);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Zrušit";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(175, 190);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(147, 23);
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
            label3.Size = new Size(0, 15);
            label3.TabIndex = 14;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(92, 105);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(222, 23);
            txtPassword.TabIndex = 13;
            // 
            // txtName
            // 
            txtName.Location = new Point(92, 67);
            txtName.Name = "txtName";
            txtName.Size = new Size(222, 23);
            txtName.TabIndex = 12;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 108);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 10;
            label2.Text = "Heslo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 75);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 9;
            label1.Text = "Jméno";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtPasswordAgain);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(7, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(328, 225);
            panel1.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 143);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 18;
            label5.Text = "Heslo znovu";
            // 
            // txtPasswordAgain
            // 
            txtPasswordAgain.Location = new Point(92, 140);
            txtPasswordAgain.Name = "txtPasswordAgain";
            txtPasswordAgain.Size = new Size(222, 23);
            txtPasswordAgain.TabIndex = 17;
            // 
            // EditUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(341, 245);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "EditUserForm";
            Text = "EditUserForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label label5;
        private TextBox txtPasswordAgain;
    }
}