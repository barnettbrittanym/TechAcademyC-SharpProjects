using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a list of employees with two named Joe
            List<Employee> employees = new List<Employee>
            {
                new Employee(){ID = 1, FirstName= "Joe", LastName = "Smith"},
                new Employee(){ID = 2, FirstName= "Rayna", LastName= "Lots"},
                new Employee(){ID = 3, FirstName= "Snowy", LastName= "Hill"},
                new Employee(){ID = 4, FirstName= "Joe", LastName="Howardu"},
                new Employee(){ID = 5, FirstName="Eileen", LastName="Onadesk"},
                new Employee(){ID = 6, FirstName="Shawn", LastName= "Inalf"},
                new Employee(){ID = 7, FirstName="Pierce", LastName="Monose"},
                new Employee(){ID = 8, FirstName="Jeb", LastName= "Jebberson"},
                new Employee(){ID = 9, FirstName="Nick", LastName= "Meshavin"},
                new Employee(){ID = 10, FirstName="Paula", LastName="Bean"}
            };

            //Creating a for loop to return all the values in the list with the first name Joe
            foreach (Employee employee in employees)
                if (employee.FirstName =="Joe")
            {
                Console.WriteLine("This is:" + employee.FirstName +" "+ employee.LastName);
            }

            //Creating a lambda expression to return the same information
            var names = employees.FindAll( x => x.FirstName == "Joe");
            {
                foreach (var name in names)
                {
                    Console.WriteLine(name.FirstName +" "+ name.LastName);
                }
            }

            //Using a lambda expression to return a list of all employees with an ID greater than 5
            var fullNames = employees.FindAll(x => x.ID > 5);
            {
                foreach(var fullName in fullNames)
                {
                    Console.WriteLine("ID: " + fullName.ID + " " + fullName.FirstName + " " + fullName.LastName);
                }
            }
            Console.ReadLine();
        }
    }
}
