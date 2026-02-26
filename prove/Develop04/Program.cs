// Creativity and Exceeding Requirements:
// Keeping a log of how many times activities were performed.
// Make sure no random prompts/questions are selected until they have all been used at least once in that session.
using System;

class Program
{
    static void Main(string[] args)
    {
        Activity activity = new Activity();
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
            Console.Write("Select a choice from the menu: ");
            
            string choice = Console.ReadLine();
            if (choice == "1" || choice == "2" || choice == "3") 
            {
                Console.Clear();
                activity.ExecuteActivity(choice);
                if (choice == "1") {
                    bCount ++;
                }
                else if (choice == "2") {
                    rCount ++;
                }
                else if (choice == "3") {
                    lCount ++;
                }
                Console.WriteLine("\n--- Activity Log ---");
                Console.WriteLine($"Breathing: {bCount} | Reflecting: {rCount} | Listing: {lCount}");
                Console.WriteLine("\nPress Enter to return to the menu...");
                Console.ReadLine();
            }
            else if (choice == "4") 
            {
                break;
            }
            else 
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        }
    }
}