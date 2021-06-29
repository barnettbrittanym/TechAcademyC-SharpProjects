using System;

    class Program
    {
        static void Main(string[] args)
        {
        //Asking for all required infomation through user input
        Console.WriteLine("What is your age?");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Have you ever had a DUI? Please enter True or False");
        bool dui = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("How many speeding tickets do you have?");
        int speedingTickets =Convert.ToInt32( Console.ReadLine());

        //Boolean statement to qualify the applicant
        bool qualified = (age > 15) && (dui == false) && (speedingTickets < 3);

        //Prints the result to the console screen
        Console.WriteLine("The applicant is qualified:");
        Console.WriteLine(qualified);
        Console.ReadLine();

        }
    }

