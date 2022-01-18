using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment
{
    class Class1
    {
        public int MathProblem(int x, int y = 5)
        {
            int b = x + y;
            return b;
        }
        public string CheckingUserInfo(int x)
        {
            Class1 class1 = new Class1();
            int UserInput1 = x;
            try
            {
                Console.WriteLine("Enter another number or leave blank");
                int UserInput2 = Convert.ToInt32(Console.ReadLine());
                int ClassOutput = class1.MathProblem(UserInput1, UserInput2);

                string WritetoConsole =  "Adding your numbers " + UserInput1 + " and " + UserInput2 + " equals " + ClassOutput;
                return WritetoConsole;

            }

            catch (FormatException)
            {
                int ClassOutput = class1.MathProblem(x);
                string WritetoConsole = "Adding your numbers " + UserInput1 + " and 5 equals " + ClassOutput;

                return WritetoConsole;

            }
        }
    }

    
}
