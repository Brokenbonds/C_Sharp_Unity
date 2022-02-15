using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();
            for(int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4 ; j++)
                {
                    Card card = new Card();
                    card.Faces = (Face)i; //you can cast an enum as an int, but you can cast an int to the enum. By putting Face in brackest we are saying we are castin too Face what ever j is.
                    card.Suits = (Suit)j; //here we can see the implimentation and difference between the names of the Enum and the Property.
                    Cards.Add(card); //here we add to the list the card we just made.   
                }
            }
        }
        public List<Card> Cards { get; set; }

        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                this.Cards = TempList;

            }
        }
    }
}
