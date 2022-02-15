using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public abstract class Game
    {
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public Dictionary<Player,int> Bets { get; set; }

        //abstract method can only exsit in an abstract class and contains no implimentation, all it does is state any class that inherites this class must have this metheod
        public abstract void Play();

        //a virtual method inside an abstract class gets inherited but has the ability to overite it.
        public virtual void ListPlayers()
        {
            foreach(Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }



    }

}
