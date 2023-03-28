using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkRecordSystem.Classes
{
    public class Work
    {
        public int WorkId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Work(int workId, string name, string description)
        {
            WorkId = workId;
            Name = name;
            Description = description;
        }
        public ListViewItem ToListViewItem()
        {
            return new ListViewItem(new string[] { WorkId.ToString(), Name, Description});
        }
    }
}
