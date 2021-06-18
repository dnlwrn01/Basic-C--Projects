using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //display the current date and time
            string displayTime = (DateTime.Now.ToString("h:mm:ss tt"));
            string displayDate = (DateTime.Now.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine($"The time is: {displayTime}");
            Console.WriteLine($"Todays Date is: {displayDate}");

            //get userInput
            Console.WriteLine("Enter a number:");
            int userHour = Convert.ToInt32(Console.ReadLine());
            string newTime = DateTime.Now.AddHours(userHour).ToString("h:mm:ss tt");

            Console.WriteLine($"In {userHour} hours, the time will be: {newTime}");



            Console.Read();
        }
    }
}
