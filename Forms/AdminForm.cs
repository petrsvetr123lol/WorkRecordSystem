using WorkRecordSystem.Classes;
using WorkRecordSystem.Forms;
using System.Collections.Generic;

namespace WorkRecordSystem;

public partial class AdminForm : Form
{

    private bool closeAll;
    private Form startupForm;
    private User user;
    private List<User> users;
    private Employee employee;
    private List<Employee> employees;
    private Work work;
    private List<Work> works;
    private Contract contract;
    private List<Contract> contracts;
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
        listViewUsers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        listViewUsers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        listViewEmployee.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        listViewEmployee.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        listViewWorks.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        listViewWorks.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
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
        LoadWorks();
        LoadUsers();
        LoadContracts();
        timer1.Start();

        lblCountContracts.Text = sqlRepo.ContractCount().ToString();
        lblCountEmployees.Text = sqlRepo.EmployeeCount().ToString();
        lblCountUsers.Text = sqlRepo.UsersCount().ToString();
        lblCountWorks.Text = sqlRepo.WorkCount().ToString();
        lblSumHours.Text = sqlRepo.NumberOfHours().ToString();

    }

    private void btnAddUser_Click(object sender, EventArgs e)
    {
        AddUserForm addUserForm = new AddUserForm();
        var result = addUserForm.ShowDialog();
        if (result == DialogResult.OK)
        {
            LoadUsers();
            lblCountUsers.Text = sqlRepo.UsersCount().ToString();
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
        works = sqlRepo.GetWorks(searchString: txtSearchWork.Text);
        listViewWorks.Items.Clear();
        foreach (var work in works)
        {
            listViewWorks.Items.Add(work.ToListViewItem());
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
            lblCountEmployees.Text = sqlRepo.EmployeeCount().ToString();

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
                lblCountEmployees.Text = sqlRepo.EmployeeCount().ToString();
            }
        }
        else
        {
            MessageBox.Show("Musíte vybrat uživatele ke smazání!");
        }
    }

    private void btnEditEmployee_Click(object sender, EventArgs e)
    {
        if (listViewEmployee.SelectedItems.Count > 0)
        {
            EditEmployee editEmployeeForm = new EditEmployee(employees[listViewEmployee.SelectedIndices[0]]);
            editEmployeeForm.ShowDialog();
        }
        else
        {
            MessageBox.Show("Musíte vybrat zaměstnance k editaci!");
        }
        LoadEmployees();
        lblCountEmployees.Text = sqlRepo.EmployeeCount().ToString();

    }

    private void button9_Click(object sender, EventArgs e)
    {
        AddWorkForm addWorkForm = new AddWorkForm();
        var result = addWorkForm.ShowDialog();
        if (result == DialogResult.OK)
        {
            LoadWorks();
            lblCountWorks.Text = sqlRepo.WorkCount().ToString();

        }
    }

    private void btnEditWork_Click(object sender, EventArgs e)
    {
        if (listViewWorks.SelectedItems.Count > 0)
        {
            EditWorkForm editWorkForm = new EditWorkForm(works[listViewWorks.SelectedIndices[0]]);
            editWorkForm.ShowDialog();
        }
        else
        {
            MessageBox.Show("Musíte vybrat práci k editaci!");
        }
        LoadWorks();
        lblCountWorks.Text = sqlRepo.WorkCount().ToString();

    }

    private void btnDeleteWork_Click(object sender, EventArgs e)
    {
        if (listViewWorks.SelectedItems.Count > 0)
        {
            if (MessageBox.Show("Opravdu chcete smazat vybraného zaměstnance?", "Mazání uživatele", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                sqlRepo.DeleteWork(Convert.ToInt32(listViewWorks.SelectedItems[0].SubItems[0].Text));
                LoadWorks();
                lblCountWorks.Text = sqlRepo.WorkCount().ToString();

            }
        }
        else
        {
            MessageBox.Show("Musíte vybrat uživatele ke smazání!");
        }
    }

    private void txtSearchWork_TextChanged(object sender, EventArgs e)
    {
        LoadWorks();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
    }

    private void btnExport_Click(object sender, EventArgs e)
    {
        using (SaveFileDialog saveFileDialog = new SaveFileDialog())
        {
            saveFileDialog.Filter = "CSV soubory (*.csv)|*.csv";
            saveFileDialog.Title = "Uložit soubor";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    for (int i = 0; i < listViewContracts.Columns.Count; i++)
                    {
                        sw.Write(listViewContracts.Columns[i].Text);
                        if (i < listViewContracts.Columns.Count - 1)
                            sw.Write(";");
                    }
                    sw.WriteLine();

                    foreach (ListViewItem item in listViewContracts.Items)
                    {
                        for (int i = 0; i < item.SubItems.Count; i++)
                        {
                            sw.Write(item.SubItems[i].Text);
                            if (i < item.SubItems.Count - 1)
                                sw.Write(";");
                        }
                        sw.WriteLine();
                    }
                }
            }
        }
    }

    private void txtContractSearch_TextChanged(object sender, EventArgs e)
    {
        LoadContracts();
    }

    private void btnAddContract_Click(object sender, EventArgs e)
    {
        AddContractForm addContractForm = new AddContractForm();
        var result = addContractForm.ShowDialog();
        if (result == DialogResult.OK)
        {
            LoadContracts();
            lblSumHours.Text = sqlRepo.NumberOfHours().ToString();
            lblCountContracts.Text = sqlRepo.ContractCount().ToString();

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
                    lblSumHours.Text = sqlRepo.NumberOfHours().ToString();
                    lblCountContracts.Text = sqlRepo.ContractCount().ToString();
                }
            }

        }
        else
        {
            MessageBox.Show("Musíte vybrat uživatele ke smazání!");
        }
    }
}

