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

        private void EditWorkForm_Load(object sender, EventArgs e)
        {
            txtWorkId.TabIndex = 0;
            txtName.TabIndex = 1;
            txtDescription.TabIndex = 2;
            btnSave.TabIndex = 3;
            btnCancel.TabIndex = 4;
            btnCancel.Cursor = Cursors.Hand;
            btnSave.Cursor = Cursors.Hand;
        }
    }
}
