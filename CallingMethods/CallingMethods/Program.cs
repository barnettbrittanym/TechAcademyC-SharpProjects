using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Taking user input to store variables for math operations
            Console.WriteLine("Please enter a number: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            //Instantiating the class to call the functions
            Operator op = new Operator();

            //Calling functions and printing the results to the console
           int resultSquare = op.SquareNumber(userNumber);
            Console.WriteLine("The square of the first number is:" + resultSquare);

            int resultAdd = op.AddNumbers(userNumber, secondNumber);            
            Console.WriteLine("The sum of " + userNumber + " and " + secondNumber + " is " + resultAdd);

            int resultdiv = op.DivideNumbers(userNumber, secondNumber);
            Console.WriteLine( userNumber + " divided by " + secondNumber + " equals " + resultdiv);

            Console.ReadLine();
        }
     }
}
