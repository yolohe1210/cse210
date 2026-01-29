// Creativity:
// This program exceeds the core requirements by randomly generating journal prompts,
// storing the prompt with each journal entry, safely handling file loading when the file
// does not yet exist, and allowing entries to be displayed grouped by their prompt.

using System;
class Program
{
    static void Main(string[] args)
    {
        bool isRunning = true;
        Journal myJournal = new Journal();

        while (isRunning)
        {
            Console.WriteLine("\nPlease choose one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("6. Display by Prompt");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Writing a new entry...");
                Prompt prompt1 = new Prompt();
                string prompt = prompt1.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");

                string date = DateTime.Now.ToShortDateString();

                Console.Write("Title: ");
                string title = Console.ReadLine();

                Console.Write("Entry: ");
                string text = Console.ReadLine();

                Entry entry1 = new Entry(date, prompt, title, text);
                myJournal.AddEntry(entry1);
            }
            else if (choice == "2")
            {
                myJournal.DisplayAll();
            }
            else if (choice == "3")
            {
                myJournal.LoadFromFile();
            }
            else if (choice == "4")
            {
                myJournal.SaveToFile();
            }
            else if (choice == "5")
            {
                isRunning = false;
            }
            else if (choice == "6")
            {
                myJournal.DisplayByPrompt();
            }
            else
            {
                Console.WriteLine("Invalid command.");
            }
        }

        Console.WriteLine("Program ended.");
    }
}