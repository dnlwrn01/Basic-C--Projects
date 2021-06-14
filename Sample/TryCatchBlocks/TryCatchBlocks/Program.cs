using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchBlocks
{
    class Program
    {
        static void Main(string[] args)
        {

            //declare list ints
            List<int> numbers = new List<int>() { 12, 45, 306, 23, 15};
            List<int> results = new List<int>() { };

            //display list to user
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            //prompt for userNum
            Console.WriteLine("Enter a number of your choice and each list item will be divided by it.");



            //try catch for userNum error check
            try
            {
                //get num
                int userNum = Convert.ToInt32(Console.ReadLine());

                //divide and add to new ist
                foreach (int number in numbers)
                {
                    int quotient = (number / userNum);
                    results.Add(quotient);
                }

                //result prompt
                Console.WriteLine("These are the results!");

                //diplay each result
                foreach (int result in results)
                {
                    Console.WriteLine(result);
                }

            }

            //exceptions 
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide numbers by 0.");

            }
            catch (FormatException)
            {
                Console.WriteLine("Not a valid number.");

            }

            Console.WriteLine("DONE!");
            Console.Read();


        }
    }
}
