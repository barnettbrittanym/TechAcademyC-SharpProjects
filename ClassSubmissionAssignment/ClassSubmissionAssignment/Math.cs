using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    //Creating a method that takes a value and divides it by two
    class Math
    {
        public void Half(int num)
        {
            int div = num / 2;
            Console.WriteLine(num + " divided by 2 is " + div);

        }

        //Creating a method that has output parameters
        public void SimpleMath(out int x, out int y)
        {
            Console.WriteLine("Please enter a first number: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a second number: ");
            y = Convert.ToInt32(Console.ReadLine());
        }

        //Overloading a method
        public int Addition(int x , int y)
        {
            int sum = x + y;
            return sum;
        }

        public int Addition(int x, int y, int z)
        {
            int sum = x + y + z;
            return sum;
        }

        
    }
}
