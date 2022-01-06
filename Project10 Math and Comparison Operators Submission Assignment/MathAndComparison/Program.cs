using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparison
{
    class Program
    {
        static void Main()

        {
            
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("\r\nPerson1");
            Console.WriteLine("\r\n Please input your hourly rate, numbers only: ");
            string p1HourlyRateString = Console.ReadLine();
            decimal p1HourlyRate = Convert.ToDecimal(p1HourlyRateString);
            Console.WriteLine("\r\nPlease input your Hours worked this week, numbers only, keep to 15min intervals: ");
            string p1HoursInWeekString = Console.ReadLine();
            decimal p1HoursInWeek = Convert.ToDecimal(p1HoursInWeekString);

            Console.WriteLine("\r\nPerson2");
            Console.WriteLine("\r\n Please input your hourly rate, numbers only: ");
            string p2HourlyRateString = Console.ReadLine();
            decimal p2HourlyRate = Convert.ToDecimal(p2HourlyRateString);
            Console.WriteLine("\r\nPlease input your Hours worked this week, numbers only, keep to 15min intervals: ");
            string p2HoursInWeekString = Console.ReadLine();
            decimal p2HoursInWeek = Convert.ToDecimal(p2HoursInWeekString);

            Console.WriteLine("\r\nAnnual salary of Person 1: ");
            decimal p1AnnualSalary = 52 * p1HoursInWeek * p1HourlyRate;
            Console.Write(p1AnnualSalary);

            Console.WriteLine("\r\n \r\nAnnual salary of Person 2: ");
            decimal p2AnnualSalary = 52 * p2HoursInWeek * p2HourlyRate;
            Console.Write(p2AnnualSalary);

            Console.WriteLine("\r\n \r\nDoes Person 1 make more money than Person 2?");
            bool whoMakesMore = p1AnnualSalary > p2AnnualSalary;
            Console.WriteLine(whoMakesMore);

            Console.ReadLine();


        }
    }
}
