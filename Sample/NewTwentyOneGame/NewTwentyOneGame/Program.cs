using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.TwentyOne;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Casino. Let's start with you name: ");
            string playerName = Console.ReadLine();

            bool validAnswer = false;
            int bank = 0;
            while (! validAnswer)
            {
                Console.WriteLine("And how much money do you have with you?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
            }


            Console.WriteLine($"Hello, {playerName}. Would you like to join a game of 21?");
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "yeah" || answer == "y")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivleyPlaying = true;

                while (player.isActivleyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thanks for playing!");
            }

            Console.WriteLine("Feel free to look around the casino. Goodbye for now.");
            Console.Read();

        }
    }
}
