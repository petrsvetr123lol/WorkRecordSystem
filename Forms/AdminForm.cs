using WorkRecordSystem.Classes;
using WorkRecordSystem.Forms;

namespace WorkRecordSystem;

public partial class AdminForm : Form
{

    private bool closeAll;
    private Form startupForm;
    private User user;
    private List<User> users;
    private Employee employee;
    private List<Employee> employees;
    SqlRepo sqlRepo = new SqlRepo();
    public AdminForm(User user)
    {
        closeAll = true;
        this.user = user;
        InitializeComponent();
        lblUser.Text = user.Name;
        txtSearchUser.Text = "";


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

    private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
    {
        if (startupForm != null && closeAll)
        {
            startupForm.Close();
        }
    }
    private void LoadUsers()
    {
        users = sqlRepo.GetUsers(searchString: txtSearchUser.Text);
        listViewUsers.Items.Clear();
        foreach (var user in users)
        {
            listViewUsers.Items.Add(user.ToListViewItem());
        }

    }

    private void lblUser_Click(object sender, EventArgs e)
    {
        LoadUsers();
    }

    private void AdminForm_Load(object sender, EventArgs e)
    {
        LoadEmployees();
        LoadUsers();
    }

    private void btnAddUser_Click(object sender, EventArgs e)
    {
        AddUserForm addUserForm = new AddUserForm();
        var result = addUserForm.ShowDialog();
        if (result == DialogResult.OK)
        {
            LoadUsers();
        }
    }

    private void btnDeleteUser_Click(object sender, EventArgs e)
    {
        if (listViewUsers.SelectedItems.Count > 0)
        {
            if (MessageBox.Show("Opravdu chcete smazat vybraného uživatele?", "Mazání uživatele", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                sqlRepo.DeleteUser(listViewUsers.SelectedItems[0].SubItems[0].Text);
                LoadUsers();
            }
        }
        else
        {
            MessageBox.Show("Musíte vybrat uživatele ke smazání!");
        }
    }

    private void btnEditUser_Click(object sender, EventArgs e)
    {
        if (listViewUsers.SelectedItems.Count > 0)
        {
            EditUserForm editUserForm = new EditUserForm(users[listViewUsers.SelectedIndices[0]]);
            editUserForm.ShowDialog();
        }
        else
        {
            MessageBox.Show("Musíte vybrat uživatele k editaci!");
        }

    }

    private void button1_Click(object sender, EventArgs e)
    {

    }

    private void txtSearchUser_TextChanged(object sender, EventArgs e)
    {
        LoadUsers();
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
    private void LoadWorks()
    {

    }

    private void txtSearchEmployee_TextChanged(object sender, EventArgs e)
    {
        LoadEmployees();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        AddEmployeeForm addEmployeeForm = new AddEmployeeForm();
        var result = addEmployeeForm.ShowDialog();
        if (result == DialogResult.OK)
        {
            LoadEmployees();
        }
    }

    private void btnDeleteEmployee_Click(object sender, EventArgs e)
    {
        if (listViewEmployee.SelectedItems.Count > 0)
        {
            if (MessageBox.Show("Opravdu chcete smazat vybraného zaměstnance?", "Mazání uživatele", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                sqlRepo.DeleteEmployee(Convert.ToInt32(listViewEmployee.SelectedItems[0].SubItems[0].Text));
                LoadEmployees();
            }
        }
        else
        {
            MessageBox.Show("Musíte vybrat uživatele ke smazání!");
        }
    }
}
