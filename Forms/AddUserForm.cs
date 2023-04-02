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
            if (txtName.Text != "" && txtPassword.Text != "" && txtPasswordAgain.Text != "")
            {
                if (txtPassword.Text == txtPasswordAgain.Text)
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
                    MessageBox.Show("Hesla se neshodují! Zadejte je znovu!");
                }

            }
            else
            {
                MessageBox.Show("Musíte zadat požadované hodnoty.");
            }
            DialogResult = DialogResult.OK;

        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            txtName.TabIndex = 0;
            txtPassword.TabIndex = 3;
            txtPasswordAgain.TabIndex = 4;
            comboRole.TabIndex = 2;
            btnSave.TabIndex = 4;
            btnCancel.TabIndex = 5;
            btnSave.Cursor = Cursors.Hand;
            btnCancel.Cursor = Cursors.Hand;
        }

        private void txtPasswordAgain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.PerformClick();
            }
        }
    }
}
