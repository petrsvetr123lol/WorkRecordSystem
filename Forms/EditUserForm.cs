using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkRecordSystem.Forms;
using WorkRecordSystem.Classes;

namespace WorkRecordSystem.Forms
{
    public partial class EditUserForm : Form
    {
        private User? user;
        public EditUserForm(User? user)
        {
            this.user = user;
            InitializeComponent();
            txtName.Enabled = false;
            txtName.Text = user.Name;
            txtName.ReadOnly = true;
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
            if(txtName.Text !="" || txtPassword.Text !="" || txtPasswordAgain.Text !="")
            {
                if(txtPassword.Text == txtPasswordAgain.Text)
                {
                    SqlRepo sqlRepository = new SqlRepo();
                    if (user != null)
                    {
                        user.ChangePassword(txtPassword.Text);
                        sqlRepository.SaveUser(user);
                    }
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Hesla se neshodují! Zadejte je znovu!");
                }
            }
               
            else
            {
                MessageBox.Show("Musíte zadat požadované údaje!");
            }
            
        }
    }
}
