using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaFunctions
{
    public class Employee
    {
        // set properties of employee instance
        public string fName { get; set; }
        public string lName { get; set; }
        public int empID { get; set; }

        //build constructor
        public Employee(string aFName, string aLName, int EmpID)
        {
            fName = aFName;
            lName = aLName;
            empID = EmpID;

        }

    }
}
