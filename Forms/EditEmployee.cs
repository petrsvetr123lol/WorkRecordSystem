using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkRecordSystem.Classes;

namespace WorkRecordSystem.Forms
{
    public partial class EditEmployee : Form
    {
        private Employee? employee;
        public EditEmployee(Employee? employee)
        {
            InitializeComponent();
            this.employee = employee;
            txtName.Text = employee.FirstName;
            txtSurname.Text = employee.LastName;
            txtEmail.Text = employee.Email;
            txtPhone.Text = employee.PhoneNumber;
            txtRole.Text = employee.RoleName;
            txtPersonalNumber.Text = employee.PersonalNumber.ToString();
            bdayPicker.Value = employee.BirthDate;
            txtPersonalNumber.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlRepo sqlRepository = new SqlRepo();
            if (employee != null)
            {
                var employee = new Employee(Convert.ToInt32(txtPersonalNumber.Text), txtRole.Text, txtName.Text, txtSurname.Text, bdayPicker.Value, txtEmail.Text, txtPhone.Text);
                sqlRepository.EditEmployee(employee);
            }
            DialogResult = DialogResult.OK;
        }
    }
}
