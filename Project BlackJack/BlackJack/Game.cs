using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public abstract class Game
    {
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();
        private List<Player> _players = new List<Player>(); // we do this because we want this list to never be null, we want it to be at least an instanciated empty list. As it is private we use the _player to represent this.
        public List<Player> Players { get { return _players; } set { _players = value; } }
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }

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
