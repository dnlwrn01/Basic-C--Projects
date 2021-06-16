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
            //instantiate classes
            IQuittable employee = new Employee();
            IQuittable person = new Person();

            //calling on object method
            employee.Quit();
            person.Quit();


            Console.Read();

        }
    }
}
