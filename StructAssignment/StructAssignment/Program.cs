using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public struct Number { public decimal Amount; }

namespace StructAssignment
{
    

    class Program
    {
        

        static void Main(string[] args)
        {
            //Instantiating the Number Struct
            Number num1;

            //Specification of an amount
            num1.Amount = 1.056543m;

            //Printing the amount set in the struct to the console
            Console.WriteLine(num1.Amount);
            Console.ReadLine();
         

           
    }
    }
}
