using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            int eployeeIdNumber = 1;
            List<Employee> forEachEmployees = new List<Employee>();
            List<Employee> lambdaEmployees = new List<Employee>();
            List<Employee> lambdaID = new List<Employee>();

            //Employee creation
            Employee employee = new Employee();
            employee.firstName = "Bob";
            employee.lastName = "Saber";
            employee.employeeID = eployeeIdNumber++;
            employees.Add(employee);

            Employee employee1 = new Employee();
            employee1.firstName = "Gret";
            employee1.lastName = "Tormak";
            employee1.employeeID = eployeeIdNumber++;
            employees.Add(employee1);

            Employee employee2 = new Employee();
            employee2.firstName = "Joe";
            employee2.lastName = "Dirt";
            employee2.employeeID = eployeeIdNumber++;
            employees.Add(employee2);

           
            Employee employee4 = new Employee();
            employee4.firstName = "Pat";
            employee4.lastName = "McGregor";
            employee4.employeeID = eployeeIdNumber++;
            employees.Add(employee4);

            Employee employee5 = new Employee();
            employee5.firstName = "Laurel";
            employee5.lastName = "McGregor";
            employee5.employeeID = eployeeIdNumber++;
            employees.Add(employee5);

            Employee employee6 = new Employee();
            employee6.firstName = "Gabi";
            employee6.lastName = "Boswell";
            employee6.employeeID = eployeeIdNumber++;
            employees.Add(employee6);

            Employee employee7 = new Employee();
            employee7.firstName = "Tonya";
            employee7.lastName = "Wice";
            employee7.employeeID = eployeeIdNumber++;
            employees.Add(employee7);

            Employee employee8 = new Employee();
            employee8.firstName = "Pat";
            employee8.lastName = "Rose";
            employee8.employeeID = eployeeIdNumber++;
            employees.Add(employee8);

            Employee employee9 = new Employee();
            employee9.firstName = "Elena";
            employee9.lastName = "DeWilled";
            employee9.employeeID = eployeeIdNumber++;
            employees.Add(employee9);
           
            Employee employee3 = new Employee();
            employee3.firstName = "Joe";
            employee3.lastName = "Jackson";
            employee3.employeeID = eployeeIdNumber++;
            employees.Add(employee3);

            // for each statement that looks through employees and adds it to forEachEmployees List so long as the first name is "Joe
            foreach (Employee employ in employees)
            {
                if (employ.firstName == "Joe")
                {
                    forEachEmployees.Add(employ);
                }
            }
            //This lambda expression looks through employees and finds things with the first name "Joe" then adds it to the list lambdaEmployees. NOTE: Where creates a new list
            lambdaEmployees = employees.Where(x => x.firstName == "Joe").ToList();

            //This lambda expression looks through employees and finds any ID that is greater than 5 and addes to the list of lambdaID
            lambdaID = employees.Where(x => x.employeeID >= 5).ToList();

            //something to write aout the lambdayEmployee list
            foreach (Employee item in lambdaEmployees)
            {
                Console.WriteLine(item.employeeID + " "+ item.firstName +" "+ item.lastName);

            }

            Console.WriteLine("\nNow for the IDs\n");


            //something to write aout the lambdaID list
            foreach (Employee item in lambdaID)
            {
                Console.WriteLine(item.employeeID + " " + item.firstName + " " + item.lastName);

            }
            Console.ReadLine();     
        }
    }
}
