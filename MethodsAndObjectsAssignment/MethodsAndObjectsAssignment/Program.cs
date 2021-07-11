using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating the employee class
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };

            //Calling the Person method SayName on the employee class
            employee.SayName();
            Console.ReadLine();
        }
    }
}
