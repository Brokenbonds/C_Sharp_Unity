using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    class Employee : Person, IQuittable
    {
        public int EmployeeID { get; set; }
        

        public override void SayName()
        {
            Console.WriteLine("welcome new employee {0} {1}, your employee number is {2}", firstName, lastName, EmployeeID);
        }
        // this pulls from the Person Class, baase.SayName2() is just the code that is in the SayName2() method inside of the Person Class
        public override void SayName2()
        {
            base.SayName2();
            Console.WriteLine("Has been added");
        }

        //calling form the IQuittable Interface
        public void Quit()
        {
            //exit a console application.
            //Environment.Exit(0);
            Console.WriteLine("I'm quitting.");

        }

        public static bool operator== (Employee employee, Employee employee1)
        {
            if (employee.EmployeeID.Equals(employee1.EmployeeID))
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Employee employee, Employee employee1)
        {
            if (!employee.EmployeeID.Equals(employee1.EmployeeID))
            {
                return true;
            }

            return false;
        }



    }
}
