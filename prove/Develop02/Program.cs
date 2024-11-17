using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        // Create a Journal and a PromptGenerator
        Journal journal = new Journal(new List<Entry>());
        PromptGenerator promptGenerator = new PromptGenerator();

        // Main menu loop
        bool running = true;
        while (running)
        {
            // Display the menu
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            // Get user input
            string choice = Console.ReadLine();

            // Handle user choice
            switch (choice)
            {
                case "1":
                    WriteNewEntry(journal, promptGenerator);
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    SaveJournal(journal);
                    break;
                case "4":
                    LoadJournal(journal);
                    break;
                case "5":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.\n");
                    break;
            }
        }
    }

    // Write a new entry to the journal
    static void WriteNewEntry(Journal journal, PromptGenerator promptGenerator)
    {
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string entryText = Console.ReadLine();
        string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
        Entry newEntry = new Entry(currentDate, prompt, entryText);
        journal.AddEntry(newEntry);
        Console.WriteLine("Your entry has been saved.\n");
    }

    // Save the journal to a file
    static void SaveJournal(Journal journal)
    {
        Console.Write("Enter the filename to save the journal (e.g., Journal.txt): ");
        string filename = Console.ReadLine();
        journal.SaveToFile(filename);
    }

    // Load the journal from a file
    static void LoadJournal(Journal journal)
    {
        Console.Write("Enter the filename to load the journal from (e.g., Journal.txt): ");
        string filename = Console.ReadLine();
        journal.LoadFromFile(filename);
    }
}
