using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Concatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            //inputs
            Console.WriteLine("What is your first name?");
            string fName = Console.ReadLine();
            Console.WriteLine("What is your middle name?");
            string mName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lName = Console.ReadLine();
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your favorite hobby? (1/3)");
            StringBuilder bio = new StringBuilder(Console.ReadLine() + ", ");
            Console.WriteLine("What is your favorite hobby? (2/3)");
            bio.Append(Console.ReadLine() + ", ");
            Console.WriteLine("What is your favorite hobby? (3/3)");
            bio.Append("& " + Console.ReadLine() + ".");

            //string manipulation
            string fullName = (fName + " " + mName + " " + lName);
            string initials = fName.Substring(0, 1) + lName.Substring(0, 1);
            initials = initials.ToUpper();

            //display results
            Console.WriteLine("\n\nName: " + fullName + "\nInitials: " + initials + "\nAge:" + age + "\nHobbies Include: " + bio);

            Console.Read();
        }
    }
}
