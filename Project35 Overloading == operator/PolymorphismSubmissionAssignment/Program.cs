using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Employee employee1 = new Employee();
            IQuittable quittingTime = new Employee();

            employee.firstName = "Sample";
            employee.lastName = "Student";
            employee.EmployeeID = 1;
            employee.SayName2();
            employee1.firstName = "Bob";
            employee1.lastName = "Man";
            employee1.EmployeeID = 1;
            employee1.SayName2();
            quittingTime.Quit();
            Console.ReadLine();
            Console.WriteLine("Now to check if there are any ID issues so far");
            if (employee == employee1)
            {
                Console.WriteLine("Something is wrong please change the ID's of either {0} {1} or {2} {3}", employee.firstName, employee.lastName, employee1.firstName, employee1.lastName);
            }

            if (employee != employee1)
            {
                Console.WriteLine("Everything looks fine");
            }
            Console.ReadLine();

            

        }
    }
}
