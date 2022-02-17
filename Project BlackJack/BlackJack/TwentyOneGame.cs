using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    //the : Game means TewentyOneGame inherits all of Game's Methods
    public class TwentyOneGame : Game, IWalkAway
    {
        public TwentyOneDealer Dealer { get; set; }
        

        //the override keyword satisfise this the abstract method in the game class
        public override void Play()
        {
            Dealer = new TwentyOneDealer();
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Dealer.Deck.Shuffle();
            Console.WriteLine("place your bet!");
            foreach(Player player in Players)
            {
                int bet = Convert.ToInt32(Console.ReadLine());
                bool successfullyBet = player.Bet(bet);

                //short hand for if (successfullyBet == false)
                if (!successfullyBet)
                {
                    return;
                }

                Bets[player] = bet;
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing...");
                foreach(Player player in Players)
                {
                    Console.WriteLine("{0}:", player.Name);
                    Dealer.Deal(player.Hand);
                    if (i == 1)
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        if (blackJack)
                        {
                            Console.WriteLine("BlackJack! {0} wins {1}", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            return;
                        }
                    }
                }
                Console.WriteLine("Dealer:");
                Dealer.Deal(Dealer.Hand);
               if (i == 1)
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer has Black Jack!");
                        foreach(KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }
                        return;
                    }
                }
            }
            foreach (Player player in Players)
            {
                while (!player.Stay)
                {
                    Console.WriteLine("Your Cards are:");
                    foreach(Card card in player.Hand)
                    {
                        Console.WriteLine("{0}",card.ToString());
                    }
                    Console.WriteLine("\n\nHit or Stay");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay")
                    {
                        player.Stay = true;
                        break;
                    }
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand);
                    }
                    bool busted = TwentyOneRules.isBusted(player.Hand);

                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} busted you loose your bet of {1}. Your balance is now {2}", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("do you want to play again?");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes" || answer == "y" || answer == "yeah" || answer == "ya")
                        {
                            player.isActivelyPlaying = true;
                            return;
                        }
                        else
                        {
                            player.isActivelyPlaying = false;
                            return;
                        }
                    }
                }
            }

            Dealer.IsBusted = TwentyOneRules.isBusted(Dealer.Hand);
            Dealer.Stay = TwentyOneRules.shouldDealerStay(Dealer.Hand);

            while (!Dealer.Stay && !Dealer.IsBusted)
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand);
                Dealer.IsBusted = TwentyOneRules.isBusted(Dealer.Hand);
                Dealer.Stay = TwentyOneRules.shouldDealerStay(Dealer.Hand);
            }
            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer is staying");
            }
            if (Dealer.IsBusted)
            {
                Console.WriteLine("Dealer has BUSTED!");
                foreach(KeyValuePair<Player, int> entry in Bets) //looking through the Key Value Pairs of the Bets Dictionary in Games to give all the players there winnings
                {
                    Console.WriteLine("{0} won {1}!", entry.Key, entry.Value);//this is howyou access Key Value Pairs in Dictionary for a console line.
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2); // this is a lambda expression that looks at the name of the List of Players and then contrasts that to the Dictionary and see if it can find a name then adds to the value to the Balnce of that player.
                }
                return;
            }
            foreach(Player player in Players)
            {
                //bool? means that this bool can be null
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);
                if(playerWon == null)
                {
                    Console.WriteLine("PUSH! No one win");
                    player.Balance += Bets[player];
                }
                else if (playerWon == true)
                {
                    Console.WriteLine("{0} won {1}!", player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2);
                    Dealer.Balance -= Bets[player];
                }

                else
                {
                    Console.WriteLine("The dealer wins {0}!", Bets[player]);
                    Dealer.Balance += Bets[player];
                }

                Console.WriteLine("play again?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "ya" || answer == "yeah" || answer == "y")
                {
                    player.isActivelyPlaying = true;
                }
                else
                {
                    player.isActivelyPlaying = false;
                }
            }
            

        }



        public override void ListPlayers()
        {
            Console.WriteLine("21 Players:");
            //base.ListPlayer(); is the same as what is inside of the ListPlayers Method in the Game Class
            base.ListPlayers();
        }
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
