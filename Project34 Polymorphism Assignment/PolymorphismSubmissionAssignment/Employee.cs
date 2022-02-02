using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("this is your name {0} {1}", firstName, lastName);
        }

        public override void SayName2()
        {
            base.SayName2();
        }

        public void Quit()
        {
            //exit a console application.
            //Environment.Exit(0);
            Console.WriteLine("I'm quitting.");

        }
    }
}
