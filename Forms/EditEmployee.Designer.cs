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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(9, 113);
            label9.Name = "label9";
            label9.Size = new Size(90, 15);
            label9.TabIndex = 36;
            label9.Text = "Pracovní pozice";
            // 
            // txtRole
            // 
            txtRole.Location = new Point(120, 105);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(183, 23);
            txtRole.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 84);
            label8.Name = "label8";
            label8.Size = new Size(72, 15);
            label8.TabIndex = 34;
            label8.Text = "Osobní číslo";
            // 
            // txtPersonalNumber
            // 
            txtPersonalNumber.Location = new Point(120, 76);
            txtPersonalNumber.Name = "txtPersonalNumber";
            txtPersonalNumber.Size = new Size(183, 23);
            txtPersonalNumber.TabIndex = 33;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(11, 304);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(143, 23);
            btnCancel.TabIndex = 32;
            btnCancel.Text = "Zrušit";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(160, 304);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(143, 23);
            btnSave.TabIndex = 31;
            btnSave.Text = "Uložit";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // bdayPicker
            // 
            bdayPicker.Format = DateTimePickerFormat.Short;
            bdayPicker.Location = new Point(120, 221);
            bdayPicker.Name = "bdayPicker";
            bdayPicker.Size = new Size(183, 23);
            bdayPicker.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 229);
            label7.Name = "label7";
            label7.Size = new Size(91, 15);
            label7.TabIndex = 29;
            label7.Text = "Datum narození";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(120, 250);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(183, 23);
            txtPhone.TabIndex = 28;
            txtPhone.KeyDown += txtPhone_KeyDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(54, 258);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 27;
            label6.Text = "Telefon";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 200);
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
            label3.Location = new Point(48, 171);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 24;
            label3.Text = "Přijmení";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 142);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 23;
            label2.Text = "Jméno";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(120, 192);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(183, 23);
            txtEmail.TabIndex = 22;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(120, 163);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(183, 23);
            txtSurname.TabIndex = 21;
            // 
            // txtName
            // 
            txtName.Location = new Point(120, 134);
            txtName.Name = "txtName";
            txtName.Size = new Size(183, 23);
            txtName.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(66, 11);
            label1.Name = "label1";
            label1.Size = new Size(251, 32);
            label1.TabIndex = 19;
            label1.Text = "Editace zaměstnance";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtRole);
            panel1.Controls.Add(txtPersonalNumber);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(txtSurname);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(bdayPicker);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(318, 345);
            panel1.TabIndex = 37;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // EditEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(339, 374);
            Controls.Add(label4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "EditEmployee";
            Text = "EditEmployee";
            Load += EditEmployee_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}