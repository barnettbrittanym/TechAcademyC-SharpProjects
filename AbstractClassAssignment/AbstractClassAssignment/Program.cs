using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating the employee class
            Employee employee = new Employee();

            //Setting the variables in the employee class
            employee.firstName = "Sample";
            employee.lastName = "Student";
            employee.EmployeeId = 1;

            Employee employee1 = new Employee() { firstName = "Tony", lastName = "Thetiger", EmployeeId = 3 };
            Employee employee2 = new Employee() { firstName = "Bob", lastName = "Forapples", EmployeeId = 4 };

            if (employee1==employee2)
            {
                Console.WriteLine("This is the same employee");
            }
            else
            {
                Console.WriteLine("This is not the same employee");
            }

            //Calling the SayName method in the employee class based on the the Person class
            employee.SayName();

            //Using polymorphism to create a new instance
            IQuittable quitting = new Employee();

            //Calling the Quit Method
            quitting.Quit();

            Console.ReadLine();
        }
    }
}
