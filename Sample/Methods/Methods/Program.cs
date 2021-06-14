using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate Math Class
            Math math = new Math();

            //get userNum
            Console.WriteLine("Enter a nuber to multiply/divide or add/subtract 2.");
            int userNum = Convert.ToInt32(Console.ReadLine());

            //perform calculations using methods
            int product = math.MultiplyNum(userNum);
            int quoitent = math.DivideNum(userNum);
            int sum = math.AddNum(userNum);
            int difference = math.SubtractNum(userNum);

            //display results
            Console.WriteLine(userNum + " multiplied by 2 is " + product);
            Console.WriteLine(userNum + " divided by 2 is " + quoitent);
            Console.WriteLine(userNum + " plus 2 is " + sum);
            Console.WriteLine(userNum + " minus 2 is " + difference);


            Console.Read();

        }

        
    }
}
