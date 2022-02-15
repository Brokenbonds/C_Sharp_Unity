using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Player
    {
        public Player(string name, int beginningBalance)
        {
            Hand = new List<Card>)();
            Name = name;
            Balance = beginningBalance;
        }
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }

        public bool Bet(int amount)
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("You do not have enough to make a bet that size");
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }

        //this is overloading an operator, now we can take a game and add a player to it by typeing game += player;
        public static Game operator+ (Game game, Player player)
        {
            //this takes the player class and addes it to the game class.
            game.Players.Add(player);
            //we now return the game.
            return game;
        }

        public static Game operator- (Game game, Player player)
        {
            game.Players.Remove(player);
            return game; 
        }
    }
}
