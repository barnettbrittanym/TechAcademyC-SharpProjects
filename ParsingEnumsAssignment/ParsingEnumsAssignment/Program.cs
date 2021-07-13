using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment
{
    public enum DayoftheWeek { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday};
    class Program
    {
        static void Main(string[] args)
        {

            //Asking for the user input of the current day of the week
            Console.WriteLine("Please enter the current day of the week: ");
            
            //Capturing the user response inside of the variable entry
            string entry = Console.ReadLine();

            //Parsing the enum in a try catch block to handle exceptions
            try {
                //Defining a variable to compare with the user entry
                DayoftheWeek day = (DayoftheWeek)Enum.Parse(typeof(DayoftheWeek), entry);   
                if ((Enum.IsDefined(typeof(DayoftheWeek), day)))
                    Console.WriteLine("Correct! It is {0}", entry);
                }
            catch(Exception)
                {
                Console.WriteLine("Please enter an actual day of the week.");
                }
            
            Console.ReadLine();

         
        }

    }
}
