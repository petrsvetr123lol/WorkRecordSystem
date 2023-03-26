using WorkRecordSystem.Classes;
using WorkRecordSystem.Forms;

namespace WorkRecordSystem;

public partial class AdminForm : Form
{

    private bool closeAll;
    private Form startupForm;
    private User user;
    private List<User> users;
    SqlRepo sqlRepo = new SqlRepo();
    public AdminForm(User user)
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

    private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
    {
        if (startupForm != null && closeAll)
        {
            startupForm.Close();
        }
    }
    private void LoadData()
    {
        users = sqlRepo.GetUsers();
        listViewUsers.Items.Clear();
        foreach (var user in users)
        {
            listViewUsers.Items.Add(user.ToListViewItem());
        }

    }

    private void lblUser_Click(object sender, EventArgs e)
    {
        LoadData();
    }

    private void AdminForm_Load(object sender, EventArgs e)
    {
        LoadData();
    }

    private void btnAddUser_Click(object sender, EventArgs e)
    {
        AddUserForm addUserForm = new AddUserForm();
        var result = addUserForm.ShowDialog();
        if (result == DialogResult.OK)
        {
            LoadData();
        }
    }

    private void btnDeleteUser_Click(object sender, EventArgs e)
    {
        if (listViewUsers.SelectedItems.Count > 0)
        {
            if (MessageBox.Show("Opravdu chcete smazat vybraného uživatele?", "Mazání uživatele", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                sqlRepo.DeleteUser(listViewUsers.SelectedItems[0].SubItems[0].Text);
                LoadData();
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
}
