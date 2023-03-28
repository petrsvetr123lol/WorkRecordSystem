namespace WorkRecordSystem.Forms
{
    partial class EmployeeForm
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
            popis = new Label();
            btnLogout = new Button();
            label3 = new Label();
            lblUser = new Label();
            userPanel = new Panel();
            label9 = new Label();
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
            listViewWorks = new ListView();
            columnHeader10 = new ColumnHeader();
            Description = new ColumnHeader();
            panel2 = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            listView1 = new ListView();
            btnDeleteContract = new Button();
            btnAddContract = new Button();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            userPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // popis
            // 
            popis.AutoSize = true;
            popis.Location = new Point(835, 22);
            popis.Name = "popis";
            popis.Size = new Size(104, 15);
            popis.TabIndex = 0;
            popis.Text = "Přihlášený uživatel";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(1020, 15);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Odhlásit se";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 6);
            label3.Name = "label3";
            label3.Size = new Size(211, 32);
            label3.TabIndex = 5;
            label3.Text = "Uživatelská sekce";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = SystemColors.Control;
            lblUser.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser.Location = new Point(945, 18);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(51, 20);
            lblUser.TabIndex = 6;
            lblUser.Text = "label1";
            lblUser.Click += label1_Click;
            // 
            // userPanel
            // 
            userPanel.BackColor = Color.White;
            userPanel.BorderStyle = BorderStyle.FixedSingle;
            userPanel.Controls.Add(label9);
            userPanel.Controls.Add(label4);
            userPanel.Controls.Add(txtSearchEmployee);
            userPanel.Controls.Add(listViewEmployee);
            userPanel.Location = new Point(12, 72);
            userPanel.Name = "userPanel";
            userPanel.Size = new Size(479, 421);
            userPanel.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(12, 13);
            label9.Name = "label9";
            label9.Size = new Size(174, 21);
            label9.TabIndex = 17;
            label9.Text = "Přehled zaměstnanců";
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
            listViewEmployee.Size = new Size(455, 327);
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
            columnHeader4.Text = "Pozice";
            columnHeader4.Width = 50;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Jméno";
            columnHeader5.Width = 50;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Přijmení";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Datum narození";
            columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Email";
            columnHeader8.Width = 80;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Telefon";
            columnHeader9.Width = 80;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(popis);
            panel1.Controls.Add(lblUser);
            panel1.Controls.Add(btnLogout);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1103, 48);
            panel1.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label11);
            panel4.Controls.Add(txtSearchWork);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(listViewWorks);
            panel4.Location = new Point(497, 72);
            panel4.Name = "panel4";
            panel4.Size = new Size(264, 421);
            panel4.TabIndex = 14;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 52);
            label11.Name = "label11";
            label11.Size = new Size(103, 15);
            label11.TabIndex = 18;
            label11.Text = "Vyhledávání práce";
            // 
            // txtSearchWork
            // 
            txtSearchWork.Location = new Point(134, 49);
            txtSearchWork.Name = "txtSearchWork";
            txtSearchWork.Size = new Size(117, 23);
            txtSearchWork.TabIndex = 20;
            txtSearchWork.TextChanged += txtSearchWork_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(12, 13);
            label10.Name = "label10";
            label10.Size = new Size(111, 21);
            label10.TabIndex = 15;
            label10.Text = "Přehled prací";
            // 
            // listViewWorks
            // 
            listViewWorks.Columns.AddRange(new ColumnHeader[] { columnHeader10, Description });
            listViewWorks.FullRowSelect = true;
            listViewWorks.GridLines = true;
            listViewWorks.Location = new Point(12, 81);
            listViewWorks.MultiSelect = false;
            listViewWorks.Name = "listViewWorks";
            listViewWorks.Size = new Size(239, 322);
            listViewWorks.TabIndex = 0;
            listViewWorks.UseCompatibleStateImageBehavior = false;
            listViewWorks.View = View.Details;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Název práce";
            columnHeader10.Width = 80;
            // 
            // Description
            // 
            Description.Text = "Popis práce";
            Description.Width = 180;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnDeleteContract);
            panel2.Controls.Add(btnAddContract);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(listView1);
            panel2.Location = new Point(767, 72);
            panel2.Name = "panel2";
            panel2.Size = new Size(348, 421);
            panel2.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 52);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 18;
            label1.Text = "Vyhledávání kontraktu";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(143, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(115, 23);
            textBox1.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 13);
            label2.Name = "label2";
            label2.Size = new Size(148, 21);
            label2.TabIndex = 15;
            label2.Text = "Přehled kontraktů";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader11, columnHeader12, columnHeader13 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(12, 81);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(246, 322);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // btnDeleteContract
            // 
            btnDeleteContract.Location = new Point(264, 381);
            btnDeleteContract.Name = "btnDeleteContract";
            btnDeleteContract.Size = new Size(75, 23);
            btnDeleteContract.TabIndex = 23;
            btnDeleteContract.Text = "Smazat uživatele";
            btnDeleteContract.UseVisualStyleBackColor = true;
            // 
            // btnAddContract
            // 
            btnAddContract.Location = new Point(264, 352);
            btnAddContract.Name = "btnAddContract";
            btnAddContract.Size = new Size(75, 23);
            btnAddContract.TabIndex = 21;
            btnAddContract.Text = "Přidat uživatele";
            btnAddContract.UseVisualStyleBackColor = true;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Název práce";
            columnHeader11.Width = 80;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Zaměstnanec";
            columnHeader12.Width = 90;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Zákazník";
            columnHeader13.Width = 90;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1129, 502);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(userPanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "EmployeeForm";
            Text = "UserForm";
            Load += EmployeeForm_Load;
            userPanel.ResumeLayout(false);
            userPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label popis;
        private Button btnLogout;
        private Label label3;
        private Label lblUser;
        private Panel userPanel;
        private Label label9;
        private Label label4;
        private TextBox txtSearchEmployee;
        private ListView listViewEmployee;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private Panel panel1;
        private Panel panel4;
        private Label label11;
        private TextBox txtSearchWork;
        private Label label10;
        private ListView listViewWorks;
        private ColumnHeader columnHeader10;
        private ColumnHeader Description;
        private Panel panel2;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private ListView listView1;
        private Button btnDeleteContract;
        private Button btnAddContract;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
    }
}