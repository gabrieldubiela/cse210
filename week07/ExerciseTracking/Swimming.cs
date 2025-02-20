public class Swimming : Activity
{
    private int _speed;
    private int _distance;
    private int _time;

    public Swimming(string name, string description, int points, int speed, int distance, int time) : base(name, description, points)
    {
        _speed = speed;
        _distance = distance;
        _time = time;
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {_points} points.");
    }

    public override string GetStringRepresentation()
    {
        return $"{_name}, {_description}, {_points}, {_speed}, {_distance}, {_time}";
    }
}