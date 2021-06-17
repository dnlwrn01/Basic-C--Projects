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
            //IQuittable employee1 = new Employee();
            //IQuittable employee2 = new Employee();
            //IQuittable person = new Person();

            //calling on object method

            int employee1 = 2021;
            int employee2 = 2021;


            //call on 'override method '==' and print'
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
