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
using WorkRecordSystem.Forms;

namespace WorkRecordSystem
{
    public partial class FormLogin : Form
    {
        SqlRepo sqlRepo;
        User user;
        public FormLogin()
        {
            InitializeComponent();
            sqlRepo = new SqlRepo();
            sqlRepo.ConvertUsersToHashed();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = sqlRepo.GetUser(txtUsername.Text.Trim());
            if (user != null)
            {
                if (user.VerifyPassword(txtPassword.Text.Trim()))
                {
                  
                }

                if (user.Role == "admin")
                {
                    var mainForm = new AdminForm(user);
                    mainForm.Show(this);
                    txtPassword.Text = "";
                    txtUsername.Text = "";
                    Hide();
                    return;
                }
                else
                {
                    var mainForm = new EmployeeForm(user);
                    mainForm.Show(this);
                    txtPassword.Text = "";
                    txtUsername.Text = "";
                    Hide();
                    return;
                }
            }
            MessageBox.Show("Uživatelské jméno nebo heslo není správné");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
