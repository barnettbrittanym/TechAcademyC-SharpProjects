using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Operator
    {
        //Creating a method to perform addition on the two user input numbers
        public int AddNumbers(int userNumber, int secondNumber)
        {
            return userNumber + secondNumber;
           
        }
        //Creating a method to square the first number
        public int SquareNumber(int userNumber)
        {
            return userNumber * userNumber;
        }
        //Creating a method to Divide the two numbers
        public int DivideNumbers(int userNumber, int secondNumber)
        {
            return userNumber / secondNumber;
        }

    }
}
