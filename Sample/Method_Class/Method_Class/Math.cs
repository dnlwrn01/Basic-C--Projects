using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class
{
    class Math
    {
        //find total after sales tax
        public static void SalesTax(decimal taxPercent, decimal itemCost)
        {
            //calc tax and total
            taxPercent = (taxPercent / 100);
            decimal totalTax = taxPercent * itemCost;
            decimal total = totalTax + itemCost;

            //display results
            Console.WriteLine("Item Cost: " + itemCost);
            Console.WriteLine("Tax: " + totalTax);
            Console.WriteLine("Total: " + total);
            return;
        }

    }
}
