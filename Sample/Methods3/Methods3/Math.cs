using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods3
{
    class Math
    {
        public static void DisplayPrompt(out string name)
        {
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("WELCOME {0}", name);
            Console.WriteLine("Enter a number:");
        }

        public static int Divide(int userNum)
        {
            int result = userNum / 2;
            return result;
        }

        public static int Divide(int userNum, int DivideByNum = 1)
        {
            int result = userNum / DivideByNum;
            return result;
        }

    }
}
