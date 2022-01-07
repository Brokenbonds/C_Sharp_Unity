using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            bool UserStringIndex = false;
            bool UserIntIndex = false;
            bool UserStringIndex2 = false;
            string[] array1 = { "the", "quick", "brown", "fox", "jumped", "over", "the", "lazy", "dog" };
            Console.WriteLine("please choose from an index of 0-8");
            int UserIndex = Convert.ToInt32(Console.ReadLine());
            while (!UserStringIndex)
            {
                if (UserIndex >= 0 && UserIndex <= 8)
                {
                    Console.WriteLine("you have chosen the word \"" + array1[UserIndex] +"\"");
                    Console.ReadLine();
                    UserStringIndex = true;
                }
                else
                {
                    Console.WriteLine("Sorry you need an number between 0-8 \nPlease choose another index");
                    UserIndex = Convert.ToInt32(Console.ReadLine());
                }
            }


            int[] array2 = { 0, 19, 28, 37, 46, 55, 64, 73, 82, 91, 10 };
            Console.WriteLine("please choose from an index of 0-10");
            int UserIndex2 = Convert.ToInt32(Console.ReadLine());
            while (!UserIntIndex)
            {
                if(UserIndex2 >= 0 && UserIndex2 <= 10)
                {
                    Console.WriteLine("you have chosen the number \"" + array2[UserIndex2] + "\"");
                    Console.ReadLine();
                    UserIntIndex = true;
                }
                else
                {
                    Console.WriteLine("Sorry you need an number between 0-10 \nPlease choose another index");
                    UserIndex = Convert.ToInt32(Console.ReadLine());
                }
            }

            List<string> ListOfStrings = new List<string>();
            ListOfStrings.Add("hello");
            ListOfStrings.Add("this");
            ListOfStrings.Add("is");
            ListOfStrings.Add("a");
            ListOfStrings.Add("list");
            ListOfStrings.Add("of");
            ListOfStrings.Add("strings");

            Console.WriteLine("please choose from an index of 0-5");
            int UserIndex3 = Convert.ToInt32(Console.ReadLine());
            while (!UserStringIndex2)
            {
                if (UserIndex3 >= 0 && UserIndex3 <= 5)
                {
                    Console.WriteLine("you have chosen the word \"" + ListOfStrings[UserIndex3] + "\" \nThanks for playing." );
                    Console.ReadLine();
                    UserStringIndex2 = true;
                }
                else
                {
                    Console.WriteLine("Sorry you need an number between 0-10 \nPlease choose another index");
                    UserIndex3 = Convert.ToInt32(Console.ReadLine());
                }
            }







        }
    }
}
