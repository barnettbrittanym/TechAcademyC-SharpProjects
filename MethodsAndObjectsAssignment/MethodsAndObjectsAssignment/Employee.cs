using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    //Creating the public class Employee and Inheriting all the properties of the Person class
    public class Employee : Person
    {
        //Creating a property called Id which is specific to the Employee class
        public int Id { get; set; }
    }
}
