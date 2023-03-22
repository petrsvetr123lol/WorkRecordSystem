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
            label1 = new Label();
            listViewUsers = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            txtSearchUser = new TextBox();
            btnDeleteUser = new Button();
            btnEditUser = new Button();
            btnAddUser = new Button();
            userPanel = new Panel();
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
            button4 = new Button();
            label5 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            label7 = new Label();
            panel3 = new Panel();
            button6 = new Button();
            button5 = new Button();
            workPanel.SuspendLayout();
            userPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = SystemColors.Control;
            lblUser.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser.Location = new Point(802, 23);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(58, 20);
            lblUser.TabIndex = 0;
            lblUser.Text = "lblUser";
            lblUser.Click += lblUser_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(689, 27);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 1;
            label2.Text = "Přihlášený uživatel:";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(882, 20);
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
            label3.Location = new Point(409, 13);
            label3.Name = "label3";
            label3.Size = new Size(165, 32);
            label3.TabIndex = 4;
            label3.Text = "Administrace";
            // 
            // workPanel
            // 
            workPanel.BackColor = Color.Gray;
            workPanel.Controls.Add(label1);
            workPanel.Controls.Add(listViewUsers);
            workPanel.Controls.Add(txtSearchUser);
            workPanel.Controls.Add(btnDeleteUser);
            workPanel.Controls.Add(btnEditUser);
            workPanel.Controls.Add(btnAddUser);
            workPanel.Location = new Point(12, 182);
            workPanel.Name = "workPanel";
            workPanel.Size = new Size(305, 406);
            workPanel.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 32);
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
            txtSearchUser.Location = new Point(140, 27);
            txtSearchUser.Name = "txtSearchUser";
            txtSearchUser.Size = new Size(148, 23);
            txtSearchUser.TabIndex = 11;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(180, 372);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(108, 23);
            btnDeleteUser.TabIndex = 9;
            btnDeleteUser.Text = "Smazat uživatele";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnEditUser
            // 
            btnEditUser.Location = new Point(180, 343);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(108, 23);
            btnEditUser.TabIndex = 8;
            btnEditUser.Text = "Upravit uživatele";
            btnEditUser.UseVisualStyleBackColor = true;
            btnEditUser.Click += btnEditUser_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(180, 314);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(108, 23);
            btnAddUser.TabIndex = 7;
            btnAddUser.Text = "Přidat uživatele";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // userPanel
            // 
            userPanel.BackColor = SystemColors.ControlDark;
            userPanel.Controls.Add(button1);
            userPanel.Controls.Add(button2);
            userPanel.Controls.Add(button3);
            userPanel.Controls.Add(label4);
            userPanel.Controls.Add(textBox2);
            userPanel.Controls.Add(listViewEmployee);
            userPanel.Location = new Point(342, 182);
            userPanel.Name = "userPanel";
            userPanel.Size = new Size(642, 406);
            userPanel.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(519, 372);
            button1.Name = "button1";
            button1.Size = new Size(108, 23);
            button1.TabIndex = 16;
            button1.Text = "Smazat uživatele";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(519, 343);
            button2.Name = "button2";
            button2.Size = new Size(108, 23);
            button2.TabIndex = 15;
            button2.Text = "Upravit uživatele";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(519, 314);
            button3.Name = "button3";
            button3.Size = new Size(108, 23);
            button3.TabIndex = 14;
            button3.Text = "Přidat uživatele";
            button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 16);
            label4.Name = "label4";
            label4.Size = new Size(143, 15);
            label4.TabIndex = 13;
            label4.Text = "Vyhledávání zaměstnance";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(161, 13);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(156, 23);
            textBox2.TabIndex = 1;
            // 
            // listViewEmployee
            // 
            listViewEmployee.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9 });
            listViewEmployee.FullRowSelect = true;
            listViewEmployee.GridLines = true;
            listViewEmployee.Location = new Point(12, 52);
            listViewEmployee.MultiSelect = false;
            listViewEmployee.Name = "listViewEmployee";
            listViewEmployee.Size = new Size(501, 343);
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
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblUser);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnLogout);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(972, 61);
            panel1.TabIndex = 7;
            // 
            // button4
            // 
            button4.Location = new Point(12, 13);
            button4.Name = "button4";
            button4.Size = new Size(168, 71);
            button4.TabIndex = 8;
            button4.Text = "Přidat práci";
            button4.UseVisualStyleBackColor = true;
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
            panel2.Size = new Size(305, 97);
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
            // panel3
            // 
            panel3.Controls.Add(button6);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button4);
            panel3.Location = new Point(342, 79);
            panel3.Name = "panel3";
            panel3.Size = new Size(642, 97);
            panel3.TabIndex = 12;
            // 
            // button6
            // 
            button6.Location = new Point(362, 13);
            button6.Name = "button6";
            button6.Size = new Size(168, 71);
            button6.TabIndex = 10;
            button6.Text = "Zobrazit aktivní práce";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(186, 14);
            button5.Name = "button5";
            button5.Size = new Size(168, 71);
            button5.TabIndex = 9;
            button5.Text = "Zobrazit práce";
            button5.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 598);
            Controls.Add(panel1);
            Controls.Add(userPanel);
            Controls.Add(workPanel);
            Controls.Add(panel2);
            Controls.Add(panel3);
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
            panel3.ResumeLayout(false);
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
        private Button button4;
        private Label label5;
        private Label label6;
        private Panel panel2;
        private Label label7;
        private Panel panel3;
        private Button button6;
        private Button button5;
    }
}