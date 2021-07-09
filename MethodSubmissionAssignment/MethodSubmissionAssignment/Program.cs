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
            //Asking for a user generated integer to pass into the method
            Console.WriteLine("Please enter an integer value:");
            int numberOne = Convert.ToInt32(Console.ReadLine());

            //Creating a prompt to allow the user to enter an optional second parameter
            Console.WriteLine("You may enter a second integer value now to perform a mathematical operation: (This number is optional)");
            string response = Console.ReadLine();

            //using an if else statement to pass in the proper parameters based on the user input
            if (response == "")
            {
                //instantiating the class and calling the method using one parameter
                Operations op = new Operations();
                int num3 = op.Math(numberOne);
                Console.WriteLine(numberOne + " multiplied by 10 equals " + num3);
            }
            else
            {
                //instantiating the class and calling the method using two user generated parameters
                int numberTwo = Convert.ToInt32(response);
                Operations op = new Operations();
                int num3 = op.Math(numberOne, numberTwo);
                Console.WriteLine(numberOne + " multiplied by " + numberTwo + " equals " + num3);
            }
         
            

            Console.ReadLine();
        
        }
    }
}
