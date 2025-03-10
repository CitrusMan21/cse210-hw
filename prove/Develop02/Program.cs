using System;
using System.Collections.Generic;
using System.IO;

class Entry
{
    public string Date { get; set; }
    public string Name { get; set; }

    public string EntryToString()
    {
        return $"Date: {Date}\nName: {Name}\n";
    }
}

class Journal
{
    public List<Entry> Pages { get; set; } = new List<Entry>();

    public void ReadFromFile(string fileName)
    {
        if (File.Exists(fileName))
        {
            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 2)
                {
                    Pages.Add(new Entry { Date = parts[0], Name = parts[1] });
                }
            }
        }
    }

    public void WriteToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var entry in Pages)
            {
                writer.WriteLine($"{entry.Date},{entry.Name}");
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();

        Console.WriteLine("Enter a date:");
        string date = Console.ReadLine();

        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();

        myJournal.Pages.Add(new Entry { Date = date, Name = name });
        myJournal.WriteToFile("journal.txt");

        Console.WriteLine("Journal saved! Reading from file:");
        myJournal.ReadFromFile("journal.txt");

        foreach (var entry in myJournal.Pages)
        {
            Console.WriteLine(entry.EntryToString());
        }
    }
}

