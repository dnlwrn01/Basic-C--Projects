using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchProject
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //user user age 
                Console.WriteLine("Enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                //get current year and subtract user age
                int currYear = DateTime.Now.Year;
                int birthYear = (currYear - age);

                //display birth year
                Console.WriteLine("You were born in " + birthYear + ".");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter your age as a whole number.");
            }

            

            Console.Read();



        }
    }
}
