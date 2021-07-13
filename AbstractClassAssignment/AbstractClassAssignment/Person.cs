using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    //Creating the abstract class Person
    public abstract class Person
    {
        //Setting properties in the abstract class
        public string firstName { get; set; }
        public string lastName { get; set; }

        //Creating a method called SayName to be inherited by other classes
        public abstract void SayName();
        
    }   
  
    
}
