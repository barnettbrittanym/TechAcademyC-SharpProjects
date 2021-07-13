using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    //Setting the public class employee and specifying that it should inherit properties from the Person class
    public class Employee : Person, IQuittable
    {
        //Setting a property to assign people an employee ID
        public int EmployeeId { get; set; }

        //Overriding the person class method SayName to make it display the names that were set
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }

        //Creating an implementation for the Quit method
        public void Quit()
        {
            Console.WriteLine("Oh snap, they are about to quit!");
        }

        //Overloading the operator == to determine if two employees are the same by comparing their ID
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            return employee1.EmployeeId == employee2.EmployeeId;
        }

        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return employee1.EmployeeId != employee2.EmployeeId;
        }
        
        //Using overrides to satisfy complier requirements
        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        
        

        

    }
}
