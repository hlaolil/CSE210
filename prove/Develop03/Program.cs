using System;

class Program
{
    static void Main()
    {
        // Create a reference and scripture object
        Reference scriptureReference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(scriptureReference, "For God so loved the world that He gave His only begotten Son, that whoever believes in Him should not perish but have everlasting life.");

        // Initial display
        Console.WriteLine("Original Scripture:");
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();

        // Hide and display words in a loop
        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine("Press Enter to hide some words...");
            Console.ReadLine();  // Wait for Enter key

            // Clear the console before updating the display
            Console.Clear();  

            scripture.HideRandomWords(2);  // Hide 2 more words
            Console.WriteLine(scripture.GetDisplayText());
        }

        Console.WriteLine("All words are now hidden!");
    }
}
