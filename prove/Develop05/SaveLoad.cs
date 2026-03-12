using System;
using System.Collections.Generic;
using System.IO;

public class SaveLoad
{
    private string _filename;

    public SaveLoad(string filename)
    {
        _filename = filename;
    }

    public void SaveGoals(List<Goal> goals, int totalPoints)
    {
        using (StreamWriter writer = new StreamWriter(_filename))
        {
            writer.WriteLine(totalPoints);

            foreach (Goal g in goals)
            {
                writer.WriteLine(g.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved.");
    }

    public int LoadGoals(List<Goal> goals)
    {
        if (!File.Exists(_filename))
        {
            Console.WriteLine("File not found.");
            return 0;
        }

        string[] lines = File.ReadAllLines(_filename);

        int totalPoints = 0;
        if (int.TryParse(lines[0], out int score))
        {
            totalPoints = score;
        }
        else
        {
            totalPoints = 0;
        }

        goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(':');

            string type = parts[0];
            string[] data = parts[1].Split(',');

            if (type == "SimpleGoal")
            {
                SimpleGoal g = new SimpleGoal(data[0], data[1], int.Parse(data[2]));
                if (bool.Parse(data[3])) g.RecordEvent();
                goals.Add(g);
            }

            else if (type == "EternalGoal")
            {
                goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
            }

            else if (type == "ChecklistGoal")
            {
                ChecklistGoal g = new ChecklistGoal(
                    data[0],
                    data[1],
                    int.Parse(data[2]),
                    int.Parse(data[3]),
                    int.Parse(data[4])
                );

                int completed = int.Parse(data[5]);

                for (int j = 0; j < completed; j++)
                {
                    g.RecordEvent();
                }

                goals.Add(g);
            }

            else if (type == "NegativeGoal")
            {
                goals.Add(new NegativeGoal(data[0], data[1], int.Parse(data[2])));
            }
        }

        Console.WriteLine("Goals loaded.");

        return totalPoints;
    }
}
