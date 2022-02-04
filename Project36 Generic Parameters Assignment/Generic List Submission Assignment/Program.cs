using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_List_Submission_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> test = new List<string>() { "this", "is", "a", "list"};
            //this instanciates the Employee Object and will be using all generic perameter as a string
            Employee<string> employee = new Employee<string>();

            //this instanciates of an Employee object will use the generic perameter int
            Employee<int> employee1 = new Employee<int>();

            //Creating a List from things from employee, this is a string list.
            var Things = employee.things;
            var Things2 = employee1.things;
            
            Things.Add("watch");
            Things.Add("wallet");
            Things.Add("phone");
            Things.Add("keys");

            Things2.Add(1);
            Things2.Add(2);
            Things2.Add(3);
            Things2.Add(4);


            foreach (string thing in Things)
            {
                Console.WriteLine(thing);
            }

            foreach (int thing in Things2)
            {
                Console.WriteLine(thing);
            }

            Console.ReadLine();
        }
    }
}
