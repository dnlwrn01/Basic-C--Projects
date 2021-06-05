using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsPractice
{
    class Program
    {
        static void Main()
        {
            bool playAgain = true;

            while (playAgain)
            {
                //get random number
                Random rnd = new Random();
                int secretNum = rnd.Next(1, 100);

                //display greeting
                Console.WriteLine("Can you guess my number? [1-100]\n\nEnter your Guess:");
                int number = Convert.ToInt32(Console.ReadLine());

                do
                {

                    if (number < secretNum)
                    {
                        Console.WriteLine("Your number was too low.");
                    }
                    else if (number > secretNum)
                    {
                        Console.WriteLine("Your number was too high.");
                    }

                    Console.WriteLine("\n\n Try Again? [1-100]\n\nEnter your Guess:");
                    number = Convert.ToInt32(Console.ReadLine());
                }

                while (secretNum != number);

                Console.WriteLine("Congrats! You guessed " + number + " and the computers number was " + secretNum + "! \nYOU WON!");

                bool askForReplay = true;

                while (askForReplay)
                {
                    //ask to play again
                    Console.WriteLine("Would you like to play again? [Y/N]");
                    string replay = Convert.ToString(Console.ReadLine());

                    if ((replay == "Y") || (replay == "y"))
                    {
                        playAgain = true;
                        askForReplay = false;
                    }
                    else if ((replay == "N") || (replay == "n"))
                    {
                        playAgain = false;
                        askForReplay = false;
                        Console.WriteLine("Thanks for Playing!");
                    }
                    else
                    {
                        Console.WriteLine("Please enter a \"Y\" for yes or an \"N\" for no. ");
                    }
                }
            }
            Console.Read();
        }
    }
}
