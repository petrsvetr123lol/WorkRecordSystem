﻿namespace WorkRecordSystem.Forms
{
    partial class AddContractForm
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
            panel2 = new Panel();
            btnCreateContract = new Button();
            txtEmployeeId = new TextBox();
            txtWorkId = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtCustomer = new TextBox();
            label3 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtCustomer);
            panel2.Controls.Add(btnCreateContract);
            panel2.Controls.Add(txtEmployeeId);
            panel2.Controls.Add(txtWorkId);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(267, 191);
            panel2.TabIndex = 17;
            // 
            // btnCreateContract
            // 
            btnCreateContract.Location = new Point(19, 153);
            btnCreateContract.Name = "btnCreateContract";
            btnCreateContract.Size = new Size(225, 24);
            btnCreateContract.TabIndex = 21;
            btnCreateContract.Text = "Vytvořit kontrakt";
            btnCreateContract.UseVisualStyleBackColor = true;
            // 
            // txtEmployeeId
            // 
            txtEmployeeId.Location = new Point(97, 80);
            txtEmployeeId.Name = "txtEmployeeId";
            txtEmployeeId.Size = new Size(147, 23);
            txtEmployeeId.TabIndex = 20;
            // 
            // txtWorkId
            // 
            txtWorkId.Location = new Point(97, 53);
            txtWorkId.Name = "txtWorkId";
            txtWorkId.Size = new Size(147, 23);
            txtWorkId.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 83);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 18;
            label5.Text = "Osobní číslo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 56);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 17;
            label2.Text = "Id práce";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(42, 11);
            label1.Name = "label1";
            label1.Size = new Size(183, 30);
            label1.TabIndex = 16;
            label1.Text = "Vytvořit kontrakt";
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(97, 109);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(147, 23);
            txtCustomer.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 112);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 23;
            label3.Text = "Zákazník";
            // 
            // AddContractForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(295, 219);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddContractForm";
            Text = "AddContract";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button btnCreateContract;
        private TextBox txtEmployeeId;
        private TextBox txtWorkId;
        private Label label5;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txtCustomer;
    }
}