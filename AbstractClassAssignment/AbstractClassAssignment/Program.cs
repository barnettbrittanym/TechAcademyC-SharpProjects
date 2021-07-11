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

            //Calling the SayName method in the employee class based on the the Person class
            employee.SayName();
            Console.ReadLine();
        }
    }
}
