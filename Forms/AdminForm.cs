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
}