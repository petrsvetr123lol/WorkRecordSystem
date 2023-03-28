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
            btnDeleteEmployee = new Button();
            btnEditEmployee = new Button();
            btnAddEmployee = new Button();
            label4 = new Label();
            txtSearchEmployee = new TextBox();
            listViewEmployee = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            panel1 = new Panel();
            panel4 = new Panel();
            label11 = new Label();
            txtSearchWork = new TextBox();
            label10 = new Label();
            btnDeleteWork = new Button();
            btnEditWork = new Button();
            btnAddWork = new Button();
            listViewWorks = new ListView();
            columnHeader11 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            Description = new ColumnHeader();
            workPanel.SuspendLayout();
            userPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = SystemColors.Control;
            lblUser.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser.Location = new Point(1024, 22);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(58, 20);
            lblUser.TabIndex = 0;
            lblUser.Text = "lblUser";
            lblUser.Click += lblUser_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(911, 25);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 1;
            label2.Text = "Přihlášený uživatel:";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(1103, 19);
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
            label3.Location = new Point(15, 12);
            label3.Name = "label3";
            label3.Size = new Size(304, 32);
            label3.TabIndex = 4;
            label3.Text = "WRS Administrační panel";
            // 
            // workPanel
            // 
            workPanel.BackColor = Color.White;
            workPanel.BorderStyle = BorderStyle.FixedSingle;
            workPanel.Controls.Add(label8);
            workPanel.Controls.Add(label1);
            workPanel.Controls.Add(listViewUsers);
            workPanel.Controls.Add(txtSearchUser);
            workPanel.Controls.Add(btnDeleteUser);
            workPanel.Controls.Add(btnEditUser);
            workPanel.Controls.Add(btnAddUser);
            workPanel.Location = new Point(12, 79);
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
            columnHeader1.Text = "Jméno";
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
            txtSearchUser.TextChanged += txtSearchUser_TextChanged;
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
            userPanel.BorderStyle = BorderStyle.FixedSingle;
            userPanel.Controls.Add(label9);
            userPanel.Controls.Add(btnDeleteEmployee);
            userPanel.Controls.Add(btnEditEmployee);
            userPanel.Controls.Add(btnAddEmployee);
            userPanel.Controls.Add(label4);
            userPanel.Controls.Add(txtSearchEmployee);
            userPanel.Controls.Add(listViewEmployee);
            userPanel.Location = new Point(276, 79);
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
            // btnDeleteEmployee
            // 
            btnDeleteEmployee.Location = new Point(519, 372);
            btnDeleteEmployee.Name = "btnDeleteEmployee";
            btnDeleteEmployee.Size = new Size(66, 23);
            btnDeleteEmployee.TabIndex = 16;
            btnDeleteEmployee.Text = "Smazat";
            btnDeleteEmployee.UseVisualStyleBackColor = true;
            btnDeleteEmployee.Click += btnDeleteEmployee_Click;
            // 
            // btnEditEmployee
            // 
            btnEditEmployee.Location = new Point(519, 343);
            btnEditEmployee.Name = "btnEditEmployee";
            btnEditEmployee.Size = new Size(66, 23);
            btnEditEmployee.TabIndex = 15;
            btnEditEmployee.Text = "Upravit";
            btnEditEmployee.UseVisualStyleBackColor = true;
            btnEditEmployee.Click += btnEditEmployee_Click;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Location = new Point(519, 314);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(66, 23);
            btnAddEmployee.TabIndex = 14;
            btnAddEmployee.Text = "Přidat";
            btnAddEmployee.UseVisualStyleBackColor = true;
            btnAddEmployee.Click += button3_Click;
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
            // txtSearchEmployee
            // 
            txtSearchEmployee.Location = new Point(161, 49);
            txtSearchEmployee.Name = "txtSearchEmployee";
            txtSearchEmployee.Size = new Size(156, 23);
            txtSearchEmployee.TabIndex = 1;
            txtSearchEmployee.TextChanged += txtSearchEmployee_TextChanged;
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
            columnHeader3.Text = "OČ";
            columnHeader3.Width = 30;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Pracovní pozice";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Jméno";
            columnHeader5.Width = 70;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Přijmení";
            columnHeader6.Width = 70;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Datum narození";
            columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Email";
            columnHeader8.Width = 50;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Telefon";
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
            panel1.Size = new Size(1191, 61);
            panel1.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label11);
            panel4.Controls.Add(txtSearchWork);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(btnDeleteWork);
            panel4.Controls.Add(btnEditWork);
            panel4.Controls.Add(btnAddWork);
            panel4.Controls.Add(listViewWorks);
            panel4.Location = new Point(878, 79);
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
            // txtSearchWork
            // 
            txtSearchWork.Location = new Point(134, 49);
            txtSearchWork.Name = "txtSearchWork";
            txtSearchWork.Size = new Size(156, 23);
            txtSearchWork.TabIndex = 20;
            txtSearchWork.TextChanged += txtSearchWork_TextChanged;
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
            // btnDeleteWork
            // 
            btnDeleteWork.Location = new Point(236, 372);
            btnDeleteWork.Name = "btnDeleteWork";
            btnDeleteWork.Size = new Size(75, 23);
            btnDeleteWork.TabIndex = 19;
            btnDeleteWork.Text = "Smazat uživatele";
            btnDeleteWork.UseVisualStyleBackColor = true;
            btnDeleteWork.Click += btnDeleteWork_Click;
            // 
            // btnEditWork
            // 
            btnEditWork.Location = new Point(236, 343);
            btnEditWork.Name = "btnEditWork";
            btnEditWork.Size = new Size(75, 23);
            btnEditWork.TabIndex = 18;
            btnEditWork.Text = "Upravit uživatele";
            btnEditWork.UseVisualStyleBackColor = true;
            btnEditWork.Click += btnEditWork_Click;
            // 
            // btnAddWork
            // 
            btnAddWork.Location = new Point(236, 314);
            btnAddWork.Name = "btnAddWork";
            btnAddWork.Size = new Size(75, 23);
            btnAddWork.TabIndex = 17;
            btnAddWork.Text = "Přidat uživatele";
            btnAddWork.UseVisualStyleBackColor = true;
            btnAddWork.Click += button9_Click;
            // 
            // listViewWorks
            // 
            listViewWorks.Columns.AddRange(new ColumnHeader[] { columnHeader11, columnHeader10, Description });
            listViewWorks.FullRowSelect = true;
            listViewWorks.GridLines = true;
            listViewWorks.Location = new Point(12, 83);
            listViewWorks.MultiSelect = false;
            listViewWorks.Name = "listViewWorks";
            listViewWorks.Size = new Size(211, 312);
            listViewWorks.TabIndex = 0;
            listViewWorks.UseCompatibleStateImageBehavior = false;
            listViewWorks.View = View.Details;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "ID";
            columnHeader11.Width = 30;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Jméno práce";
            columnHeader10.Width = 80;
            // 
            // Description
            // 
            Description.Text = "Popis práce";
            Description.Width = 255;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1212, 495);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(userPanel);
            Controls.Add(workPanel);
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
        private TextBox txtSearchEmployee;
        private ListView listViewEmployee;
        private TextBox txtSearchUser;
        private Label label1;
        private Button btnDeleteEmployee;
        private Button btnEditEmployee;
        private Button btnAddEmployee;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private Panel panel1;
        private Panel panel4;
        private ListView listViewWorks;
        private Label label8;
        private Label label9;
        private Label label11;
        private TextBox txtSearchWork;
        private Label label10;
        private Button btnDeleteWork;
        private Button btnEditWork;
        private Button btnAddWork;
        private ColumnHeader columnHeader10;
        private ColumnHeader Description;
        private ColumnHeader columnHeader11;
    }
}