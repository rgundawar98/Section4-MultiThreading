using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section4_Multi_Threading
{
    public class Employeepayroll
    {
        public List<EmpDetails> EmployeeDetails=new List<EmpDetails>();

        public void addEmployeeToPayRoll(List<EmpDetails> EmployeeDetails)
        {
            EmployeeDetails.ForEach(employeedetail =>
            {
                Console.WriteLine("Employee being added:" + employeedetail.Name);
                this.addEmployeeToPayRoll(employeedetail);
                Console.WriteLine("Employee added:" + employeedetail.Name);
            });
        }

        private void addEmployeeToPayRoll(EmpDetails employeedetail)
        {
            EmployeeDetails.Add(employeedetail);
        }

        public void addEmployeeToPayRollListWithThread(List<EmpDetails> EmployeeDetails)
        {
            EmployeeDetails.ForEach(empData =>
            {
                Task thread = new Task(() =>
                {
                    Console.WriteLine("Employee being added:" + empData.Name);
                    this.addEmployeeToPayRoll(empData);
                    Console.WriteLine("Employee added:" + empData.Name);
                });
            });
        }
    }
}
