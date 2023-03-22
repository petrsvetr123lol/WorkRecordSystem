using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkRecordSystem.Forms
{
    public partial class EditUserForm : Form
    {
        public EditUserForm(string name)
        {
            this.Name = name;
            InitializeComponent();
            txtName.Enabled = false;
            txtName.Text = name;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
