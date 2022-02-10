using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiated the number struct
            Number number = new Number();
            //made a copy of the number strcut
            Number number1 = number;
            //give both strcuts a decimal number
            number.Amount = 845876.0000m;
            number1.Amount = 4534.125m;
            Console.WriteLine(number1.Amount);
            Console.WriteLine(number.Amount);
            Console.ReadLine();
        }
    }
}
