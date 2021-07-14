using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asking the user to input a number
            Console.WriteLine("Please enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            //Using StreamWriter to append the values to the numberLog file
            using (StreamWriter file = new StreamWriter(@"C:\Users\Brittany Barnett\Logs\numberLog.txt", true))
            {
                file.WriteLine(input);
            }

            //setting a variable list to capture all the values from the file and print them to the console
            string list = File.ReadAllText(@"C:\Users\Brittany Barnett\Logs\numberLog.txt");
            Console.WriteLine(list);
            Console.ReadLine();

        }
    }
}
