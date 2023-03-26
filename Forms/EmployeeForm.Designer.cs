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
            panel4 = new Panel();
            label11 = new Label();
            textBox1 = new TextBox();
            label10 = new Label();
            listView1 = new ListView();
            columnHeader10 = new ColumnHeader();
            Description = new ColumnHeader();
            panel2 = new Panel();
            button1 = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            button2 = new Button();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            userPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // popis
            // 
            popis.AutoSize = true;
            popis.Location = new Point(862, 22);
            popis.Name = "popis";
            popis.Size = new Size(104, 15);
            popis.TabIndex = 0;
            popis.Text = "Přihlášený uživatel";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(1047, 15);
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
            lblUser.Location = new Point(972, 18);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(51, 20);
            lblUser.TabIndex = 6;
            lblUser.Text = "label1";
            lblUser.Click += label1_Click;
            // 
            // userPanel
            // 
            userPanel.BackColor = Color.White;
            userPanel.Controls.Add(label9);
            userPanel.Controls.Add(label4);
            userPanel.Controls.Add(textBox2);
            userPanel.Controls.Add(listViewEmployee);
            userPanel.Location = new Point(12, 88);
            userPanel.Name = "userPanel";
            userPanel.Size = new Size(533, 421);
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
            listViewEmployee.Size = new Size(501, 327);
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
            panel1.Controls.Add(label3);
            panel1.Controls.Add(popis);
            panel1.Controls.Add(lblUser);
            panel1.Controls.Add(btnLogout);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1134, 48);
            panel1.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.Controls.Add(label11);
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(listView1);
            panel4.Location = new Point(551, 88);
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
            // textBox1
            // 
            textBox1.Location = new Point(134, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(117, 23);
            textBox1.TabIndex = 20;
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
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader10, Description });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(12, 81);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(239, 322);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
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
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(821, 88);
            panel2.Name = "panel2";
            panel2.Size = new Size(325, 179);
            panel2.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(53, 140);
            button1.Name = "button1";
            button1.Size = new Size(204, 24);
            button1.TabIndex = 21;
            button1.Text = "Přiřadit práci";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(110, 90);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(147, 23);
            textBox4.TabIndex = 20;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(110, 60);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(147, 23);
            textBox3.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 98);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 18;
            label5.Text = "Osobní číslo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 68);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 17;
            label2.Text = "Id práce";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(17, 13);
            label1.Name = "label1";
            label1.Size = new Size(109, 21);
            label1.TabIndex = 16;
            label1.Text = "Přiradit práci";
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Controls.Add(textBox5);
            panel3.Controls.Add(textBox6);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label8);
            panel3.Location = new Point(821, 282);
            panel3.Name = "panel3";
            panel3.Size = new Size(325, 182);
            panel3.TabIndex = 16;
            // 
            // button2
            // 
            button2.Location = new Point(53, 144);
            button2.Name = "button2";
            button2.Size = new Size(204, 24);
            button2.TabIndex = 22;
            button2.Text = "Odebrat práci";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(110, 90);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(147, 23);
            textBox5.TabIndex = 20;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(110, 60);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(147, 23);
            textBox6.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 98);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 18;
            label6.Text = "Osobní číslo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 68);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 17;
            label7.Text = "Id práce";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(17, 13);
            label8.Name = "label8";
            label8.Size = new Size(114, 21);
            label8.TabIndex = 16;
            label8.Text = "Odebrat práci";
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 521);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(userPanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "EmployeeForm";
            Text = "UserForm";
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
        private TextBox textBox2;
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
        private TextBox textBox1;
        private Label label10;
        private ListView listView1;
        private ColumnHeader columnHeader10;
        private ColumnHeader Description;
        private Panel panel2;
        private Button button1;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label5;
        private Label label2;
        private Label label1;
        private Panel panel3;
        private Button button2;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}