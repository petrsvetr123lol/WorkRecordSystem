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
    public partial class AddUserForm : Form
    {
        SqlRepo sqlRepo = new SqlRepo();
        User user;
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (comboRole.SelectedIndex == 0)
            {
                string role = "admin";
                user = new User(txtName.Text.Trim(), txtPassword.Text.Trim(), role);
                sqlRepo.AddUser(user);
            }
            else 
            {
                string role = "user";
                user = new User(txtName.Text.Trim(), txtPassword.Text.Trim(), role);
                sqlRepo.AddUser(user);
            }
        }
    }
}
