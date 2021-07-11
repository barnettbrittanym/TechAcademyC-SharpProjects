using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    //Setting the public class employee and specifying that it should inherit properties from the Person class
    public class Employee : Person
    {
        //Overriding the person class method SayName to make it display the names that were set
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }
}
