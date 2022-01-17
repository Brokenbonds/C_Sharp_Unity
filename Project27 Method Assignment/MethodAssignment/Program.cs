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
            Console.WriteLine(AddNum = Adding26(number));
            Console.ReadLine();
            Console.WriteLine("Lets take "+number+" and divide it by 7");
            int DivNum = DivideBy7(number);
            int Remain = RemainderBy7(number);
            Console.WriteLine( DivNum + " with a remainder of "+Remain);
            Console.ReadLine();
            Console.WriteLine("and lastly lets multiply " + number + " by 2");
            int MultiNum;
            Console.WriteLine(MultiNum = MultiplyBy2(number));
            Console.ReadLine();

        }

        public static int Adding26(int number)
        {
            number = number + 26;
            return number;
        }

        public static int DivideBy7(int number)
        {
            number = number / 7;
            return number;
        }
        public static int RemainderBy7(int number)
        {
            number = number % 7;
            return number;
        }

        public static int MultiplyBy2(int number)
        {
            number = number * 2;
            return number;
        }
    }
}
