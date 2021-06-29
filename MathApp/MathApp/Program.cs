using System;



    class Program
    {
        static void Main()
        {

        //An introduction to the application
        Console.WriteLine("Hello! What is your name?");
        string yourName = Console.ReadLine();
        Console.WriteLine("Welcome " + yourName + "! Prepare yourself for some mathematical magic!");

        //Prompting for a user input to base the multiplication operation
        Console.WriteLine("Please enter a number:");
        double numToMultiply = Convert.ToDouble(Console.ReadLine());
        double product = numToMultiply * 50;
        Console.WriteLine("Your number multiplied by 50 is: " + product);

        //Prompting for a user input to base the addition operation
        Console.WriteLine("Please enter a number: ");
        int numToAdd = Convert.ToInt32(Console.ReadLine());
        int sum = numToAdd + 25;
        Console.WriteLine("Your number plus 25 is: " + sum);

        //Prompting for an input from the user to base the division operation
        Console.WriteLine("Please enter a number: ");
        double numToDivide = Convert.ToDouble(Console.ReadLine());
        double quotient = numToDivide / 12.5;
        Console.WriteLine("Your number divided by 12.5 is: " + quotient);

        //Prompting for an input from the user to base the comparison operator on
        Console.WriteLine("Please enter a number:");
        int numToCompare = Convert.ToInt32(Console.ReadLine());
        bool isGreater = numToCompare > 50;
        Console.WriteLine("Your number is greater than 50?" + isGreater);

        //Prompting for an input from the user to use the modulus operator
        Console.WriteLine("Please enter a number:");
        int numToMod = Convert.ToInt32(Console.ReadLine());
        int remainder = numToMod % 7;
        Console.WriteLine("Your number divided by 7 leaves a remainder of:" + remainder);
        Console.ReadLine();
        }
    }

