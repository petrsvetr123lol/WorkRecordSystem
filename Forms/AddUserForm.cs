﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
        private User? user;
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" || txtPassword.Text != "")
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
            else
            {
                MessageBox.Show("Musíte zadat požadované hodnoty.");
            }
            DialogResult = DialogResult.OK;

        }
    }
}
