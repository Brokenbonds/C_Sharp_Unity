using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 thisClass = new Class1();
            int num2 = 32;
            int num3 = thisClass.Adding(num2);
            Console.WriteLine("We just took {0} and added 20 to it to get {1}", num2, num3);
            Console.ReadLine();
            decimal dec1 = Convert.ToDecimal(Math.PI);
            int int1 = thisClass.Adding(dec1);
            Console.WriteLine("We pased int PI, multiplied by 30 and converted it to an Integer. This equals {0}", int1 );
            Console.ReadLine();
            string stringnum = "7";
            int int2 = thisClass.Adding(stringnum);
            Console.WriteLine("we have passed a string with the number {0} and will now multiply it by 5 to make {1}", stringnum, int2);
            Console.ReadLine();



        }
    }
}
