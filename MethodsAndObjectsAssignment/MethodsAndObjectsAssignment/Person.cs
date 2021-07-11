using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    public class Person
    {
        //Creating properties for the person class
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Creating a method to print the persons first and last name to the console
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName +" "+ LastName);
        }
    }
}
