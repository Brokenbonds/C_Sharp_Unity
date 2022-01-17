using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Please give me a number\n");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thank you, now we will Add 26 to " + number);
            int AddNum;
            Console.WriteLine(AddNum = Class1.Adding26(number));
            Console.ReadLine();
            Console.WriteLine("Lets take "+number+" and divide it by 7");
            int DivNum = Class1.DivideBy7(number);
            int Remain = Class1.RemainderBy7(number);
            Console.WriteLine( DivNum + " with a remainder of "+Remain);
            Console.ReadLine();
            Console.WriteLine("and lastly lets multiply " + number + " by 2");
            int MultiNum;
            Console.WriteLine(MultiNum = Class1.MultiplyBy2(number));
            Console.ReadLine();

        }

        
    }
}
