using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmission
{
    public class Persons
    {
        //Chaining two constructors together
        public Persons(string fname, string lname):this(fname, lname, "")
        {

        }

        public Persons(string fname, string lname, string dept)
        {
            string firstName = fname;
            string lastName = lname;
            string department = dept;
            string fullName = (fname + " " + lname);
            Console.WriteLine(fullName);
        }

       
            

    }
    
}
