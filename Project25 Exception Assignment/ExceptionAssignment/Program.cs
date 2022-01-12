using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 5, 9, 10 };
                List<int> numbers = new List<int>();
                numbers.AddRange(array);

                Console.WriteLine("please enter a whole number");
                int UserNumber = Convert.ToInt32(Console.ReadLine());

                foreach (int number in numbers)
                {
                    int divided = number / UserNumber;
                    Console.WriteLine(number + " divided by " + UserNumber + " equals " + divided);
                }
                
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("please don't use zero");
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("please type in an whole number");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
