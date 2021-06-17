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
            IQuittable employee1 = new Employee();
            IQuittable employee2 = new Employee();
            IQuittable person = new Person();

            //calling on object method
            employee1.Quit();
            employee2.Quit();

            //call on 'override method '==' amd print'
            if (employee1 == employee2)
            {
                Console.WriteLine("EMPLOYEE ID'S ARE EQUAL");
            }
            else
            {
                Console.WriteLine("EMPLOYEE ID'S ARE NOT EQUAL");
            }

            Console.Read();

        }
    }
}
