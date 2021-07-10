using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class Operator
    {
        //Creating a void method called Numbers
        public void Numbers(int num1 = 4, int num2=20)
        {
            //Performing a math operation with the first parameter
            int result = num1 / 2;
            Console.WriteLine(num1 + " divided by 2 is: " + result);
            
            //Writing the value of the second parameter to the console
            Console.WriteLine("The second number passed into this method is: {0}", num2);
        }
    }
}
