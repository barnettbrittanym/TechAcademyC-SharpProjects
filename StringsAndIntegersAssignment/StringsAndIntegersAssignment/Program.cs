using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        
        try {
            //Creating a list of integers to divide by
            List<int> numerators = new List<int>() { 10, 20, 50, 100, 120, 150, 200 };
            Console.WriteLine("Please pick a number:");
            int denominator = Convert.ToInt32(Console.ReadLine());
            
            //Looping through the list to output each quotient
            for (int i = 0; i < numerators.Count; i++)
            {
                int quotient = numerators[i] / denominator;
                Console.WriteLine(numerators[i] + " divided by " + denominator + " equals: " + quotient);

            }
            Console.ReadLine();
        }

        //Handling divide by zero exceptions
        catch (DivideByZeroException)
        {
            Console.WriteLine("Please do not divide by zero");
            return;
        }
        //Handling formatting errors
        catch (FormatException ex)
        {
            Console.WriteLine("Please enter a whole number");
            return;
        }
        finally
        {
            Console.ReadLine();
        }
        
    }
}
