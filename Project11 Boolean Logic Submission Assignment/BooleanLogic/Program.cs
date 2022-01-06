using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age? numbers only please.");
            string applicantAgeString = Console.ReadLine();
            int applicantAge = Convert.ToInt32(applicantAgeString);
            Console.WriteLine("Have you ever had a DUI? true or false only please.");
            string applicantDUIstring = Console.ReadLine();
            bool applicantDUI = Convert.ToBoolean(applicantDUIstring);
            Console.WriteLine("How many speeding tickets do you have, numbers only please.");
            string applicantTicketsString = Console.ReadLine();
            int applicantTickets = Convert.ToInt32(applicantTicketsString);

            bool qualificationTest = (applicantAge >15 && applicantDUI == false && applicantTickets <= 3);
            Console.WriteLine("\r\nDoes the applicant qualify for insurance?\r\n" + qualificationTest);
            Console.ReadLine();
            
        }
    }
}
