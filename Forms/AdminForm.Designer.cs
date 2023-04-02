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
            components = new System.ComponentModel.Container();
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
            lblTime = new Label();
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
            panel2 = new Panel();
            btnDeleteContract = new Button();
            btnAddContract = new Button();
            label5 = new Label();
            txtContractSearch = new TextBox();
            label6 = new Label();
            listViewContracts = new ListView();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            columnHeader16 = new ColumnHeader();
            columnHeader20 = new ColumnHeader();
            columnHeader21 = new ColumnHeader();
            panel3 = new Panel();
            lblSumHours = new Label();
            lblCountWorks = new Label();
            lblCountContracts = new Label();
            lblCountEmployees = new Label();
            lblCountUsers = new Label();
            label18 = new Label();
            label17 = new Label();
            btnExport = new Button();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label7 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            workPanel.SuspendLayout();
            userPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = SystemColors.Control;
            lblUser.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser.Location = new Point(1078, 25);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(58, 20);
            lblUser.TabIndex = 0;
            lblUser.Text = "lblUser";
            lblUser.Click += lblUser_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(965, 28);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 1;
            label2.Text = "Přihlášený uživatel:";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(1157, 22);
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
            label3.Location = new Point(66, 15);
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
            workPanel.Location = new Point(456, 408);
            workPanel.Name = "workPanel";
            workPanel.Size = new Size(267, 406);
            workPanel.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(14, 13);
            label8.Name = "label8";
            label8.Size = new Size(137, 21);
            label8.TabIndex = 14;
            label8.Text = "Správa uživatelů";
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
            listViewUsers.Size = new Size(175, 314);
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
            btnDeleteUser.Location = new Point(195, 373);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(67, 23);
            btnDeleteUser.TabIndex = 9;
            btnDeleteUser.Text = "Smazat";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnEditUser
            // 
            btnEditUser.Location = new Point(195, 344);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(67, 23);
            btnEditUser.TabIndex = 8;
            btnEditUser.Text = "Reset";
            btnEditUser.UseVisualStyleBackColor = true;
            btnEditUser.Click += btnEditUser_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(195, 315);
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
            userPanel.Location = new Point(626, 83);
            userPanel.Name = "userPanel";
            userPanel.Size = new Size(632, 315);
            userPanel.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(16, 13);
            label9.Name = "label9";
            label9.Size = new Size(167, 21);
            label9.TabIndex = 17;
            label9.Text = "Správa zaměstnanců";
            // 
            // btnDeleteEmployee
            // 
            btnDeleteEmployee.Location = new Point(551, 44);
            btnDeleteEmployee.Name = "btnDeleteEmployee";
            btnDeleteEmployee.Size = new Size(66, 23);
            btnDeleteEmployee.TabIndex = 16;
            btnDeleteEmployee.Text = "Smazat";
            btnDeleteEmployee.UseVisualStyleBackColor = true;
            btnDeleteEmployee.Click += btnDeleteEmployee_Click;
            // 
            // btnEditEmployee
            // 
            btnEditEmployee.Location = new Point(481, 45);
            btnEditEmployee.Name = "btnEditEmployee";
            btnEditEmployee.Size = new Size(66, 23);
            btnEditEmployee.TabIndex = 15;
            btnEditEmployee.Text = "Upravit";
            btnEditEmployee.UseVisualStyleBackColor = true;
            btnEditEmployee.Click += btnEditEmployee_Click;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Location = new Point(409, 44);
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
            label4.Location = new Point(16, 49);
            label4.Name = "label4";
            label4.Size = new Size(212, 15);
            label4.TabIndex = 13;
            label4.Text = "Vyhledávání zaměstnance podle jména";
            // 
            // txtSearchEmployee
            // 
            txtSearchEmployee.Location = new Point(237, 44);
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
            listViewEmployee.Location = new Point(16, 81);
            listViewEmployee.MultiSelect = false;
            listViewEmployee.Name = "listViewEmployee";
            listViewEmployee.Size = new Size(601, 217);
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
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblTime);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblUser);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnLogout);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1246, 61);
            panel1.TabIndex = 7;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTime.Location = new Point(577, 15);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(84, 30);
            lblTime.TabIndex = 9;
            lblTime.Text = "label19";
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
            panel4.Location = new Point(729, 408);
            panel4.Name = "panel4";
            panel4.Size = new Size(529, 406);
            panel4.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 52);
            label11.Name = "label11";
            label11.Size = new Size(170, 15);
            label11.TabIndex = 18;
            label11.Text = "Vyhledávání práce podle názvu";
            // 
            // txtSearchWork
            // 
            txtSearchWork.Location = new Point(188, 49);
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
            label10.Size = new Size(108, 21);
            label10.TabIndex = 15;
            label10.Text = "Správa práce";
            // 
            // btnDeleteWork
            // 
            btnDeleteWork.Location = new Point(439, 363);
            btnDeleteWork.Name = "btnDeleteWork";
            btnDeleteWork.Size = new Size(75, 23);
            btnDeleteWork.TabIndex = 19;
            btnDeleteWork.Text = "Smazat uživatele";
            btnDeleteWork.UseVisualStyleBackColor = true;
            btnDeleteWork.Click += btnDeleteWork_Click;
            // 
            // btnEditWork
            // 
            btnEditWork.Location = new Point(439, 334);
            btnEditWork.Name = "btnEditWork";
            btnEditWork.Size = new Size(75, 23);
            btnEditWork.TabIndex = 18;
            btnEditWork.Text = "Upravit uživatele";
            btnEditWork.UseVisualStyleBackColor = true;
            btnEditWork.Click += btnEditWork_Click;
            // 
            // btnAddWork
            // 
            btnAddWork.Location = new Point(439, 305);
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
            listViewWorks.Size = new Size(421, 312);
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
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnDeleteContract);
            panel2.Controls.Add(btnAddContract);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtContractSearch);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(listViewContracts);
            panel2.Location = new Point(12, 83);
            panel2.Name = "panel2";
            panel2.Size = new Size(608, 315);
            panel2.TabIndex = 22;
            // 
            // btnDeleteContract
            // 
            btnDeleteContract.Location = new Point(491, 49);
            btnDeleteContract.Name = "btnDeleteContract";
            btnDeleteContract.Size = new Size(75, 23);
            btnDeleteContract.TabIndex = 23;
            btnDeleteContract.Text = "Smazat uživatele";
            btnDeleteContract.UseVisualStyleBackColor = true;
            btnDeleteContract.Click += btnDeleteContract_Click;
            // 
            // btnAddContract
            // 
            btnAddContract.Cursor = Cursors.Hand;
            btnAddContract.Location = new Point(410, 49);
            btnAddContract.Name = "btnAddContract";
            btnAddContract.Size = new Size(75, 23);
            btnAddContract.TabIndex = 21;
            btnAddContract.Text = "Přidat uživatele";
            btnAddContract.UseVisualStyleBackColor = true;
            btnAddContract.Click += btnAddContract_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 52);
            label5.Name = "label5";
            label5.Size = new Size(211, 15);
            label5.TabIndex = 18;
            label5.Text = "Vyhledávání kontraktu podle zákazníka";
            // 
            // txtContractSearch
            // 
            txtContractSearch.Location = new Point(229, 49);
            txtContractSearch.Name = "txtContractSearch";
            txtContractSearch.Size = new Size(152, 23);
            txtContractSearch.TabIndex = 20;
            txtContractSearch.TextChanged += txtContractSearch_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 13);
            label6.Name = "label6";
            label6.Size = new Size(141, 21);
            label6.TabIndex = 15;
            label6.Text = "Správa kontraktů";
            // 
            // listViewContracts
            // 
            listViewContracts.Columns.AddRange(new ColumnHeader[] { columnHeader12, columnHeader13, columnHeader15, columnHeader16, columnHeader20, columnHeader21 });
            listViewContracts.FullRowSelect = true;
            listViewContracts.GridLines = true;
            listViewContracts.Location = new Point(12, 81);
            listViewContracts.MultiSelect = false;
            listViewContracts.Name = "listViewContracts";
            listViewContracts.Size = new Size(576, 217);
            listViewContracts.TabIndex = 0;
            listViewContracts.UseCompatibleStateImageBehavior = false;
            listViewContracts.View = View.Details;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "ID";
            columnHeader12.Width = 30;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Název práce";
            columnHeader13.Width = 80;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "Příjmení zaměstnance";
            columnHeader15.Width = 130;
            // 
            // columnHeader16
            // 
            columnHeader16.Text = "Jméno zákazníka";
            columnHeader16.Width = 110;
            // 
            // columnHeader20
            // 
            columnHeader20.Text = "Datum";
            columnHeader20.Width = 150;
            // 
            // columnHeader21
            // 
            columnHeader21.Text = "Hodin";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lblSumHours);
            panel3.Controls.Add(lblCountWorks);
            panel3.Controls.Add(lblCountContracts);
            panel3.Controls.Add(lblCountEmployees);
            panel3.Controls.Add(lblCountUsers);
            panel3.Controls.Add(label18);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(btnExport);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(12, 408);
            panel3.Name = "panel3";
            panel3.Size = new Size(438, 406);
            panel3.TabIndex = 23;
            // 
            // lblSumHours
            // 
            lblSumHours.AutoSize = true;
            lblSumHours.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSumHours.Location = new Point(266, 200);
            lblSumHours.Name = "lblSumHours";
            lblSumHours.Size = new Size(52, 17);
            lblSumHours.TabIndex = 13;
            lblSumHours.Text = "label23";
            // 
            // lblCountWorks
            // 
            lblCountWorks.AutoSize = true;
            lblCountWorks.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCountWorks.Location = new Point(266, 167);
            lblCountWorks.Name = "lblCountWorks";
            lblCountWorks.Size = new Size(52, 17);
            lblCountWorks.TabIndex = 12;
            lblCountWorks.Text = "label22";
            // 
            // lblCountContracts
            // 
            lblCountContracts.AutoSize = true;
            lblCountContracts.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCountContracts.Location = new Point(266, 129);
            lblCountContracts.Name = "lblCountContracts";
            lblCountContracts.Size = new Size(52, 17);
            lblCountContracts.TabIndex = 11;
            lblCountContracts.Text = "label21";
            // 
            // lblCountEmployees
            // 
            lblCountEmployees.AutoSize = true;
            lblCountEmployees.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCountEmployees.Location = new Point(266, 91);
            lblCountEmployees.Name = "lblCountEmployees";
            lblCountEmployees.Size = new Size(52, 17);
            lblCountEmployees.TabIndex = 10;
            lblCountEmployees.Text = "label20";
            // 
            // lblCountUsers
            // 
            lblCountUsers.AutoSize = true;
            lblCountUsers.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCountUsers.Location = new Point(266, 55);
            lblCountUsers.Name = "lblCountUsers";
            lblCountUsers.Size = new Size(52, 17);
            lblCountUsers.TabIndex = 9;
            lblCountUsers.Text = "label19";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(14, 298);
            label18.Name = "label18";
            label18.Size = new Size(308, 30);
            label18.TabIndex = 8;
            label18.Text = "Všechny kontrakty je možné exportovat do .csv souboru. \r\nMůžete tak provést kliknutím na tlačítko níže.\r\n";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(12, 255);
            label17.Name = "label17";
            label17.Size = new Size(278, 25);
            label17.TabIndex = 7;
            label17.Text = "Export kontraktů do souboru";
            // 
            // btnExport
            // 
            btnExport.Location = new Point(14, 344);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(75, 23);
            btnExport.TabIndex = 6;
            btnExport.Text = "Exportovat";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(14, 202);
            label16.Name = "label16";
            label16.Size = new Size(201, 15);
            label16.TabIndex = 5;
            label16.Text = "Celkový počet odpracovaných hodin";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(14, 167);
            label15.Name = "label15";
            label15.Size = new Size(111, 15);
            label15.TabIndex = 4;
            label15.Text = "Celkový počet prací";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(14, 129);
            label14.Name = "label14";
            label14.Size = new Size(136, 15);
            label14.TabIndex = 3;
            label14.Text = "Celkový počet kontraktů";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(14, 93);
            label13.Name = "label13";
            label13.Size = new Size(155, 15);
            label13.TabIndex = 2;
            label13.Text = "Celkový počet zaměstnanců";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(12, 13);
            label12.Name = "label12";
            label12.Size = new Size(93, 25);
            label12.TabIndex = 1;
            label12.Text = "Statistika";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 57);
            label7.Name = "label7";
            label7.Size = new Size(132, 15);
            label7.TabIndex = 0;
            label7.Text = "Celkový počet uživatelů";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1272, 819);
            Controls.Add(panel3);
            Controls.Add(panel2);
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
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Panel panel2;
        private Button btnDeleteContract;
        private Button btnAddContract;
        private Label label5;
        private TextBox txtContractSearch;
        private Label label6;
        private ListView listViewContracts;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader16;
        private ColumnHeader columnHeader20;
        private ColumnHeader columnHeader21;
        private Panel panel3;
        private Label lblTime;
        private Label label18;
        private Label label17;
        private Button btnExport;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label7;
        private System.Windows.Forms.Timer timer1;
        private Label lblSumHours;
        private Label lblCountWorks;
        private Label lblCountContracts;
        private Label lblCountEmployees;
        private Label lblCountUsers;
        private PictureBox pictureBox1;
    }
}