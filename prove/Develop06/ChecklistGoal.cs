public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            Console.WriteLine($"Progress recorded! You earned {_points} points.");
            if (_amountCompleted == _target)
            {
                Console.WriteLine($"Goal completed! You earned a bonus of {_bonus} points.");
            }
        }
        else
        {
            Console.WriteLine("This goal is already complete.");
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} - Completed {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_name},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
    }
}
