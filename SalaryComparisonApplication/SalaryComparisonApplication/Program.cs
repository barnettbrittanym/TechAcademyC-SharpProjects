using System;


    class Program
    {
        static void Main()
        {
        //Asking for information from the first user and converting the information to store into variables
        Console.WriteLine("Anonymous Income Comparison Program");
        Console.WriteLine("Person 1: Please input the required information.");
        Console.WriteLine("What is your current hourly rate?");
        double payRate1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("How many hours do you work per week?");
        double hoursWorked1 = Convert.ToDouble(Console.ReadLine());

        //Asking for information from the second user to store the information into variables
        Console.WriteLine("Person 2: Please input the required information.");
        Console.WriteLine("What is your current hourly rate?");
        double payRate2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("How many hours do you work per week?");
        double hoursWorked2 = Convert.ToDouble(Console.ReadLine());

        //calculating the annual income of each user
        double annualSalary1 = payRate1 * hoursWorked1 * 52;
        double annualSalary2 = payRate2 * hoursWorked2 * 52;

        //Returning the first users annual salary
        Console.WriteLine("Annual Salary of Person 1:");
        Console.WriteLine(annualSalary1);
        Console.ReadLine();

        //Returning the second users annual salary
        Console.WriteLine("Annual Salary of Person 2:");
        Console.WriteLine(annualSalary2);
        Console.ReadLine();

        //Comparing both salaries with a boolean operator and returning which salary was the highest
        bool breadWinner = annualSalary1 > annualSalary2;
        Console.WriteLine("Does Person 1 make more money than Person 2?");
        Console.ReadLine();
        Console.WriteLine(breadWinner);
        Console.ReadLine();
        }
    }

