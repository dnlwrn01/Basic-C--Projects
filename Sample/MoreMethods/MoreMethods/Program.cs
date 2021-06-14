using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the class
            Math math = new Math();

            //user int input/ calc / output
            Console.WriteLine("Enter a number:");
            int userNum = Convert.ToInt32(Console.ReadLine());
            int sum = math.AddNum(userNum);
            Console.WriteLine(sum);

            //user decimal input/ calc / output
            Console.WriteLine("Enter a decimal number:");
            decimal userDecimalNum = Convert.ToDecimal(Console.ReadLine());
            int decimalSum = math.AddNum(userDecimalNum);
            Console.WriteLine(decimalSum);

            //user string input/ calc / output
            Console.WriteLine("Enter a number as a string:");
            string userStringNum = Convert.ToString(Console.ReadLine());
            int stringSum = math.AddNum(userStringNum);
            Console.WriteLine(stringSum);


            Console.Read();
        }
    }
}
