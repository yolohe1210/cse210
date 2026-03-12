using System;

public class NegativeGoal : Goal
{
    public NegativeGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[!] {_name} ({_description}) Lose {_points} points if recorded");
    }

    public override int RecordEvent()
    {
        return -_points;
    }

    public override string GetStringRepresentation()
    {
        return $"NegativeGoal:{_name},{_description},{_points}";
    }
}