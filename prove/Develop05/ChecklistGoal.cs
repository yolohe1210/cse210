using System;

public class ChecklistGoal : Goal
{
    private int _completed;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _completed = 0;
    }

    public override bool IsComplete()
    {
        return _completed >= _target;
    }

    public override void DisplayGoal()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {_name} ({_description}) -- {_completed}/{_target}");
    }

    public override int RecordEvent()
    {
        _completed++;

        if (_completed == _target)
        {
            return _points + _bonus;
        }

        return _points;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_name},{_description},{_points},{_target},{_bonus},{_completed}";
    }
}
