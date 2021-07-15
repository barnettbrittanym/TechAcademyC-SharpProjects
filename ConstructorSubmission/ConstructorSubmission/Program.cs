using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a const variable
            const string banana = "This is a banana string";
            Console.WriteLine(banana);

            //Creating a variable using the keyword var
            var temperature = 72;
            Console.WriteLine(temperature);

            //instantiating a person of the chained class
            Persons employee = new Persons("Bob", "Jones");
            

            Console.ReadLine();
       
        }
    }
}
