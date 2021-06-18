using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENums
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // ask for user input
                Console.Write("Enter day of the week:");

                //read input
                string userDay = Convert.ToString(Console.ReadLine()); // = Convert.ToString(Console.ReadLine());

                // instatiating an enam and parsing 
                DaysOfTheWeek daysOfTheWeek = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userDay, true);

                //print result
                Console.WriteLine(daysOfTheWeek);

                Console.Read();
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week (english only).");
            }
            
        }



        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }



    }
}
