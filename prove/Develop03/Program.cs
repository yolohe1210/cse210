// Beyong the basic requirement, I also add a Library class that allows 
// the program to randomly show different scriptures when the user runs it.
using System;
class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();
        Scripture scripture = library.GetRandomScripture();
        while (true)
        {
            Console.Clear();
            scripture.Display();
            if (scripture.AllWordsHidden())
            {
                break;
            }
            Console.Write("\nPress Enter to continue or type 'quit' to finish: ");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }
            scripture.HideRandomWords(3);
        }
    }
}
