using WorkRecordSystem.Classes;
using System.IO;
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
            txtCount.Text = sqlRepo.NumberOfHours().ToString();
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
            contracts = sqlRepo.GetContracts(searchString: txtContractSearch.Text);
            listViewContracts.Items.Clear();
            foreach (var contract in contracts)
            {
                listViewContracts.Items.Add(contract.ToListViewItem());
            }
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            LoadWorks();
            LoadEmployees();
            LoadContracts();
            txtCount.Text = sqlRepo.NumberOfHours().ToString();
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
                txtCount.Text = sqlRepo.NumberOfHours().ToString();

            }
        }

        private void btnDeleteContract_Click(object sender, EventArgs e)
        {

            if (listViewContracts.SelectedItems.Count > 0)
            {
                DateTime date = DateTime.Parse(listViewContracts.SelectedItems[0].SubItems[4].Text);
                if (DateTime.Now.Subtract(date).TotalHours > 24)
                {
                    MessageBox.Show("Kontrakt není možné smazat, protože je starší více než 24 hodin!");
                }
                else
                {
                    if (MessageBox.Show("Opravdu chcete smazat vybraný kontrakt?", "Mazání kontraktu", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        sqlRepo.DeleteContract(Convert.ToInt32(listViewContracts.SelectedItems[0].SubItems[0].Text));
                        LoadContracts();
                        txtCount.Text = sqlRepo.NumberOfHours().ToString();
                    }
                }

            }
            else
            {
                MessageBox.Show("Musíte vybrat uživatele ke smazání!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadContracts();
        }

        private void btnHourEvidention_Click(object sender, EventArgs e)
        {
            if (listViewContracts.SelectedItems.Count > 0)
            {
                decimal hours = Convert.ToDecimal(listViewContracts.SelectedItems[0].SubItems[6].Text);
                hours = hours + numericUpDownHours.Value;
                sqlRepo.AddHours(hours, Convert.ToInt32(listViewContracts.SelectedItems[0].SubItems[0].Text));
                LoadContracts();
                txtCount.Text = sqlRepo.NumberOfHours().ToString();
            }
            else
            {
                MessageBox.Show("Musíte vybrat kontrakt k evidenci hodin");
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
