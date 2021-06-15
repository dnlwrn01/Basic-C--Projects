using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods3
{
    class Program
    {
        static void Main(string[] args)
        {

            Math math = new Math();

            Console.WriteLine("What is your name?");
            string name;

            Math.DisplayPrompt(out name);

            int userNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Would you like to divide this number by anything other than '2'? ['Y' / 'N']");
            string secondNum = Convert.ToString(Console.ReadLine());

            int result = 0;

            if ((secondNum == "y") || (secondNum == "Y"))
            {
                Console.WriteLine("Enter that number:");
                int userNum2 = Convert.ToInt32(Console.ReadLine());
                result = Math.Divide(userNum, userNum2);
            }
            else if ((secondNum == "n") || (secondNum == "N"))
            {
                result = Math.Divide(userNum);
            }
            else
            {
                Console.WriteLine("This is not an option. Try Again later.");
            }

            Console.WriteLine(result);

            Console.Read();
        }
    }
}
