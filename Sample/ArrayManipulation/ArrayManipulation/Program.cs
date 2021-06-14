using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare array
            string[] names = new string[] {"Dan", "Steve", "John", "Mark" };

            //user input
            Console.WriteLine("What is your last name? \n\nEnter it below:");
            string userLastName = Console.ReadLine();

            //iterate through stringArray and concatenate string to each index
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = (names[i] + " " + userLastName);
                
            }

            //iterate through stringArray and print updated index
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i] + "\n");
            }

            //declare list of cities
            var cities = new List<string>() { "New York", "Chicago", "Portland", "Detroit", "Minneapolis"};

            //set val for loops
            bool search = true;
            bool found = false;

            //loop to continue search
            while (search)
            {
                //user input
                Console.WriteLine("Search a City:");
                string userCity = Console.ReadLine();

                //check if search is in list
                foreach (string city in cities)
                {
                    if (userCity == city)
                    {
                        Console.WriteLine(city);
                        found = true;
                    }
                }

                //check if found or value is not in list
                if (found)
                {
                    search = false;
                }
                else if (!found)
                {
                    Console.WriteLine("This city is not currently in the list. Try Again.");
                    search = true;
                }

            }

            //declare list of names
            var name = new List<string>() { "Tom", "Jeremy", "Barb", "Pam", "Doug", "McHalighey", "Tom" };

            var multiples = new List<string>() { };

            //display prompt
            Console.WriteLine("\nNames:");
            foreach (string i in name)
            {
                Console.WriteLine(i);
            }

            //check if search is in list
            foreach (string i in name)
            {
                foreach (string j in multiples)
                {
                    if (j == i)
                    {
                        Console.WriteLine("Duplicate: " + i + " is a duplicate value.");
                    }

                }
                multiples.Add(i);
            }


            Console.Read();
        }
    }
}
