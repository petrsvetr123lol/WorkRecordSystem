using WorkRecordSystem.Classes;

namespace WorkRecordSystem.Forms
{
    public partial class UserForm : Form
    {
        private bool closeAll;
        private Employee employee;
        private List<Employee> employees;
        private Work work;
        private List<Work> works;
        private Contract contract;
        private List<Contract> contracts;
        SqlRepo sqlRepo = new SqlRepo();
        private Form startupForm;
        private User user;
        public UserForm(User user)
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
        private void LoadWorks()
        {
            works = sqlRepo.GetWorks(searchString: txtSearchWork.Text);
            listViewWorks.Items.Clear();
            foreach (var work in works)
            {
                listViewWorks.Items.Add(work.ToListViewItem());
            }
        }
        private void LoadEmployees()
        {
            employees = sqlRepo.GetEmployees(searchString: txtSearchEmployee.Text);
            listViewEmployee.Items.Clear();
            foreach (var employee in employees)
            {
                listViewEmployee.Items.Add(employee.ToListViewItem());
            }
        }
        public void LoadContracts()
        {
            contracts = sqlRepo.GetContracts();
            listViewContracts.Items.Clear();
            foreach (var contract in contracts)
            {
                listViewContracts.Items.Add(contract.ToListViewItem());
            }
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            LoadWorks();
            LoadEmployees();
            LoadContracts();
        }

        private void txtSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void txtSearchWork_TextChanged(object sender, EventArgs e)
        {
            LoadWorks();
        }

        private void btnAddContract_Click(object sender, EventArgs e)
        {
            AddContractForm addContractForm = new AddContractForm();
            var result = addContractForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadContracts();
            }
        }

        private void btnDeleteContract_Click(object sender, EventArgs e)
        {

        }

    }
}
