public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        // Record the event
    }

    public override bool IsComplete()
    {
        // Check if the goal is complete
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName} - {_description} - {_points}";
    }
}