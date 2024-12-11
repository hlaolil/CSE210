using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        var breathingActivity = new BreathingActivity("Breathing Exercise", "A simple breathing exercise to relax.", 60);
        

        var listingPrompts = new List<string> { "Name things you are grateful for.", "List your favorite hobbies.", "What are your proudest achievements?", "Who inspires you the most?", "Describe places you want to visit." };
        var listingActivity = new ListingActivity("Listing Exercise", "List responses to a prompt.", 60, listingPrompts);
        

        var reflectingPrompts = new List<string> { "Think about a recent challenge you overcame.", "Reflect on a happy memory.", "What motivates you each day?", "Who has made a big impact on your life?", "What are you most passionate about?" };
        var reflectingQuestions = new List<string> { "Why was this experience significant?", "How did it change you?", "What did you learn from it?", "How can you use this lesson moving forward?", "What surprised you most about this experience?" };
        var reflectingActivity = new ReflectingActivity("Reflection Exercise", "Reflect on prompts and questions.", 60, reflectingPrompts, reflectingQuestions);
        
        while (true)
        {
            Console.WriteLine("\n--- Activity Menu ---");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an activity (1-4): ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    breathing.Run();
                    break;
                case "2":
                    listing.Run();
                    break;
                case "3":
                    reflecting.Run();
                    break;
                case "4":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
