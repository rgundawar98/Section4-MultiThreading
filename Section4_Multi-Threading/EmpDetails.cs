using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section4_Multi_Threading
{
    public class EmpDetails
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public string Address { get; set; }
        public string JobDescription { get; set; }

        public EmpDetails(string Name, string Department,string Address,string JobDesription) 
        {
            this.Name = Name;
            this.Department = Department;
            this.Address = Address;
            this.JobDescription = JobDesription;
        }
    }
}
