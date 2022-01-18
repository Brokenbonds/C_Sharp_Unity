using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Console.WriteLine("please enter in a whole number");
            int UserInput1 = Convert.ToInt32(Console.ReadLine());
            string writeThis = class1.CheckingUserInfo(UserInput1);
            Console.WriteLine(writeThis);
            Console.ReadLine();
        }

       
    }
}
