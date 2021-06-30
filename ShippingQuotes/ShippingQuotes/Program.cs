using System;

    class Program
    {
        static void Main(string[] args)
        {
        //Getting package weight from user input to see if the package meets shipping requirements
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
        Console.WriteLine("Please enter the package weight:");
        int packageWeight = Convert.ToInt32(Console.ReadLine());
        if (packageWeight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            Console.ReadLine();
        }

        //Asking for the dimensions of the package to determine if it is able to be shipped
        else
        {
            Console.WriteLine("Please enter the package width:");
            int packageWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package height:");
            int packageHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package length:");
            int packageLength = Convert.ToInt32(Console.ReadLine());

            //Qualifying the package to see if it is able to be shipped
            if (packageWidth+packageHeight+packageLength >= 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
            }

            //Using the information provided to calculate the shipping cost of the package
            else
            {
                decimal priceQuote = (packageHeight * packageLength * packageWidth * packageWeight) / 100;
                Console.WriteLine("Your shipping cost is: $" + priceQuote);
                Console.ReadLine();

            }
        }

        }
    }

