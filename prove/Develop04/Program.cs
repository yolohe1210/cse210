// Creativity and Exceeding Requirements:
// 1. Keeping a log of how many times activities were performed.
// 2. Ensuring prompts/questions are not repeated until all are used.

using System;

class Program
{
    static void Main(string[] args)
    {
        int bCount = 0;
        int rCount = 0;
        int lCount = 0;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("\nMenu options:");
            Console.WriteLine("   1. Start breathing activity");
            Console.WriteLine("   2. Start reflecting activity");
            Console.WriteLine("   3. Start listing activity");
            Console.WriteLine("   4. Quit");
            Console.Write("Select a choice: ");

            string choice = Console.ReadLine().Trim();

            Activity activity = null;

            if (choice == "1")
            {
                activity = new Breathing();
                bCount++;
            }
            else if (choice == "2")
            {
                activity = new Reflecting();
                rCount++;
            }
            else if (choice == "3")
            {
                activity = new Listing();
                lCount++;
            }
            else if (choice == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input.");
                Console.ReadLine();
                continue;
            }

            Console.Clear();

            activity.DisplayStartingMessage();
            activity.Run();   
            activity.DisplayEndingMessage();

            Console.WriteLine("\n--- Activity Log ---");
            Console.WriteLine($"Breathing: {bCount} | Reflecting: {rCount} | Listing: {lCount}");

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }
}