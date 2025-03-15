using System;
using System.Collections.Generic;
using System.IO;

namespace team_activity
{
    public class Journal
    {
        public List<Entry> _entries = new List<Entry>();
        private static readonly string[] _prompts =
        {
            "What was the best part of your day?",
            "What did you learn today?",
            "What made you smile today?",
            "What challenge did you overcome today?"
        };

        public void AddEntry()
        {
            string prompt = _prompts[new Random().Next(_prompts.Length)];
            Console.WriteLine($"\nPrompt: {prompt}");
            Console.Write("Your Response: ");
            string response = Console.ReadLine();

            _entries.Add(new Entry(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), prompt, response));
        }

        public void DisplayEntries()
        {
            if (_entries.Count == 0)
            {
                Console.WriteLine("\nNo journal entries found.");
                return;
            }

            Console.WriteLine("\nJournal Entries:");
            foreach (var entry in _entries)
            {
                entry.Display();
            }
        }

        public void SaveToFile(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var entry in _entries)
                {
                    writer.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
                }
            }
            Console.WriteLine("\nJournal saved successfully.");
        }

        public void LoadFromFile(string fileName)
        {
            if (!File.Exists(fileName))
            {
                Console.WriteLine("\nNo saved journal found.");
                return;
            }

            _entries.Clear();
            string[] lines = File.ReadAllLines(fileName);

            foreach (var line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    _entries.Add(new Entry(parts[0], parts[1], parts[2]));
                }
            }
            Console.WriteLine("\nJournal loaded successfully.");
        }
    }
}
