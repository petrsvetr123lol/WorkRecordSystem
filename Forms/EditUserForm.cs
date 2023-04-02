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
            if (txtName.Text != "" || txtPassword.Text != "" || txtPasswordAgain.Text != "")
            {
                if (txtPassword.Text == txtPasswordAgain.Text)
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

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            txtName.TabIndex = 0;
            txtPassword.TabIndex = 1;
            txtPasswordAgain.TabIndex = 2;
            btnSave.TabIndex = 3;
            btnCancel.TabIndex = 4;
            btnSave.Cursor = Cursors.Hand;
            btnCancel.Cursor = Cursors.Hand;
        }
    }
}
