using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constants
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            const string companyName = " "; 
            string admin = "";  //try setting to 'y', 'n', 'or leave blank'

            //instantiate the Person class and pass in args
            Person person = new Person(companyName, admin);

            //display results
            Console.WriteLine(person.CompanyName);
            Console.WriteLine(person.Admin);

            
            Console.Read();
        }


        

        
    }
}
