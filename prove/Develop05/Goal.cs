using System;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _name;
    }

    public virtual void DisplayGoal()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {_name} ({_description})");
    }

    public abstract bool IsComplete();

    public abstract int RecordEvent();

    public abstract string GetStringRepresentation();
}
