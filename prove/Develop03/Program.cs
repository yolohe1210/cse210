// Beyond the basic requirements, this program also includes a Library class
// that allows a random scripture to be displayed each time the program runs.
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
