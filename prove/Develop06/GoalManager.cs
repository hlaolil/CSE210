using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create a Goal");
            Console.WriteLine("2. Record an Event");
            Console.WriteLine("3. List Goals");
            Console.WriteLine("4. Display Player Info");
            Console.WriteLine("5. Save Goals to File");
            Console.WriteLine("6. Load Goals from File");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    RecordEvent();
                    break;
                case "3":
                    ListGoals();
                    break;
                case "4":
                    DisplayPlayerInfo();
                    break;
                case "5":
                    Console.Write("Enter file path to save goals: ");
                    string savePath = Console.ReadLine();
                    SaveGoals(savePath);
                    break;
                case "6":
                    Console.Write("Enter file path to load goals: ");
                    string loadPath = Console.ReadLine();
                    LoadGoals(loadPath);
                    break;
                case "7":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nTotal Points: {_score}");
    }

    public void ListGoals()
    {
        Console.WriteLine("\nYour Goals:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nChoose Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter target count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid option.");
                break;
        }
    }

    public void RecordEvent()
    {
        ListGoals();
        Console.Write("Enter goal number to record an event: ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            _goals[goalIndex].RecordEvent();
            _score += _goals[goalIndex].GetPoints();

            if (_goals[goalIndex] is ChecklistGoal checklist && checklist.IsComplete())
            {
                _score += checklist.GetPoints();
            }
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    public void SaveGoals(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            // Write the player's score as the first line
            writer.WriteLine(_score);

            // Write each goal to the file
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals(string filePath)
    {
        if (File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                // Read the player's score from the first line
                _score = int.Parse(reader.ReadLine());

                _goals.Clear(); // Clear the existing goals list

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');

                    string goalType = parts[0];
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);

                    switch (goalType)
                    {
                        case "SimpleGoal":
                            bool isComplete = bool.Parse(parts[4]);
                            _goals.Add(new SimpleGoal(name, description, points) { IsComplete = isComplete });
                            break;

                        case "EternalGoal":
                            _goals.Add(new EternalGoal(name, description, points));
                            break;

                        case "ChecklistGoal":
                            int target = int.Parse(parts[4]);
                            int bonus = int.Parse(parts[5]);
                            int amountCompleted = int.Parse(parts[6]);
                            _goals.Add(new ChecklistGoal(name, description, points, target, bonus)
                            {
                                AmountCompleted = amountCompleted
                            });
                            break;

                        default:
                            Console.WriteLine("Unknown goal type in file.");
                            break;
                    }
                }
            }

            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
