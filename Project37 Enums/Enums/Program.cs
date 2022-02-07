using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DayOfWeek today = DayOfWeek.Wednesday;

                Console.Write("what is the current day of the week\ntoday is {0}\n", today);
                string UserAnswer = Console.ReadLine();
                

                if (UserAnswer.Equals(Convert.ToString(today)))
                {
                    Console.WriteLine("This is correct");
                    Console.ReadLine();
                    Environment.Exit(0);
                } 
            }
            finally
            {
                Console.WriteLine("please enter an actual day of the week");
                Console.ReadLine();
            }

        }
        public enum DaysoftheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}

       
