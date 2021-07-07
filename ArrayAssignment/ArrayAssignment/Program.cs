using System;
using System.Collections.Generic;



    class Program
    {
        static void Main(string[] args)
        {

        //Create a one dimensional Array of strings
        string[] stringArray = {"apple", "banana", "cherry", "grape", "watermelon", "pineapple"};

        //Asking the user to select an index of the array and displaying the results on the screen
        Console.WriteLine("Please select an index from the string array to see its value:");
        int indexValueStr = Convert.ToInt32(Console.ReadLine());
        if (indexValueStr <= 5)
            {
            Console.WriteLine(stringArray[indexValueStr]);
        }
        else {
            Console.WriteLine("I am sorry. There is no value at this input. Please try again.");
                }

        //Create a one dimensional Array of integers
        int[] integerArray = { 2, 4, 6, 8, 10 };

        //Asking the user to select an index of the array and displaying the results on the screen
        Console.WriteLine("Please select an index from the integer array to see its value:");
        int indexValueInt = Convert.ToInt32(Console.ReadLine());
        if (indexValueInt <= 4)
            { 
            Console.WriteLine(integerArray[indexValueInt]); 
        }
        else
        {
            Console.WriteLine("I am sorry. There is no value at this input. Please try again.");
        }
       

        //Create a list of strings
        List<string> citiesList = new List<string>();
        citiesList.Add("Portland");
        citiesList.Add("Chicago");
        citiesList.Add("Orlando");
        citiesList.Add("Atlanta");
        citiesList.Add("Columbus");

        //Asking the user to select an index of the array and displaying the results on the screen
        Console.WriteLine("Please select an index from the last array to see its value:");
        int indexCity = Convert.ToInt32(Console.ReadLine());
        if (indexCity <= 4)
        {
            Console.WriteLine(citiesList[indexCity]);
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("I am sorry. There is no value at this input. Please try again.");
        }
        }
    }

