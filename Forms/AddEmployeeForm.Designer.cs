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
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(16, 15);
            label1.Name = "label1";
            label1.Size = new Size(295, 30);
            label1.TabIndex = 0;
            label1.Text = "Přidání nového zaměstnance";
            // 
            // txtName
            // 
            txtName.Location = new Point(127, 132);
            txtName.Name = "txtName";
            txtName.Size = new Size(183, 23);
            txtName.TabIndex = 1;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(127, 161);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(183, 23);
            txtSurname.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(127, 190);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(183, 23);
            txtEmail.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 140);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 5;
            label2.Text = "Jméno";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 169);
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
            label5.Location = new Point(65, 198);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 8;
            label5.Text = "E-mail";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(61, 227);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 9;
            label6.Text = "Telefon";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(127, 219);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(183, 23);
            txtPhone.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 264);
            label7.Name = "label7";
            label7.Size = new Size(91, 15);
            label7.TabIndex = 11;
            label7.Text = "Datum narození";
            // 
            // bdayPicker
            // 
            bdayPicker.Format = DateTimePickerFormat.Short;
            bdayPicker.Location = new Point(127, 256);
            bdayPicker.Name = "bdayPicker";
            bdayPicker.Size = new Size(183, 23);
            bdayPicker.TabIndex = 12;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(168, 299);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(146, 23);
            btnSave.TabIndex = 13;
            btnSave.Text = "Uložit";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(16, 299);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(146, 23);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Zrušit";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtPersonalNumber
            // 
            txtPersonalNumber.Location = new Point(127, 74);
            txtPersonalNumber.Name = "txtPersonalNumber";
            txtPersonalNumber.Size = new Size(183, 23);
            txtPersonalNumber.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(34, 82);
            label8.Name = "label8";
            label8.Size = new Size(72, 15);
            label8.TabIndex = 16;
            label8.Text = "Osobní číslo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 111);
            label9.Name = "label9";
            label9.Size = new Size(90, 15);
            label9.TabIndex = 18;
            label9.Text = "Pracovní pozice";
            // 
            // txtRole
            // 
            txtRole.Location = new Point(127, 103);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(183, 23);
            txtRole.TabIndex = 17;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtPersonalNumber);
            panel1.Controls.Add(txtRole);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtSurname);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(bdayPicker);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtPhone);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(339, 336);
            panel1.TabIndex = 19;
            // 
            // AddEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(361, 359);
            Controls.Add(label4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddEmployeeForm";
            Text = "AddEmployeeForm";
            Load += AddEmployeeForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
    }
}