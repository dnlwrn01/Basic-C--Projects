using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsurance
{
    class Program
    {
        static void Main()
        {
            //program loop
            bool runAgain = true;
            while (runAgain) {

                //program intro
                Console.WriteLine("Welcome to [Car Insurance Company Here]");
                Console.WriteLine("Check your coverage now!");

                //user input
                Console.WriteLine("\nWhat is your age?");
                int userAge = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Have you ever had a DUI or OWI? [Enter \"True\" or \"False\"]");
                bool DUI = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine("How many speeding tickets do you have?");
                int speedingTicket = Convert.ToInt32(Console.ReadLine());

                //check
                bool qualifies = ((userAge > 15) && (DUI == false) && (speedingTicket < 3));

                //display result if user qualifies for insurance
                if (qualifies)
                {
                    Console.WriteLine("Congradulations! You have been approved. Our team will contact you soon for more pricing information.");
                }
                else
                {
                    Console.WriteLine("Unfortunately, you could not be approved at this time. If you believe this is a mistake, please call our offices.");
                }

                //run again
                Console.WriteLine("Would you like to check coverage for another driver? \n[Enter \"Y\" / \"y\" or \"N\" / \"n\"]");
                string newEnrty = Console.ReadLine();
                if ((newEnrty == "Y") || (newEnrty == "y"))
                {
                    runAgain = true;
                }
                else if ((newEnrty == "N") || (newEnrty == "n"))
                {
                    runAgain = false;
                }
                else
                {
                    Console.WriteLine("Please try again later.");
                }

            }
            Console.Read();
        }
    }
}
