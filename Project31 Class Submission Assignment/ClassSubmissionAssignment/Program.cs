using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Give me you name.");
            string name = Console.ReadLine();
            Class1.SayHi(name);
            Console.ReadLine();

            Class1 class1 = new Class1();
            Console.WriteLine("Hey can I have a number please.");
            int userNum = Convert.ToInt32(Console.ReadLine());
            class1.Divideby2(userNum, out int number);
            Console.WriteLine("Thanks for the number, I'm going to divid it by 2 now");
            Console.WriteLine(number);
            Console.ReadLine();

        }
    }
}
