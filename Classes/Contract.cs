using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkRecordSystem.Classes
{
    public class Contract
    {
        public int ContractId { get; set; }
        public int Work { get; set; }
        public int Employee { get; set; }
        public string CustomerName { get; set; }

        public Contract(int contractId, int work, int employee, string customerName)
        {
            ContractId = contractId;
            Work = work;
            Employee = employee;
            CustomerName = customerName;
        }

    }
}
