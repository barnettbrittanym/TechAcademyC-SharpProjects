using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating the current datetime and printing it to the console
            var currentTime = DateTime.Now;
            Console.WriteLine("It is currently:" + currentTime);

            //Asking the user to input a number that will be used for hours
            Console.WriteLine("Please enter a number:");
            int numberHours = Convert.ToInt32(Console.ReadLine());

            //Returning the future time by adding that number of hours to the current datetime
            Console.WriteLine("In {0} hours it will be: {1}", numberHours, currentTime.AddHours(numberHours));
            Console.ReadLine();
        }
    }
}
