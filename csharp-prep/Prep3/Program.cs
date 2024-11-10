using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1,100);
        int guess = 0;
        while (guess != magic)
        {
            Console.Write("Enter Guess Number between 1 and 100: ");
            if (!int.TryParse(Console.ReadLine(), out guess))
            {
                Console.WriteLine("Please enter a valid integer.");
                continue;
            }
            if (guess < magic)
            {
                Console.WriteLine("Guess higher");
            }
            else if (guess > magic)
            {
                Console.WriteLine("Guess lower");
            }
            else
            {
            Console.WriteLine("You guessed it! ");
            }
        }
    }
        
        
}