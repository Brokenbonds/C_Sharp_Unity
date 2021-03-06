using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("\r\nWhat is the weight of your package in lbs, please use only numbers");
            double packageWeight = Convert.ToDouble(Console.ReadLine());

            if (packageWeight > 50)
            {

                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("\r\nWhat is your packages width in inches, please use only numbers");
            double packageWidth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\r\nWhat is your packages height in inches, please use only numbers");
            double packageHeight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\r\nWhat is your packages length in inches, please use only numbers");
            double packageLength = Convert.ToDouble(Console.ReadLine());

            
            if (packageHeight + packageLength + packageWidth > 50)
            {

                Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }
            //this equation is not giving me my .00 for the cents. 
            decimal packagePricing = Convert.ToDecimal(((packageHeight * packageLength * packageWidth) * packageWeight) / 100);
            Console.WriteLine("your quote is "+String.Format("{0:C}", packagePricing));
            Console.ReadLine();

        }
    }
}
