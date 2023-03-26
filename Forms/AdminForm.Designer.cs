namespace WorkRecordSystem
{
    partial class AdminForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUser = new Label();
            label2 = new Label();
            btnLogout = new Button();
            label3 = new Label();
            workPanel = new Panel();
            label8 = new Label();
            label1 = new Label();
            listViewUsers = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            txtSearchUser = new TextBox();
            btnDeleteUser = new Button();
            btnEditUser = new Button();
            btnAddUser = new Button();
            userPanel = new Panel();
            label9 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            textBox2 = new TextBox();
            listViewEmployee = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            panel1 = new Panel();
            label5 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            label7 = new Label();
            panel4 = new Panel();
            label11 = new Label();
            textBox1 = new TextBox();
            label10 = new Label();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            listView1 = new ListView();
            columnHeader10 = new ColumnHeader();
            Description = new ColumnHeader();
            workPanel.SuspendLayout();
            userPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = SystemColors.Control;
            lblUser.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser.Location = new Point(1034, 25);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(58, 20);
            lblUser.TabIndex = 0;
            lblUser.Text = "lblUser";
            lblUser.Click += lblUser_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(921, 29);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 1;
            label2.Text = "Přihlášený uživatel:";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(1114, 22);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Odhlásit se";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(518, 12);
            label3.Name = "label3";
            label3.Size = new Size(165, 32);
            label3.TabIndex = 4;
            label3.Text = "Administrace";
            // 
            // workPanel
            // 
            workPanel.BackColor = Color.White;
            workPanel.Controls.Add(label8);
            workPanel.Controls.Add(label1);
            workPanel.Controls.Add(listViewUsers);
            workPanel.Controls.Add(txtSearchUser);
            workPanel.Controls.Add(btnDeleteUser);
            workPanel.Controls.Add(btnEditUser);
            workPanel.Controls.Add(btnAddUser);
            workPanel.Location = new Point(12, 182);
            workPanel.Name = "workPanel";
            workPanel.Size = new Size(258, 406);
            workPanel.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(14, 13);
            label8.Name = "label8";
            label8.Size = new Size(141, 21);
            label8.TabIndex = 14;
            label8.Text = "Editace uživatelů";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 52);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 12;
            label1.Text = "Vyhledávání uživatele";
            // 
            // listViewUsers
            // 
            listViewUsers.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listViewUsers.FullRowSelect = true;
            listViewUsers.GridLines = true;
            listViewUsers.Location = new Point(14, 81);
            listViewUsers.MultiSelect = false;
            listViewUsers.Name = "listViewUsers";
            listViewUsers.Size = new Size(160, 314);
            listViewUsers.TabIndex = 0;
            listViewUsers.UseCompatibleStateImageBehavior = false;
            listViewUsers.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Role";
            columnHeader2.Width = 80;
            // 
            // txtSearchUser
            // 
            txtSearchUser.Location = new Point(153, 49);
            txtSearchUser.Name = "txtSearchUser";
            txtSearchUser.Size = new Size(94, 23);
            txtSearchUser.TabIndex = 11;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(180, 372);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(67, 23);
            btnDeleteUser.TabIndex = 9;
            btnDeleteUser.Text = "Smazat";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnEditUser
            // 
            btnEditUser.Location = new Point(180, 343);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(67, 23);
            btnEditUser.TabIndex = 8;
            btnEditUser.Text = "Upravit";
            btnEditUser.UseVisualStyleBackColor = true;
            btnEditUser.Click += btnEditUser_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(180, 314);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(67, 23);
            btnAddUser.TabIndex = 7;
            btnAddUser.Text = "Přidat";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // userPanel
            // 
            userPanel.BackColor = Color.White;
            userPanel.Controls.Add(label9);
            userPanel.Controls.Add(button1);
            userPanel.Controls.Add(button2);
            userPanel.Controls.Add(button3);
            userPanel.Controls.Add(label4);
            userPanel.Controls.Add(textBox2);
            userPanel.Controls.Add(listViewEmployee);
            userPanel.Location = new Point(276, 182);
            userPanel.Name = "userPanel";
            userPanel.Size = new Size(596, 406);
            userPanel.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(12, 13);
            label9.Name = "label9";
            label9.Size = new Size(171, 21);
            label9.TabIndex = 17;
            label9.Text = "Editace zaměstnanců";
            // 
            // button1
            // 
            button1.Location = new Point(519, 372);
            button1.Name = "button1";
            button1.Size = new Size(66, 23);
            button1.TabIndex = 16;
            button1.Text = "Smazat";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(519, 343);
            button2.Name = "button2";
            button2.Size = new Size(66, 23);
            button2.TabIndex = 15;
            button2.Text = "Upravit";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(519, 314);
            button3.Name = "button3";
            button3.Size = new Size(66, 23);
            button3.TabIndex = 14;
            button3.Text = "Přidat";
            button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 52);
            label4.Name = "label4";
            label4.Size = new Size(143, 15);
            label4.TabIndex = 13;
            label4.Text = "Vyhledávání zaměstnance";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(161, 49);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(156, 23);
            textBox2.TabIndex = 1;
            // 
            // listViewEmployee
            // 
            listViewEmployee.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9 });
            listViewEmployee.FullRowSelect = true;
            listViewEmployee.GridLines = true;
            listViewEmployee.Location = new Point(12, 81);
            listViewEmployee.MultiSelect = false;
            listViewEmployee.Name = "listViewEmployee";
            listViewEmployee.Size = new Size(501, 314);
            listViewEmployee.TabIndex = 0;
            listViewEmployee.UseCompatibleStateImageBehavior = false;
            listViewEmployee.View = View.Details;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Personal Number";
            columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "RoleName";
            columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "FirstName";
            columnHeader5.Width = 70;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "LastName";
            columnHeader6.Width = 70;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "BirthDate";
            columnHeader7.Width = 70;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Email";
            columnHeader8.Width = 50;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Phone";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblUser);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnLogout);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1203, 61);
            panel1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 17);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 9;
            label5.Text = "Počet prací:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 42);
            label6.Name = "label6";
            label6.Size = new Size(110, 15);
            label6.TabIndex = 10;
            label6.Text = "Počet zaměstnanců";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(12, 79);
            panel2.Name = "panel2";
            panel2.Size = new Size(1203, 97);
            panel2.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 69);
            label7.Name = "label7";
            label7.Size = new Size(201, 15);
            label7.TabIndex = 11;
            label7.Text = "Celkový počet odpracovaných hodin";
            // 
            // panel4
            // 
            panel4.Controls.Add(label11);
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(button7);
            panel4.Controls.Add(button8);
            panel4.Controls.Add(button9);
            panel4.Controls.Add(listView1);
            panel4.Location = new Point(890, 182);
            panel4.Name = "panel4";
            panel4.Size = new Size(325, 406);
            panel4.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(25, 52);
            label11.Name = "label11";
            label11.Size = new Size(103, 15);
            label11.TabIndex = 18;
            label11.Text = "Vyhledávání práce";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(134, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 23);
            textBox1.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(12, 13);
            label10.Name = "label10";
            label10.Size = new Size(112, 21);
            label10.TabIndex = 15;
            label10.Text = "Editace práce";
            // 
            // button7
            // 
            button7.Location = new Point(236, 372);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 19;
            button7.Text = "Smazat uživatele";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(236, 343);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 18;
            button8.Text = "Upravit uživatele";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(236, 314);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 17;
            button9.Text = "Přidat uživatele";
            button9.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader10, Description });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(12, 81);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(211, 322);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Work name";
            columnHeader10.Width = 80;
            // 
            // Description
            // 
            Description.Width = 180;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1224, 598);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(userPanel);
            Controls.Add(workPanel);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AdminForm";
            Text = "FormMain";
            FormClosed += FormMain_FormClosed;
            Load += AdminForm_Load;
            workPanel.ResumeLayout(false);
            workPanel.PerformLayout();
            userPanel.ResumeLayout(false);
            userPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblUser;
        private Label label2;
        private Button btnLogout;
        private Label label3;
        private Panel workPanel;
        private ListView listViewUsers;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Panel userPanel;
        private Button btnAddUser;
        private Button btnEditUser;
        private Button btnDeleteUser;
        private Label label4;
        private TextBox textBox2;
        private ListView listViewEmployee;
        private TextBox txtSearchUser;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private Panel panel1;
        private Label label5;
        private Label label6;
        private Panel panel2;
        private Label label7;
        private Panel panel4;
        private ListView listView1;
        private Label label8;
        private Label label9;
        private Label label11;
        private TextBox textBox1;
        private Label label10;
        private Button button7;
        private Button button8;
        private Button button9;
        private ColumnHeader columnHeader10;
        private ColumnHeader Description;
    }
}