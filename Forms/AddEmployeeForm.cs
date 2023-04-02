using WorkRecordSystem.Classes;

namespace WorkRecordSystem.Forms
{
    public partial class AddEmployeeForm : Form
    {

        SqlRepo sqlRepo = new SqlRepo();
        private User? user;
        public AddEmployeeForm()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPersonalNumber.Text != "" || txtEmail.Text != "" || txtName.Text != "" || txtPhone.Text != "" || txtRole.Text != "" || txtSurname.Text != "")
            {
                var employee = new Employee(Convert.ToInt32(txtPersonalNumber.Text), txtRole.Text, txtName.Text, txtSurname.Text, bdayPicker.Value, txtEmail.Text, txtPhone.Text);
                sqlRepo.AddEmployee(employee);
            }
            else
            {
                MessageBox.Show("Musíte zadat požadované údaje");
            }
            DialogResult = DialogResult.OK;
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            txtPersonalNumber.TabIndex = 0;
            txtRole.TabIndex = 1;
            txtName.TabIndex = 2;
            txtSurname.TabIndex = 3;
            txtEmail.TabIndex = 4;
            txtPhone.TabIndex = 5;
            bdayPicker.TabIndex = 6;
            btnSave.TabIndex = 7;
            btnCancel.TabIndex = 8;
            btnCancel.Cursor = Cursors.Hand;
            btnSave.Cursor = Cursors.Hand;
        }
    }
}
