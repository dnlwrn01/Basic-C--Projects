using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Employee<string> employee1 = new Employee<string>();
            employee1.things = new List<string>() { "cat", "dog", "fish"};

            Employee<int> employee2 = new Employee<int>();
            employee2.things = new List<int>() { 1, 5, 2, 8 };

            for (int i = 0; i < employee2.things.Count; i++)
            {
                Console.WriteLine(employee2.things[i]);
            }

            Console.Read();
        }
    }
}
