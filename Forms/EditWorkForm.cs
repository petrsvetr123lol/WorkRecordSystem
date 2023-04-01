using WorkRecordSystem.Classes;

namespace WorkRecordSystem.Forms
{

    public partial class EditWorkForm : Form
    {
        private Work work;
        SqlRepo sqlRepo = new SqlRepo();
        public EditWorkForm(Work work)
        {
            this.work = work;
            InitializeComponent();
            txtWorkId.Enabled = false;
            txtWorkId.Text = work.WorkId.ToString();
            txtName.Text = work.Name;
            txtDescription.Text = work.Description;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var work = new Work(Convert.ToInt32(txtWorkId.Text), txtName.Text, txtDescription.Text);
            sqlRepo.EditWork(work);
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
