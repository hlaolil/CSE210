using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
   private List<Entry> _entries;

   public Journal(List<Entry> entries)
   {
      _entries = entries ?? new List<Entry>();
   }

   public void AddEntry(Entry newEntry)
   {
      _entries.Add(newEntry);
   }
   public void DisplayAll()
   {
      if (_entries.Count == 0)
        {
            Console.WriteLine("No entries in the journal.\n");
            return;
        }
      foreach (Entry entry in _entries)
      {
         entry.Display();
      }
      
   }

   // Save the journal to a file
    public void SaveToFile(string filename)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Entry entry in _entries)
                {
                    // Write each entry as a string with a separator (e.g., '|')
                    writer.WriteLine($"{entry.Date}|{entry.PromptText}|{entry.EntryText}");
                }
            }
            Console.WriteLine("Journal saved successfully.\n");
        }
        catch (Exception ex) // Added catch block for safety
        {
            Console.WriteLine($"Error saving journal: {ex.Message}");
        }
    } // <-- Closing brace for method
    

    // Load the journal from a file
    public void LoadFromFile(string filename)
    {
        try
        {
            // Check if the file exists
            if (!File.Exists(filename))
            {
                Console.WriteLine($"File '{filename}' does not exist.\n");
                return;
            }

            // Read all lines from the file
            string[] lines = File.ReadAllLines(filename);

            // Clear any existing entries in the journal
            _entries.Clear();

            // Parse each line into an entry and add it to the journal
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)  // Ensure the line is valid
                {
                    string date = parts[0];
                    string promptText = parts[1];
                    string entryText = parts[2];

                    Entry entry = new Entry(date, promptText, entryText);
                    _entries.Add(entry);
                }
            }
            Console.WriteLine("Journal loaded successfully.\n");
        }
        catch (Exception ex) // Added catch block for safety
        {
            Console.WriteLine($"Error loading journal: {ex.Message}");
        }
    } // <-- Closing brace for method
        
}



