namespace WorkRecordSystem.Forms
{
    partial class EditEmployee
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
            label9 = new Label();
            txtRole = new TextBox();
            label8 = new Label();
            txtPersonalNumber = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            bdayPicker = new DateTimePicker();
            label7 = new Label();
            txtPhone = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            txtSurname = new TextBox();
            txtName = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(30, 164);
            label9.Name = "label9";
            label9.Size = new Size(90, 15);
            label9.TabIndex = 36;
            label9.Text = "Pracovní pozice";
            // 
            // txtRole
            // 
            txtRole.Location = new Point(141, 156);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(183, 23);
            txtRole.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(48, 135);
            label8.Name = "label8";
            label8.Size = new Size(72, 15);
            label8.TabIndex = 34;
            label8.Text = "Osobní číslo";
            // 
            // txtPersonalNumber
            // 
            txtPersonalNumber.Location = new Point(141, 127);
            txtPersonalNumber.Name = "txtPersonalNumber";
            txtPersonalNumber.Size = new Size(183, 23);
            txtPersonalNumber.TabIndex = 33;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(141, 363);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 23);
            btnCancel.TabIndex = 32;
            btnCancel.Text = "Zrušit";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(238, 363);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 23);
            btnSave.TabIndex = 31;
            btnSave.Text = "Uložit";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // bdayPicker
            // 
            bdayPicker.Format = DateTimePickerFormat.Short;
            bdayPicker.Location = new Point(141, 309);
            bdayPicker.Name = "bdayPicker";
            bdayPicker.Size = new Size(183, 23);
            bdayPicker.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 317);
            label7.Name = "label7";
            label7.Size = new Size(91, 15);
            label7.TabIndex = 29;
            label7.Text = "Datum narození";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(141, 272);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(183, 23);
            txtPhone.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(75, 280);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 27;
            label6.Text = "Telefon";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(79, 251);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 26;
            label5.Text = "E-mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(79, 222);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 222);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 24;
            label3.Text = "Přijmení";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 193);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 23;
            label2.Text = "Jméno";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(141, 243);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(183, 23);
            txtEmail.TabIndex = 22;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(141, 214);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(183, 23);
            txtSurname.TabIndex = 21;
            // 
            // txtName
            // 
            txtName.Location = new Point(141, 185);
            txtName.Name = "txtName";
            txtName.Size = new Size(183, 23);
            txtName.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(79, 55);
            label1.Name = "label1";
            label1.Size = new Size(251, 32);
            label1.TabIndex = 19;
            label1.Text = "Editace zaměstnance";
            // 
            // EditEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 450);
            Controls.Add(label9);
            Controls.Add(txtRole);
            Controls.Add(label8);
            Controls.Add(txtPersonalNumber);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(bdayPicker);
            Controls.Add(label7);
            Controls.Add(txtPhone);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "EditEmployee";
            Text = "EditEmployee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private TextBox txtRole;
        private Label label8;
        private TextBox txtPersonalNumber;
        private Button btnCancel;
        private Button btnSave;
        private DateTimePicker bdayPicker;
        private Label label7;
        private TextBox txtPhone;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtSurname;
        private TextBox txtName;
        private Label label1;
    }
}