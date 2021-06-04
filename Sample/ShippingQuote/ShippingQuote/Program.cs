using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuote
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the weight of the package:");
            decimal packageWeight = Convert.ToDecimal(Console.ReadLine());

            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                //get dimentions 
                Console.WriteLine("Please enter the width of the package:");
                decimal packageWidth = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Please enter the height of the package:");
                decimal packageHeight = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Please enter the length of the package:");
                decimal packageLength = Convert.ToDecimal(Console.ReadLine());

                decimal dementionsSum = packageWidth + packageHeight + packageLength;

                if (dementionsSum > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    decimal dementionsTotal = packageWidth * packageHeight * packageLength;
                    decimal quoteTotal = (dementionsTotal * packageWeight) / 100;

                    Console.WriteLine("Your estimated total shipping cost is: $" + quoteTotal + "! \nThank You!");
                    Console.Read();
                }
            }
            Console.Read();
        }
    }
}
