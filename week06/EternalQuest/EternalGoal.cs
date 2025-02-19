public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        int points = int.Parse(_goals[_goalOption]._points);
        Console.WriteLine($"Congratulations! You have earned {points} points.");    
        _score += points;
        CheckLevelUp();
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName},{_description},{_points}";
    }
}