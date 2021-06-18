using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LogFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            //get user num
            Console.Write("Enther a number: ");

            //convert to string
            string number = Convert.ToString(Console.ReadLine());

            //use System.IO to create a file at the given file path as .txt
            //passing in our user number to append to the file.
            File.WriteAllText(@"C:\Users\dnlwr\Desktop\log.txt", number);

            //open file at the given path and read all text entries
            Console.WriteLine(File.ReadAllText(@"C:\Users\dnlwr\Desktop\log.txt"));
            

            Console.Read();

        }
    }
}
