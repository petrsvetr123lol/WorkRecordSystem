namespace WorkRecordSystem.Forms
{
    partial class AddWorkForm
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
            label1 = new Label();
            txtDescription = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            txtName = new TextBox();
            txtWorkId = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(30, 21);
            label1.Name = "label1";
            label1.Size = new Size(257, 37);
            label1.TabIndex = 0;
            label1.Text = "Přidání nové práce";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(30, 209);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(280, 96);
            txtDescription.TabIndex = 1;
            txtDescription.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 157);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 3;
            label2.Text = "Název práce";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 191);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 4;
            label3.Text = "Popis práce";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(64, 333);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(96, 23);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Zrušit";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(176, 333);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(93, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Uložit";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(84, 154);
            txtName.Name = "txtName";
            txtName.Size = new Size(203, 23);
            txtName.TabIndex = 2;
            // 
            // txtWorkId
            // 
            txtWorkId.Location = new Point(84, 108);
            txtWorkId.Name = "txtWorkId";
            txtWorkId.Size = new Size(203, 23);
            txtWorkId.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 116);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 8;
            label4.Text = "Číso práce";
            // 
            // AddWorkForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 397);
            Controls.Add(label4);
            Controls.Add(txtWorkId);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(txtDescription);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddWorkForm";
            Text = "AddWorkForm";
            Load += AddWorkForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox txtDescription;
        private Label label2;
        private Label label3;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtName;
        private TextBox txtWorkId;
        private Label label4;
    }
}