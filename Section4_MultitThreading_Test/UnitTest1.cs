using Microsoft.VisualStudio.TestTools.UnitTesting;
using Section4_Multi_Threading;
using System.Collections.Generic;

namespace Section4_MultitThreading_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given_Employee_When_Added_To_List()
        {
            List<EmpDetails>  empDetails = new List<EmpDetails>();
            empDetails.Add(new EmpDetails("John", "IT", "Hog Street", "Tester"));
            empDetails.Add(new EmpDetails("Becky", "Traveller", "Boston", "Traveller"));
            empDetails.Add(new EmpDetails("Mike", "Hiker", "Boston", "HR"));
            empDetails.Add(new EmpDetails("Hitesh", "IT", "Street", "Developer"));
            empDetails.Add(new EmpDetails("Nita", "School", "steert", "Teacher"));

            Employeepayroll employeepayroll= new Employeepayroll();
           // employeepayroll.addEmployeeToPayRoll(empDetails);   
           employeepayroll.addEmployeeToPayRollListWithThread(empDetails);
        }
    }
}
