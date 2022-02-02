using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    class Employee : Person
    {

        public override void SayName()
        {
            Console.WriteLine("this is your name {0} {1}", firstName, lastName);
        }

        public override void SayName2()
        {
            base.SayName2();
        }
    }
}
