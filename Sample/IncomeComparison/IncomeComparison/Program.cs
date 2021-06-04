using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison
{
    class Program
    {
        static void Main()
        {
            //program intro
            Console.WriteLine("Anonymous Income Comparison Program");

            //define weeks in a year
            decimal weeksInYear = 52;

            //person 1 inputs
            Console.WriteLine("\nPerson #1:");
            Console.WriteLine("What is you Hourly Rate?");
            decimal hourlyRate1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("How many hours do you work per week?");
            decimal hoursWorked1 = Convert.ToDecimal(Console.ReadLine());

            //person 2 inputs
            Console.WriteLine("\nPerson #2:");
            Console.WriteLine("What is you Hourly Rate?");
            decimal hourlyRate2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("How many hours do you work per week?");
            decimal hoursWorked2 = Convert.ToDecimal(Console.ReadLine());

            //calc salary 1
            decimal salary1 = (hourlyRate1 * hoursWorked1) * weeksInYear;

            //calc salary 1
            decimal salary2 = (hourlyRate2 * hoursWorked2) * weeksInYear;

            //solve for difference keeping diff. a positive num
            // & salary comparison
            if (salary1 > salary2)
            {
                decimal difference = salary1 - salary2;
                bool salaryOneGreater = true;
                Console.WriteLine("Person 1's Salary is $" + salary1 + " per year.");
                Console.WriteLine("Person 2's Salary is $" + salary2 + " per year.");
                Console.WriteLine("Person 1 is making $" + difference + " more per year.");
                Console.WriteLine("Person 1 is making more money than person 2: " + salaryOneGreater);
            }
            else
            {
                decimal difference = salary2 - salary1;
                bool salaryOneGreater = false;
                Console.WriteLine("Person 1's Salary is $" + salary1 + " per year.");
                Console.WriteLine("Person 2's Salary is $" + salary2 + " per year.");
                Console.WriteLine("Person 2 is making $" + difference + " more per year.");
                Console.WriteLine("Person 1 is making more money than person 2: " + salaryOneGreater);
            }

            //results 
            Console.Read();
            
        }
    }
}
