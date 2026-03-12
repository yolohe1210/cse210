// EXCEEDING REQUIREMENTS:
// Added a NegativeGoal class that deducts points when recorded.
// This allows tracking bad habits and makes the goal system more realistic.

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int totalPoints = 0;
        List<Goal> goals = new List<Goal>();

        while (true)
        {
            Console.WriteLine($"\nYou have {totalPoints} points.");

            Console.WriteLine("\nMenu options:");
            Console.WriteLine("  1. Create new goal");
            Console.WriteLine("  2. List goals");
            Console.WriteLine("  3. Save goals");
            Console.WriteLine("  4. Load goals");
            Console.WriteLine("  5. Record event");
            Console.WriteLine("  6. Quit");

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("\nTypes of goals:");
                Console.WriteLine(" 1. Simple Goal");
                Console.WriteLine(" 2. Eternal Goal");
                Console.WriteLine(" 3. Checklist Goal");
                Console.WriteLine(" 4. Negative Goal (lose points)");

                Console.Write("What type of goal would you like to create? ");
                string goalType = Console.ReadLine();

                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();

                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();

                Console.Write("What is the amount of points associated with this goal? ");
                int points = int.Parse(Console.ReadLine());

                if (goalType == "1")
                {
                    goals.Add(new SimpleGoal(name, description, points));
                }
                else if (goalType == "2")
                {
                    goals.Add(new EternalGoal(name, description, points));
                }
                else if (goalType == "3")
                {
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int repeat = int.Parse(Console.ReadLine());

                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonus = int.Parse(Console.ReadLine());

                    goals.Add(new ChecklistGoal(name, description, points, repeat, bonus));
                }
                else if (goalType == "4")
                {
                    goals.Add(new NegativeGoal(name, description, points));
                }
            }

            else if (choice == "2")
            {
                Console.WriteLine("\nGoals:");

                for (int i = 0; i < goals.Count; i++)
                {
                    Console.Write($"{i + 1}. ");
                    goals[i].DisplayGoal();
                }
            }

            else if (choice == "3")
            {
                Console.Write("What is the filename for your goal file? ");
                string filename = Console.ReadLine();

                SaveLoad saver = new SaveLoad(filename);
                saver.SaveGoals(goals, totalPoints);
            }

            else if (choice == "4")
            {
                Console.Write("What is the filename for your goal file? ");
                string filename = Console.ReadLine();

                SaveLoad loader = new SaveLoad(filename);
                totalPoints = loader.LoadGoals(goals);
            }

            else if (choice == "5")
            {
                Console.WriteLine("The goals are:");

                for (int i = 0; i < goals.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {goals[i].GetName()}");
                }

                Console.Write("Which goal did you accomplish? ");
                int index = int.Parse(Console.ReadLine()) - 1;

                int earned = goals[index].RecordEvent();
                totalPoints += earned;

                Console.WriteLine($"Congratulations! You earned {earned} points!");
                Console.WriteLine($"You now have {totalPoints} points.");
            }

            else if (choice == "6")
            {
                break;
            }
        }
    }
}
