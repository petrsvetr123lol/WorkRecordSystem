using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WorkRecordSystem.Classes
{
    public class Employee
    {
        public int PersonalNumber { get; set; }
        public string RoleName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public Employee(int pNumber, string rName, string fName, string lName, DateTime bDate, string email, string phoneNumber)
        {
            PersonalNumber = pNumber;  
            RoleName = rName;
            FirstName = fName;
            LastName = lName;
            BirthDate = bDate;
            Email = email;
            PhoneNumber = phoneNumber;
        }
        public ListViewItem ToListViewItem()
        {
            return new ListViewItem(new string[] { PersonalNumber.ToString(),RoleName,FirstName,LastName, BirthDate.Date.ToString(),Email,PhoneNumber  });
        }

    }
}
