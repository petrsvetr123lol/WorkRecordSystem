using WorkRecordSystem.Classes;
namespace WorkRecordSystem.Forms
{
    public partial class AddContractForm : Form
    {
        SqlRepo sqlRepo = new SqlRepo();
        private Contract? contract;
        public AddContractForm()
        {

            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnCreateContract_Click(object sender, EventArgs e)
        {
            if (txtCustomer.Text != "" || txtEmployeeId.Text != "" || txtWorkId.Text != "")
            {
                Contract contract = new Contract(Convert.ToInt32(txtEmployeeId.Text), Convert.ToInt32(txtWorkId.Text), txtCustomer.Text);
                sqlRepo.AddContract(contract);
            }
            else
            {
                MessageBox.Show("Musíte zadat požadované hodnoty!");
            }
            DialogResult = DialogResult.OK;
            ;
        }

        private void AddContractForm_Load(object sender, EventArgs e)
        {

        }
    }
}
