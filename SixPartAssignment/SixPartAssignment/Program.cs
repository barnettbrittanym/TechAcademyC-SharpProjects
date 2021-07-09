using System;
using System.Collections.Generic;



    class Program
    {
        static void Main(string[] args)
        {
        //Creating a one dimensional array of strings
        string[] fruitArray = { "Apple", "Banana", "Strawberry", "Banana", "Grape", "Watermelon", "Blueberry", "Raspberry" };

        //Asking for user input
        Console.WriteLine("Please add the name of your favorite pastry:");
        string pastryName = Convert.ToString(Console.ReadLine());

        //Iterating the array and adding user input to each index value
        for (int i = 0; i < fruitArray.Length; i++)
            fruitArray[i] = fruitArray[i] +" "+ pastryName;

        //Printing off the appended values in the array
        for (int i = 0; i < fruitArray.Length; i++)
        {
            Console.WriteLine(fruitArray[i]);
            
        }
        Console.ReadLine();

        //Creating an infinite loop
        int q = 1;
        while (q > 0)
        {
            Console.WriteLine("q = {0}",q);
            q++;

            //fixing the infinite loop so that it will execute properly
            if (q == 15)
                break;
        }
        Console.ReadLine();


        //Creating a loop with the comparison operator "<"
        int[] numberonies = { 1, 2, 3, 12, 24, 13, 11, 84, 93 };
        for (int i=0; i < numberonies.Length; i++)
            if(numberonies[i] > 10)
            {
                Console.WriteLine("Wow " + numberonies[i] + " is a pretty big number!");
            }
        Console.ReadLine();

        //Creating a loop with the comparison operator "<="
        string[] colors = { "yellow", "orange", "red", "white", "black", "blue", "green", "indigo" };
        for (int i = 0; i <= 2; i++)
        {
            Console.WriteLine(colors[i] + " is a warm color.");
        }
        Console.ReadLine();

        //Adding a list of strings where each item on the list is unique
        List<string> cars = new List<string>() { "Dodge", "Kia", "Chevrolet", "Ford", "Hyundai", "Honda", "Nissan", "GMC", "Chrysler" };
        Console.WriteLine("Please enter the make of your vehicle to determine if it is one the list:");
        string carName = Convert.ToString(Console.ReadLine());
        int nameIndex = cars.IndexOf(carName);

        //Loops through the list of vehicles to find the users input and prints the index position
        for (int i = 0; i < cars.Count; i++)
        {
            if (cars.Contains(carName))
            {
                Console.WriteLine("You vehicle is on the list in position: {0}", nameIndex);
                break;
            }
            else
            {
                Console.WriteLine("I am sorry your vehicle is not on this list.");
                break;
            }
        }
        Console.ReadLine();

        //Adding a list of strings that has identical strings
        List<string> superheroes = new List<string>() { "Batman", "Iron Man", "Hulk", "Thor", "Spiderman", "Batman"};
        Console.WriteLine("Please enter the name of a superhero to determine if it is on the list:");
        string superName = Console.ReadLine();
        bool isPresent = false;
        
        //Loops through the list of super heroes to find the users input and returns the index of the value
        for (int i = 0; i < superheroes.Count; i++)
        {
            if (superName == superheroes[i])
            {
                isPresent = true;
                Console.WriteLine(superName + " is present at index {0}", i);
            }
                
            else
            {
                isPresent = false;
            }

        }
        Console.ReadLine();

        //Adding a list of strings that has identical strings
        List<string> disneyMovies = new List<string>() { "Bambi", "Pinocchio", "Snow White", "Robin Hood", "Beauty and the Beast", "Snow White", "The Lion King", "Aladdin" };
        var movieList = new List<string>();
        foreach (string movie in disneyMovies)
        {
            if (!movieList.Contains(movie))
            {
                movieList.Add(movie);
                Console.WriteLine("I have not seen {0} in the list before.", movie);
            }
            else
            {
                Console.WriteLine(movie + " is already on the list.");
            }
        }
        Console.ReadLine();
    }
}
    

