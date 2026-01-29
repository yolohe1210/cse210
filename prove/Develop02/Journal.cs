using System;
using System.Collections.Generic;
using System.IO;
public class Journal
    {
        private List<Entry> _entries = new List<Entry>();
        private string _filename = "journal.txt";

        public void AddEntry(Entry newEntry)
        {
            _entries.Add(newEntry);
        }

        public void DisplayAll()
        {
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }
        public void SaveToFile()
        {
            using (StreamWriter outputFile = new StreamWriter(_filename))
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._title}|{entry._entry}");
                }
            }
            Console.WriteLine("Journal saved successfully!");
        }

        public void LoadFromFile()
        {
            if (!File.Exists(_filename))
            {
                Console.WriteLine("Journal file not found. Please save a journal first.");
                return;
            }

            _entries.Clear();

            string[] lines = File.ReadAllLines(_filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                Entry newEntry = new Entry(parts[0], parts[1], parts[2], parts[3]);
                _entries.Add(newEntry);
            }
            Console.WriteLine("Journal loaded successfully!");
        }
        public void DisplayByPrompt()
        {
            var prompts = new HashSet<string>();
            foreach (var entry in _entries)
                prompts.Add(entry._prompt);

            foreach (var prompt in prompts)
            {
                Console.WriteLine($"\nPrompt: {prompt}");
                foreach (var entry in _entries)
                {
                    if (entry._prompt == prompt)
                        Console.WriteLine($"  Date: {entry._date} - Title: {entry._title}");
                }
            }
        }
    }
    