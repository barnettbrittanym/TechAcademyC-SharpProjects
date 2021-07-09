using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Operation
    {
        //Creating a method math that requires an int passed in
        public int Math(int num1)
        {
            int sum = num1 + 10;
            return sum;
        }

        //Creating a method math that requires a decimal input
        public int Math(decimal num2)
        {
            int product =(Convert.ToInt32(num2)) * 10;
            return product;
        }

        //Creating a method math that converts a string to an integer and performs a math function
        public int Math(string num3)
        {
            int number = (Convert.ToInt32(num3));
            int difference = 10 - number;
            return difference;
        }
    }
}
