using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer value:");
            int numberOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You may enter a second integer value now to perform a mathematical operation: (This number is optional)");
            string response = Console.ReadLine();

            if (response == "")
            {
                Operations op = new Operations();
                int num3 = op.Math(numberOne);
                Console.WriteLine(numberOne + " multiplied by 10 equals " + num3);
            }
            else
            {
                int numberTwo = Convert.ToInt32(response);
                Operations op = new Operations();
                int num3 = op.Math(numberOne, numberTwo);
                Console.WriteLine(numberOne + " multiplied by " + numberTwo + " equals " + num3);
            }
         
            

            Console.ReadLine();
        
        }
    }
}
