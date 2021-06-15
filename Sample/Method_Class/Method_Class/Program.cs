using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate claass
            Math math = new Math();

            //get item cost for user
            Console.WriteLine("FIND WI ITEM COST AFTER TAX: \nWhat is the cost of the item?");
            decimal itemCost = Convert.ToDecimal(Console.ReadLine());

            //pass itemCost + tax percent (by name)
            Math.SalesTax(taxPercent: 5, itemCost);

            Console.Read();
        }
    }
}
