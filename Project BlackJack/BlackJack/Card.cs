using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public struct Card
    {
        public Suit Suits { get; set; }// set our property to be a public enum called Suit, named Suit.
        public Face Faces { get; set; }// set our property to be a putlic enum called Face, named Face.
        
        public override string ToString()//here we ovrride a Built-In-Method ToString() giving it a new implementation that can be inhereted from the Card class
        {
            return string.Format("{0} of {1} ", Faces, Suits);
        }
    }

    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }

    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
