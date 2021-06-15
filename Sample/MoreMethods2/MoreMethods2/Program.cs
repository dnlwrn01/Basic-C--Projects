using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreMethods2
{
    class Program
    {
        static void Main(string[] args)
        {

            Math math = new Math();

            //get user num 1
            Console.WriteLine("Enter a number:");
            int one = Convert.ToInt32(Console.ReadLine());

            //ask for second num
            Console.WriteLine("Enter another number? [y/n]:");
            string secondNum = Convert.ToString(Console.ReadLine());
            int result = 0;
            
            if ((secondNum == "Y") || (secondNum == "y"))
            {
                //get num2
                int two = Convert.ToInt32(Console.ReadLine());
                result = math.AddNum(one, two);
            }
            else if ((secondNum == "N") || (secondNum == "n"))
            {
                result = math.AddNum(one);
            }
            else
            {
                Console.WriteLine("Not an option. Try Again Later.");
            }

            //display result
            Console.WriteLine(result);
            Console.Read();

        }
    }
}
