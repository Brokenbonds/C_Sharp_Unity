using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public  class TwentyOneRules
    {
        //create a static dictinary where Face is connected to a int value for score keeping.
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()
        {
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1
        };
        
        // this is our method for checking if we have an Ace and if so, what could the possible outcomes of that be.
        public static int[] GetallPossibleHandValues(List<Card> Hand)
        {
            //This Lambda expresion takes a look at our hand and Counts how many Face.Ace there are in it
            int aceCount = Hand.Count(x => x.Faces == Face.Ace);

            //we create a new array that is 1 + how many Aces are in our hand
            int[] result = new int[aceCount + 1];

            //Lambda expresion .Sum takes each item in the Hand Liste and then Sum it.
            int value = Hand.Sum(x => _cardValues[x.Faces]);
            
            // this sends out the first value if there is an ace in the hand
            result[0] = value;
            // this checks result to see how long it is, if it's only got a 0 position then it ends the method and sends the result.
            if (result.Length == 1)
            {
                return result;
            }
            // this will go through each postion after 0 in the result array and add 10 to it for each Ace.
            for (int i = 1; i < result.Length; i++)
            {
                value += (i * 10);
                result[i] = value;
            }
            return result;
        }

        // this is going to be our method for checking if we have reached black jack
        public static bool CheckForBlackJack(List<Card> Hand)
        {
            int[] possibleValues = GetallPossibleHandValues(Hand);
            //this is a lambda expersion to get the max possible value
            int value = possibleValues.Max();
            if (value == 21) return true;
            else return false;


        }

        public static bool isBusted(List<Card> Hand)
        {
            int value = GetallPossibleHandValues(Hand).Min();
            if (value > 21) return true;
            else return false;
        }

        public static bool shouldDealerStay(List<Card> Hand)
        {
            int[] possibleHandValues = GetallPossibleHandValues(Hand);
            foreach(int value in possibleHandValues)
            {
                if (value > 16 && value < 22)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool? CompareHands(List<Card> PlayersHand , List<Card> DealersHand)
        {
            int[] playerReuslts = GetallPossibleHandValues(PlayersHand);
            int[] dealerResults = GetallPossibleHandValues(DealersHand);

            int playerScore = playerReuslts.Where(x => x < 22).Max(); //lambda expresion look in side the playerResult array and get me the biggest number that is less then 22
            int dealerScore = dealerResults.Where(x => x < 22).Max();

            if (playerScore > dealerScore) return true;
            if (playerScore < dealerScore) return false;
            else return null;
        }
    }
}
