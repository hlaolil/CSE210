using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries;

    public Journal(List<Entry> entries = null)
    {
        _entries = entries ?? new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
        Console.WriteLine("Entry added successfully.\n");
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries in the journal.\n");
            return;
        }

        for (int i = 0; i < _entries.Count; i++)
        {
            Console.WriteLine($"[{i + 1}] Date: {_entries[i].Date}\nPrompt: {_entries[i].PromptText}\nResponse: {_entries[i].EntryText}\n");
        }
        Console.WriteLine();
    }

    public void EditEntry(int index, string newText)
    {
        if (index < 0 || index >= _entries.Count)
        {
            Console.WriteLine("Invalid entry number.\n");
            return;
        }

        _entries[index].EntryText = newText;
        Console.WriteLine("Entry updated successfully.\n");
    }

    public void SaveToFile(string filename)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Entry entry in _entries)
                {
                    writer.WriteLine($"{entry.Date}|{entry.PromptText}|{entry.EntryText}");
                }
            }
            Console.WriteLine("Journal saved successfully.\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}\n");
        }
    }

    public void LoadFromFile(string filename)
    {
        try
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine($"File '{filename}' does not exist.\n");
                return;
            }

            string[] lines = File.ReadAllLines(filename);
            _entries.Clear();

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
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
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal: {ex.Message}\n");
        }
    }
}

