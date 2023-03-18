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
    public partial class EmployeeForm : Form
    {
        private bool closeAll;
        private Form startupForm;
        private User user;
        public EmployeeForm(User user)
        {
            closeAll = true;
            this.user = user;
            InitializeComponent();
            lblUser.Text = user.Name;
        }
        public void Show(Form startupForm)
        {
            this.startupForm = startupForm;
            Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            closeAll = false;
            startupForm.Show();
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
