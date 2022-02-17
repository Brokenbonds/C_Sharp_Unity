using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Lets get started by telling me your name");
            string playername = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello {0}. Would you like to play a game of 21 right now?",playername);
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "ya" || answer == "y" || answer == "sure" || answer =="yeah")
            {
                Player player = new Player(playername, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while(player.isActivelyPlaying == true && player.Balance > 0)
                {
                    game.Play();
                }
                //when the player exits the game
                game -= player;
                Console.WriteLine("thank you for playing");
            }

            Console.WriteLine("Feel free to look around the casino, bye for now.");
            Console.ReadLine();
        }
    }
}
