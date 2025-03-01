public class SimpleGoal : Goal
{

    private bool _isComplete;

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        int points = int.Parse(_points);
        _isComplete = true;
        Console.WriteLine($"Congratulations! You have earned {points} points.");    
    }

    public override bool IsComplete()
    {
        return _isComplete; 
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName}, {_description}, {_points}";
    }
}