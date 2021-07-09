using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instatiating the class Operation
            Operation op = new Operation();

            //Calling the first method
            int sum1=op.Math(12);
            Console.WriteLine("Your number plus 10 is: " + sum1);

            //Calling the second method
            int sum2 = op.Math(1.492m);
            Console.WriteLine("Your number multiplied by 10 is:" + sum2);

            //Calling the third method
            int sum3 = op.Math("5");
            Console.WriteLine("10 minus your number is:" + sum3);

            Console.ReadLine();
        }
    }
}
