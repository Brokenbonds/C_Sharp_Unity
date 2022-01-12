using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixPartAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 0;
            bool areYouDone = false;
            string[] StringArray = new string[99];
            int[] numbersArray = new int[] { 8, 1, 2, 3, 7, 6, 4, 9, 5, 10 };

            //part1 

            Console.WriteLine("please type something");
            StringArray[0] = "I";
            StringArray[1] = "Think";
            StringArray[2] = "I";
            StringArray[3] = "got";
            StringArray[4] = "it"; 

            for (int i = 5; i <= StringArray.Length; i++)
            {
                string userFirstStringInput = Console.ReadLine();
                StringArray[i] = userFirstStringInput;
                Console.WriteLine("are you done typing? y/n");
                bool getOutOfLoop = false;
                while (!getOutOfLoop)
                {
                    string userAnswer = Console.ReadLine().ToLower();
                    switch (userAnswer)
                    {
                        case "y":
                            Console.WriteLine("thank you.\n");
                            areYouDone = true; //change to false for part2
                            getOutOfLoop = true;

                            break;
                        case "yes":
                            Console.WriteLine("thank you.\n");

                            areYouDone = true; //change to false for part2
                            getOutOfLoop = true;

                            Console.ReadLine();
                            break;
                        case "n":
                            Console.WriteLine("please type something else");
                            getOutOfLoop = true;

                            break;
                        case "no":
                            Console.WriteLine("please type something else");
                            getOutOfLoop = true;

                            break;
                        default:
                            Console.WriteLine("please type yes or no");
                            break;
                    }

                }

                if (areYouDone == true)
                {
                    break;
                }


            }
            Console.WriteLine("Here is all that you have typed:\n");

            for (int i = 0; i < StringArray.Length; i++)
            {
                if (StringArray[i] == null)
                {
                    break;
                }

                Console.WriteLine(StringArray[i]);

            }
            Console.WriteLine("\nPlease press enter to continue.");
            Console.ReadLine();

            // part 2 just change the greater than to less than and it will go forever.

            int forEver = 1;
            for(int i = 0; i > forEver; i++)
            {
                Console.WriteLine(forEver);
                forEver++;
            }


            //part 3

            Console.WriteLine("search through an int Array with numbers 1-10 and print less than 5\nPlease press Enter to proceed.");
            Console.ReadLine();

            for (int i = 0; i < numbersArray.Length; i++)
            {
                if (numbersArray[i] < 5)
                {
                    Console.WriteLine(numbersArray[i]);
                }
            }

            Console.WriteLine("\nNow we search through the Array and print anything equal or less then 7\nPlease press Enter to proceed.");
            Console.ReadLine();

            for (int i = 0; i <= numbersArray.Length; i++)
            {
                if (numbersArray[i] <= 7)
                {
                    Console.WriteLine(numbersArray[i]);
                }
            }

            //Part 4
            List<string> randomStringList = new List<string>() { "tree", "start", "angle", "baby", "jesus", "snow", "ornaments", "turkey", "family", "friends", "stuffing" };
            bool Figuredoutword = false;
            Console.WriteLine("\nI'm thinking of words that has to do with Christmas, guess one");
            while (!Figuredoutword)
            {
                string AnotherUserInput = Console.ReadLine().ToLower();
                for (int i = 0; i < randomStringList.Count; i++)
                {
                    if (AnotherUserInput == randomStringList[i])
                    {
                        Console.WriteLine("congrats on finding " + randomStringList[i] + " please press enter to continue.");
                        Figuredoutword = true;
                        break;
                    }

                }

                if (!Figuredoutword)
                {
                    Console.WriteLine("sorry try again please.");
                }

            }
            Console.ReadLine();

            // Part 5
            List<string> randomStringList2 = new List<string>() { "cup", "bowl", "cup", "bowl", "bottle", "bottle", "bottle", "bottle", "cup", };
            List<string> checkmatches1 = new List<string>();
            Console.WriteLine("Please type cup, bowl, or bottle to see how many duplicates are in a List");
            string checkThis = Console.ReadLine().ToLower();
            List<string> listPositions = new List<string>();
            for (int i = 0; i < randomStringList2.Count; i++)
            {
                if (randomStringList2[i] == checkThis)
                {
                    string intToString = i.ToString();
                    listPositions.Add(intToString);
                }

            }

            Console.WriteLine("the positions of the word " + checkThis + " are ");
            //checks through listPostions where i is the position and iterate till i=> listPostions list length
            listPositions.ForEach(i => Console.Write("{0},", i));
            Console.WriteLine(" please press enter to continue.\n");
            Console.ReadLine();

            //Part6

            List<string> randomStringList3 = new List<string>() { "bat", "bat", "tom", "lamb", "bob", "yellow", "dog", "grey", "dog", };
            List<string> checkForDup = new List<string>();


            Console.WriteLine("This is Part 6, it will now iterate through a List and displays \na message showing the string and whether or not it has already appeared in the list\nPlease press Enter to continue. ");
            Console.ReadLine();




            foreach (string item in randomStringList3)
            {
                Console.WriteLine(item);
                if (!checkForDup.Contains(item))
                {
                    checkForDup.Add(item);
                }
                else
                {
                    Console.WriteLine(item + " has been duplicated, please press Enter to continue");
                }
            }
            Console.ReadLine();


            Console.WriteLine("\nYou are now finished\nPlease press Enter to Exit.");
            Console.ReadLine();
        }
    }
}
