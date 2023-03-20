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
            workPanel.SuspendLayout();
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
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(165, 32);
            label3.TabIndex = 4;
            label3.Text = "Administrace";
            // 
            // workPanel
            // 
            workPanel.Controls.Add(listViewUsers);
            workPanel.Location = new Point(24, 90);
            workPanel.Name = "workPanel";
            workPanel.Size = new Size(366, 398);
            workPanel.TabIndex = 5;
            // 
            // listViewUsers
            // 
            listViewUsers.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listViewUsers.FullRowSelect = true;
            listViewUsers.GridLines = true;
            listViewUsers.Location = new Point(3, 13);
            listViewUsers.MultiSelect = false;
            listViewUsers.Name = "listViewUsers";
            listViewUsers.Size = new Size(360, 382);
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
            userPanel.Location = new Point(410, 90);
            userPanel.Name = "userPanel";
            userPanel.Size = new Size(366, 398);
            userPanel.TabIndex = 6;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(27, 61);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(103, 23);
            btnAddUser.TabIndex = 7;
            btnAddUser.Text = "Přidat uživatele";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnEditUser
            // 
            btnEditUser.Location = new Point(136, 61);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(108, 23);
            btnEditUser.TabIndex = 8;
            btnEditUser.Text = "Upravit uživatele";
            btnEditUser.UseVisualStyleBackColor = true;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(250, 61);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(104, 23);
            btnDeleteUser.TabIndex = 9;
            btnDeleteUser.Text = "Smazat uživatele";
            btnDeleteUser.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1190, 521);
            Controls.Add(btnDeleteUser);
            Controls.Add(btnEditUser);
            Controls.Add(btnAddUser);
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
    }
}