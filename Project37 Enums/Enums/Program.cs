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
                Console.Write("what is the current day of the week\n");
                string UserAnswer = Console.ReadLine().ToLower();
                bool isNumeric = int.TryParse(UserAnswer, out int result);
                if (!isNumeric)
                {
                    DaysoftheWeek today = (DaysoftheWeek)Enum.Parse(typeof(DaysoftheWeek), UserAnswer);
                    Console.WriteLine("Setting today to {0}", today);
                }
                else
                {
                    Console.WriteLine("please enter an actual day of the week");
                }
                
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("please enter an actual day of the week");
            }

            finally
            {
                
                Console.WriteLine("Thank you");
                Console.ReadLine();
            }

        }
        public enum DaysoftheWeek
        {
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday,
            sunday
        }

        public enum UsersAnswerEnum
        {

        }
    }
}

       
