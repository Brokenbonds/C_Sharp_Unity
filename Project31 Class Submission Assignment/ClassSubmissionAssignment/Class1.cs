using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    class Class1
    {
        public int numbers;
        //this will take an input of x and then output x
        public void Divideby2(int x, out int number)
        {
            int z = x / 2;
            number = z;
        }

        public void OutPut(out int num, out string thing)
        {
            num = 10;
            thing = "this";
        }

        public void OutPut(int me)
        {
            this.numbers = me;
        }

        public static void SayHi(string name)
        {
            Console.WriteLine("Hello " + name);
        }
    }
}
