using System;


    class Program
    {
        static void Main()
        {
        //Creating the welcome lines for the application
        Console.WriteLine("The Tech Academy");
        Console.WriteLine("Student Daily Report");
        Console.ReadLine();

        //Creating a variable to save the student name and store it as a a string
        Console.WriteLine("What is your name?");
        string yourName = Console.ReadLine();

        //Creating a variable to save the name of the course as a string
        Console.WriteLine("What course are you on?");
        string yourCourse = Console.ReadLine();

        //Creating a variable to save the page number as an integer
        Console.WriteLine("What page number?");
        int pageNumber = Convert.ToInt32(Console.ReadLine());
        
        //Creating a variable to save whether the user needs help as a boolean data type
        Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
        bool needsHelp = Convert.ToBoolean(Console.ReadLine());

        //Creating a variable to store any positive experiences as a string
        Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
        string positiveExperiences = Console.ReadLine();

        //Creating a variable to store the students feedback as a string
        Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific");
        string otherFeedback = Console.ReadLine();

        //Creating a variable to store the number of hours studied
        Console.WriteLine("How many hours did you study today?");
        string hoursStudied = Console.ReadLine();
        
        //Leaving a thank you message
        Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        Console.ReadLine();

        }
    }

