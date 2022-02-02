using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }


        //abstract method can only exsit in an abstract class and contains no implimentation, all it does is state any class that inherites this class must have this metheod
        public abstract void SayName();

        //a virtual method inside an abstract class gets inherited but has the ability to overite it.
        public virtual void SayName2()
        {
            Console.WriteLine("This is your name {0} {1}", firstName, lastName);
        }
        

    }
}
