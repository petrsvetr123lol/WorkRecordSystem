using WorkRecordSystem.Classes;

namespace WorkRecordSystem;

public partial class AdminForm : Form
{

    private bool closeAll;
    private Form startupForm;
    private User user;
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

    private void lblUser_Click(object sender, EventArgs e)
    {

    }
}