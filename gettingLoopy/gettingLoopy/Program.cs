using System;


    class Program
    {
    static void Main()
    {
    //Takes user input and converts it to an integer called number
        Console.WriteLine("Please enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());
        bool isGuessed = number == 56;
        
    //Uses a boolean comparison to the previous input and sends the appropriate output using a while loop
        while (!isGuessed)
        {
            switch (number)
            {
                case 55:
                    Console.WriteLine("So close! Please try again.");
                    Console.WriteLine("Guess a number:");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;

                case 56:
                    Console.WriteLine("You guessed my number! Are you psychic?!?!");
                    isGuessed = true;
                    break;

                case 57:
                    Console.WriteLine("So close! Please try again.");
                    Console.WriteLine("Guess a number:");
                    break;


                default:
                    Console.WriteLine("You guessed the wrong number! Try again!");
                    Console.WriteLine("Guess a number!:");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
            }
        }

    // Using a do- while loop to return all the values in the number set
        Console.WriteLine("Okay, tell you what, you think of a number between 1 and 20 and I will try to guess it!");
        Console.ReadLine();
        int i = 1;
        do
        {
            Console.WriteLine(i);
            i++;
        }
        while (i <= 20);
        Console.WriteLine("Did I guess it?");
        Console.Read();
    }
}
    

