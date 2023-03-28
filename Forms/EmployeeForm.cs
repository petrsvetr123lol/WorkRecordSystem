using WorkRecordSystem.Classes;

namespace WorkRecordSystem.Forms
{
    public partial class EmployeeForm : Form
    {
        private bool closeAll;
        private Employee employee;
        private List<Employee> employees;
        private Work work;
        private List<Work> works;
        SqlRepo sqlRepo = new SqlRepo();
        private Form startupForm;
        private User user;
        public EmployeeForm(User user)
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

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            LoadWorks();
            LoadEmployees();
        }

        private void txtSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void txtSearchWork_TextChanged(object sender, EventArgs e)
        {
            LoadWorks();
        }
    }
}
