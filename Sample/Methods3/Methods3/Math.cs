using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods3
{
    class Math
    {
        public static void DisplayPromt()
        {
            Console.WriteLine("WELCOME TO THIS");
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
