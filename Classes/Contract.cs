using System.Data;
using System.Xml.Linq;

namespace WorkRecordSystem.Classes
{
    public class Contract
    {
        public int ContractId { get; set; }
        public string Work { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public string CustomerName { get; set; }
        public DateTime DateAdded { get; set; }
        public int NumberOfHours { get; set; }

        public Contract(int contractId, string work, string employeeFirstName, string employeeLastName, string customerName, DateTime dateAdded, int numberOfHours)
        {
            ContractId = contractId;
            Work = work;
            EmployeeFirstName = employeeFirstName;
            EmployeeLastName = employeeLastName;
            CustomerName = customerName;
            DateAdded = dateAdded;
            NumberOfHours = numberOfHours;
        }
        public ListViewItem ToListViewItem()
        {
            return new ListViewItem(new string[] { ContractId.ToString(), Work, EmployeeFirstName, EmployeeLastName, CustomerName, DateAdded.ToString(), NumberOfHours.ToString() });
        }

    }
}
