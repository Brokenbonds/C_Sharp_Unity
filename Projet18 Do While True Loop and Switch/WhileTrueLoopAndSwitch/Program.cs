using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileTrueLoopAndSwitch
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter your a name I like, Either Dave, Bob, or Martha");
            string name = Console.ReadLine();
            bool firstTime = false;
            while (!firstTime)
            {
                switch (name)
                {
                    case "Dave":
                        Console.WriteLine("Oh, nice! you choose Dave");
                        Console.ReadLine();
                        firstTime = true;
                        break;
                    case "Bob":
                        Console.WriteLine("Oh, nice! you choose Bob");
                        Console.ReadLine();
                        firstTime = true;
                        break;
                    case "Martha":
                        Console.WriteLine("Oh, nice! you choose Dave");
                        Console.ReadLine();
                        firstTime = true;
                        break;
                    default:
                        Console.WriteLine("Sorry I'm going to need Dave, Bob, or Martha");
                        name = Console.ReadLine();
                        break;
                }
            }

            Console.WriteLine("Now try to guess a number between 1 and 100, hint it's 12");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = userNumber == 12;
            // this is the same as (isGuessed == false)

            do
            {
                switch (userNumber)
                {
                    case 55:
                        Console.WriteLine("you guessed 55 try again");
                        Console.WriteLine("guess a number between 1 and 100");
                        userNumber = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 62:
                        Console.WriteLine("you guessed 62 try again");
                        Console.WriteLine("guess a number between 1 and 100");
                        userNumber = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("you guessed 29 try again");
                        Console.WriteLine("guess a number between 1 and 100");
                        userNumber = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("you guessed the number 12. That is correct!");
                        Console.ReadLine();
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("Sorry,try again");
                        Console.WriteLine("guess a number between 1 and 100");
                        userNumber = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);

        }
    }
}
