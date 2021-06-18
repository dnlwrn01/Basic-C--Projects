using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaFunctions
{
    class Program
    {
        static void Main(string[] args)

        {
            //declare new list
            List<Employee> employee= new List<Employee>();

            //add objects
            employee.Add( new Employee("Dan", "Smith", 1) );
            employee.Add( new Employee("Shelly", "Jones", 2) );
            employee.Add( new Employee("Joe", "Davis", 3) );
            employee.Add( new Employee("Wanda", "Thomas", 4) );
            employee.Add( new Employee("Kevin", "Kennedy", 5) );

            employee.Add( new Employee("Jan", "Obama", 6) );
            employee.Add( new Employee("Jackie", "Biden", 7) );
            employee.Add( new Employee("Joe", "Stevenson", 8) );
            employee.Add( new Employee("Amy", "Lincoln", 9) );
            employee.Add( new Employee("Mike", "Jefferson", 10) );

            //list of joes
            List<Employee> joes = new List<Employee>();

            //add employees named joe to new list
            foreach ( Employee i in employee )
            {
                if (i.fName == "Joe")
                {
                    joes.Add(i);
                }
                
            }

            //display each joe from joes list
            foreach (Employee joe in joes)
            {
                Console.WriteLine(joe.fName + " " + joe.lName + " " + joe.empID);
            }

            //list of joes2
            List<Employee> joesList = new List<Employee>();

            foreach (Employee j in employee.Where(x => x.fName == "Joe"))
            {
                joesList.Add(j);
            }
            
            Console.WriteLine(joesList.Count());

            foreach(Employee joe in joesList)
            {
                Console.WriteLine(joe.fName + " " + joe.lName + " " + joe.empID);
            }

            //list of empID's over 5
            List<Employee> higherClearance = new List<Employee>();

            foreach (Employee j in employee.Where(x => x.empID > 5))
            {
                higherClearance.Add(j);
            }

            Console.WriteLine(higherClearance.Count());

            foreach (Employee ID in higherClearance)
            {
                Console.WriteLine(ID.fName + " " + ID.lName + " " + ID.empID);
            }


            Console.Read();
        }
    }
}
