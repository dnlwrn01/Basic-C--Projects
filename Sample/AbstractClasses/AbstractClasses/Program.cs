using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate employee class
            Employee employee = new Employee();

            //set values
            employee.fName = "Sample";
            employee.lName = "Student";

            //call method
            employee.SayName();


            Console.Read();

        }
    }
}
