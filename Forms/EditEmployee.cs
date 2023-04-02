using WorkRecordSystem.Classes;

namespace WorkRecordSystem.Forms
{
    public partial class EditEmployee : Form
    {
        private Employee? employee;
        public EditEmployee(Employee? employee)
        {
            InitializeComponent();
            this.employee = employee;
            txtName.Text = employee.FirstName;
            txtSurname.Text = employee.LastName;
            txtEmail.Text = employee.Email;
            txtPhone.Text = employee.PhoneNumber;
            txtRole.Text = employee.RoleName;
            txtPersonalNumber.Text = employee.PersonalNumber.ToString();
            bdayPicker.Value = employee.BirthDate;
            txtPersonalNumber.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlRepo sqlRepository = new SqlRepo();
            if (employee != null)
            {
                var employee = new Employee(Convert.ToInt32(txtPersonalNumber.Text), txtRole.Text, txtName.Text, txtSurname.Text, bdayPicker.Value, txtEmail.Text, txtPhone.Text);
                sqlRepository.EditEmployee(employee);
            }
            DialogResult = DialogResult.OK;
        }

        private void EditEmployee_Load(object sender, EventArgs e)
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
