namespace WorkRecordSystem.Classes
{
    public class Contract
    {
        public int ContractId { get; set; }
        public string Work { get; set; }
        public int EmployeeId { get; set; }
        public int WorkId { get; set; }
        public string EmployeeLastName { get; set; }
        public string CustomerName { get; set; }
        public DateTime DateAdded { get; set; }
        public decimal NumberOfHours { get; set; }

        public Contract(int contractId, string work, string employeeLastName, string customerName, DateTime dateAdded, decimal numberOfHours)
        {
            ContractId = contractId;
            Work = work;
            EmployeeLastName = employeeLastName;
            CustomerName = customerName;
            DateAdded = dateAdded;
            NumberOfHours = numberOfHours;
        }
        public Contract(int employeeId, int workId, string customerName)
        {
            EmployeeId = employeeId;
            WorkId = workId;
            CustomerName = customerName;
        }


        public ListViewItem ToListViewItem()
        {
            return new ListViewItem(new string[] { ContractId.ToString(), Work,  EmployeeLastName, CustomerName, DateAdded.ToString("dd.MM.yyyy"), NumberOfHours.ToString() });
        }

    }
}
