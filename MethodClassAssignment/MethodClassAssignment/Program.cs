using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Instantiating the operator class
            Operator z = new Operator();

            //Calling the numbers method by passing in two values
            z.Numbers(2,5);

            //Calling the numbers method by specifying the parameters by name
            z.Numbers();
     
            Console.ReadLine();
        }   
    }
}
