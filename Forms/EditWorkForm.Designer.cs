namespace WorkRecordSystem.Forms
{
    partial class EditWorkForm
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 62);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 17;
            label4.Text = "Číso práce";
            // 
            // txtWorkId
            // 
            txtWorkId.Location = new Point(90, 59);
            txtWorkId.Name = "txtWorkId";
            txtWorkId.Size = new Size(203, 23);
            txtWorkId.TabIndex = 16;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(160, 268);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(141, 23);
            btnSave.TabIndex = 15;
            btnSave.Text = "Uložit";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(13, 268);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(141, 23);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Zrušit";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 126);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 13;
            label3.Text = "Popis práce";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 99);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 12;
            label2.Text = "Název práce";
            // 
            // txtName
            // 
            txtName.Location = new Point(90, 91);
            txtName.Name = "txtName";
            txtName.Size = new Size(203, 23);
            txtName.TabIndex = 11;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(13, 144);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(280, 105);
            txtDescription.TabIndex = 10;
            txtDescription.Text = "";
            txtDescription.KeyDown += txtDescription_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(90, 17);
            label1.Name = "label1";
            label1.Size = new Size(188, 37);
            label1.TabIndex = 9;
            label1.Text = "Editace práce";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(txtWorkId);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtDescription);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 306);
            panel1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // EditWorkForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(343, 328);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "EditWorkForm";
            Text = "EditWork";
            Load += EditWorkForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
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
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}