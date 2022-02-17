using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Current date and time is: " + DateTime.Now);
                Console.WriteLine("Please enter a number");
                double answer = Convert.ToInt32(Console.ReadLine());

                DateTime dateTime = DateTime.Now;
                dateTime = dateTime.AddHours(answer);// could this be writen better?

                Console.WriteLine("your number has been added to the date as hours\nHere is what that time would be\n{0}", dateTime);
                Console.ReadLine();

            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }

        }
    }
}
