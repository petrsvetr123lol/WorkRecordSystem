using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = sqlRepo.GetUser(txtUsername.Text.Trim());
            if (user != null)
            {
                if (user.VerifyPassword(txtPassword.Text.Trim()))
                {
                    var mainForm = new FormMain(user);
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
    }
}
