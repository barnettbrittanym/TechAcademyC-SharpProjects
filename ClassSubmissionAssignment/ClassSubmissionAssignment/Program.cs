using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompting the user for a number input to set to a variable
            Console.WriteLine("Please enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            //Instantiating the math class and calling the math function to divide the number by 2
            Math math = new Math();

            //Calling the first function
            math.Half(num);

            //Calling the second function
            math.SimpleMath(out int x, out int y);

            //Calling the overloaded function with two parameters
            math.Addition(5, 2);

            //Calling the same function using three parameters
            math.Addition(2, 6, 3);


            Console.ReadLine();
        }
       
    }
}
