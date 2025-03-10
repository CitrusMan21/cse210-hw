using System;
using System.Collections.Generic;
using System.IO;

namespace JournalApp
{
    public class JournalEntry
    {
        private string _date;
        private string _prompt;
        private string _response;

        public JournalEntry()
        {
        }

        public JournalEntry(string date, string prompt, string response)
        {
            _date = date;
            _prompt = prompt;
            _response = response;
        }

        public void Display()
        {
            Console.WriteLine($"Date: {_date}\nPrompt: {_prompt}\nResponse: {_response}\n");
        }

        public string EntryToString()
        {
            return $"{_date}|{_prompt}|{_response}";
        }

        public void CreateEntry(string prompt)
        {
            _date = DateTime.Now.ToString("yyyy-MM-dd");
            _prompt = prompt;
            Console.WriteLine("Enter your response:");
            _response = Console.ReadLine();
        }

        public string GetDate() => _date;
        public string GetPrompt() => _prompt;
        public string GetResponse() => _response;
    }

    public class Journal
    {
        private List<JournalEntry> _entries = new List<JournalEntry>();

        public void WriteToFile(string fileName)
        {
            File.WriteAllLines(fileName, _entries.ConvertAll(e => e.EntryToString()));
        }

        public void ReadFromFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);
                foreach (var line in lines)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        _entries.Add(new JournalEntry(parts[0], parts[1], parts[2]));
                    }
                }
            }
        }

        public void AddEntry(JournalEntry entry)
        {
            _entries.Add(entry);
        }

        public void DisplayAll()
        {
            Console.WriteLine("Displaying all journal entries:");
            foreach (var entry in _entries)
            {
                entry.Display();
            }
        }

        public void SearchByDate(string date)
        {
            foreach (var entry in _entries)
            {
                if (entry.GetDate() == date)
                {
                    entry.Display();
                    return;
                }
            }
            Console.WriteLine("No entry found for this date.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();

            Console.WriteLine("Welcome to your journal!");
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Read all entries");
                Console.WriteLine("3. Search entry by date");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter a prompt:");
                        string prompt = Console.ReadLine();

                        JournalEntry entry = new JournalEntry();
                        entry.CreateEntry(prompt);
                        journal.AddEntry(entry);

                        journal.WriteToFile("journal.txt");
                        break;
                    case "2":
                        journal.ReadFromFile("journal.txt");
                        journal.DisplayAll();
                        break;
                    case "3":
                        Console.WriteLine("Enter the date to search (YYYY-MM-DD):");
                        string date = Console.ReadLine();
                        journal.ReadFromFile("journal.txt");
                        journal.SearchByDate(date);
                        break;
                    case "4":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}