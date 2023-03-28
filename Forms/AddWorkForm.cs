using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkRecordSystem.Classes;

namespace WorkRecordSystem.Forms
{
    public partial class AddWorkForm : Form
    {
        private Work work;
        SqlRepo sqlRepo = new SqlRepo();
        public AddWorkForm()
        {
            InitializeComponent();
        }

        private void AddWorkForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" || txtDescription.Text != "" || txtWorkId.Text != "")
            {
                var work = new Work(Convert.ToInt32(txtWorkId.Text), txtName.Text, txtDescription.Text);
                sqlRepo.AddWork(work);
            }
            else
            {
                MessageBox.Show("Musíte zadat požadované hodnoty.");
            }
            DialogResult = DialogResult.OK;
        }
    }
}
