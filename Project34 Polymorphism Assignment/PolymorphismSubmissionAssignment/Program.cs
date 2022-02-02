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
            IQuittable quittingTime = new Employee();

            employee.firstName = "Sample";
            employee.lastName = "Student";
            employee.SayName();
            quittingTime.Quit();
            Console.ReadLine();
            



        }
    }
}
