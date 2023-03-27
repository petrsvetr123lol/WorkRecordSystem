namespace WorkRecordSystem.Forms
{
    partial class EditWork
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
            label4 = new Label();
            txtWorkId = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            label3 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            txtDescription = new RichTextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 127);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 17;
            label4.Text = "Číso práce";
            // 
            // txtWorkId
            // 
            txtWorkId.Location = new Point(93, 119);
            txtWorkId.Name = "txtWorkId";
            txtWorkId.Size = new Size(203, 23);
            txtWorkId.TabIndex = 16;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(185, 344);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(93, 23);
            btnSave.TabIndex = 15;
            btnSave.Text = "Uložit";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(73, 344);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(96, 23);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Zrušit";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 202);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 13;
            label3.Text = "Popis práce";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 168);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 12;
            label2.Text = "Název práce";
            // 
            // txtName
            // 
            txtName.Location = new Point(93, 165);
            txtName.Name = "txtName";
            txtName.Size = new Size(203, 23);
            txtName.TabIndex = 11;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(39, 220);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(280, 96);
            txtDescription.TabIndex = 10;
            txtDescription.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(62, 37);
            label1.Name = "label1";
            label1.Size = new Size(188, 37);
            label1.TabIndex = 9;
            label1.Text = "Editace práce";
            // 
            // EditWork
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 393);
            Controls.Add(label4);
            Controls.Add(txtWorkId);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(txtDescription);
            Controls.Add(label1);
            Name = "EditWork";
            Text = "EditWork";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox txtWorkId;
        private Button btnSave;
        private Button btnCancel;
        private Label label3;
        private Label label2;
        private TextBox txtName;
        private RichTextBox txtDescription;
        private Label label1;
    }
}