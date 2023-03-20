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
            listViewUsers = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            userPanel = new Panel();
            btnAddUser = new Button();
            btnEditUser = new Button();
            btnDeleteUser = new Button();
            button1 = new Button();
            txtSearchUser = new TextBox();
            label1 = new Label();
            listView1 = new ListView();
            textBox2 = new TextBox();
            label4 = new Label();
            button2 = new Button();
            workPanel.SuspendLayout();
            userPanel.SuspendLayout();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = SystemColors.Control;
            lblUser.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser.Location = new Point(1018, 16);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(58, 20);
            lblUser.TabIndex = 0;
            lblUser.Text = "lblUser";
            lblUser.Click += lblUser_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(905, 20);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 1;
            label2.Text = "Přihlášený uživatel:";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(1103, 12);
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
            label3.Location = new Point(27, 20);
            label3.Name = "label3";
            label3.Size = new Size(165, 32);
            label3.TabIndex = 4;
            label3.Text = "Administrace";
            // 
            // workPanel
            // 
            workPanel.Controls.Add(listViewUsers);
            workPanel.Controls.Add(button1);
            workPanel.Controls.Add(btnDeleteUser);
            workPanel.Controls.Add(btnEditUser);
            workPanel.Controls.Add(btnAddUser);
            workPanel.Location = new Point(24, 82);
            workPanel.Name = "workPanel";
            workPanel.Size = new Size(380, 406);
            workPanel.TabIndex = 5;
            // 
            // listViewUsers
            // 
            listViewUsers.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listViewUsers.FullRowSelect = true;
            listViewUsers.GridLines = true;
            listViewUsers.Location = new Point(3, 49);
            listViewUsers.MultiSelect = false;
            listViewUsers.Name = "listViewUsers";
            listViewUsers.Size = new Size(249, 346);
            listViewUsers.TabIndex = 0;
            listViewUsers.UseCompatibleStateImageBehavior = false;
            listViewUsers.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Role";
            // 
            // userPanel
            // 
            userPanel.Controls.Add(button2);
            userPanel.Controls.Add(label4);
            userPanel.Controls.Add(textBox2);
            userPanel.Controls.Add(listView1);
            userPanel.Location = new Point(410, 82);
            userPanel.Name = "userPanel";
            userPanel.Size = new Size(452, 406);
            userPanel.TabIndex = 6;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(263, 52);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(108, 23);
            btnAddUser.TabIndex = 7;
            btnAddUser.Text = "Přidat uživatele";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnEditUser
            // 
            btnEditUser.Location = new Point(263, 81);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(108, 23);
            btnEditUser.TabIndex = 8;
            btnEditUser.Text = "Upravit uživatele";
            btnEditUser.UseVisualStyleBackColor = true;
            btnEditUser.Click += btnEditUser_Click;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(263, 372);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(108, 23);
            btnDeleteUser.TabIndex = 9;
            btnDeleteUser.Text = "Smazat uživatele";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // button1
            // 
            button1.Location = new Point(263, 110);
            button1.Name = "button1";
            button1.Size = new Size(108, 23);
            button1.TabIndex = 10;
            button1.Text = "Změnit heslo";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtSearchUser
            // 
            txtSearchUser.Location = new Point(153, 95);
            txtSearchUser.Name = "txtSearchUser";
            txtSearchUser.Size = new Size(123, 23);
            txtSearchUser.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 98);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 12;
            label1.Text = "Vyhledávání uživatele";
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 52);
            listView1.Name = "listView1";
            listView1.Size = new Size(338, 343);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(161, 13);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(119, 23);
            textBox2.TabIndex = 1;
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
            // button2
            // 
            button2.Location = new Point(356, 52);
            button2.Name = "button2";
            button2.Size = new Size(85, 23);
            button2.TabIndex = 14;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1190, 521);
            Controls.Add(label1);
            Controls.Add(txtSearchUser);
            Controls.Add(userPanel);
            Controls.Add(workPanel);
            Controls.Add(label3);
            Controls.Add(btnLogout);
            Controls.Add(label2);
            Controls.Add(lblUser);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AdminForm";
            Text = "FormMain";
            FormClosed += FormMain_FormClosed;
            Load += AdminForm_Load;
            workPanel.ResumeLayout(false);
            userPanel.ResumeLayout(false);
            userPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Button button1;
        private Button button2;
        private Label label4;
        private TextBox textBox2;
        private ListView listView1;
        private TextBox txtSearchUser;
        private Label label1;
    }
}