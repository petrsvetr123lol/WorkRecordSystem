namespace WorkRecordSystem.Forms
{
    partial class AddEmployeeForm
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
            txtName = new TextBox();
            txtSurname = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtPhone = new TextBox();
            label7 = new Label();
            bdayPicker = new DateTimePicker();
            btnSave = new Button();
            btnCancel = new Button();
            txtPersonalNumber = new TextBox();
            label8 = new Label();
            label9 = new Label();
            txtRole = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(20, 47);
            label1.Name = "label1";
            label1.Size = new Size(343, 32);
            label1.TabIndex = 0;
            label1.Text = "Přidání nového zaměstnance";
            // 
            // txtName
            // 
            txtName.Location = new Point(131, 178);
            txtName.Name = "txtName";
            txtName.Size = new Size(183, 23);
            txtName.TabIndex = 1;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(131, 207);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(183, 23);
            txtSurname.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(131, 236);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(183, 23);
            txtEmail.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 186);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 5;
            label2.Text = "Jméno";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 215);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 6;
            label3.Text = "Přijmení";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 215);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(69, 244);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 8;
            label5.Text = "E-mail";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(65, 273);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 9;
            label6.Text = "Telefon";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(131, 265);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(183, 23);
            txtPhone.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 310);
            label7.Name = "label7";
            label7.Size = new Size(91, 15);
            label7.TabIndex = 11;
            label7.Text = "Datum narození";
            // 
            // bdayPicker
            // 
            bdayPicker.Format = DateTimePickerFormat.Short;
            bdayPicker.Location = new Point(131, 302);
            bdayPicker.Name = "bdayPicker";
            bdayPicker.Size = new Size(183, 23);
            bdayPicker.TabIndex = 12;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(228, 356);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 23);
            btnSave.TabIndex = 13;
            btnSave.Text = "Uložit";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(131, 356);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 23);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Zrušit";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtPersonalNumber
            // 
            txtPersonalNumber.Location = new Point(131, 120);
            txtPersonalNumber.Name = "txtPersonalNumber";
            txtPersonalNumber.Size = new Size(183, 23);
            txtPersonalNumber.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(38, 128);
            label8.Name = "label8";
            label8.Size = new Size(72, 15);
            label8.TabIndex = 16;
            label8.Text = "Osobní číslo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(20, 157);
            label9.Name = "label9";
            label9.Size = new Size(90, 15);
            label9.TabIndex = 18;
            label9.Text = "Pracovní pozice";
            // 
            // txtRole
            // 
            txtRole.Location = new Point(131, 149);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(183, 23);
            txtRole.TabIndex = 17;
            // 
            // AddEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 407);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddEmployeeForm";
            Text = "AddEmployeeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtEmail;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtPhone;
        private Label label7;
        private DateTimePicker bdayPicker;
        private Button btnSave;
        private Button btnCancel;
        private TextBox txtPersonalNumber;
        private Label label8;
        private Label label9;
        private TextBox txtRole;
    }
}