public class Goal
{
    private string _shortName;
    private string _description;
    private string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        if (isComplete())
        {
            return $"[X] - {_shortName} - {_description} - {_points}";
        }
        else
        {
            return $"[ ] - {_shortName} - {_description} - {_points}";
        }
    }

    public abstract string GetStringRepresentation();
}