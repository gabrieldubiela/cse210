public abstract class Activity
{
    private int _distance;
    private int _speed;
    private int _pace;
    private date _date;
    private string _activity;

    public Activity(string name, string description, int points, int distance, int speed, int pace)
    {
        _name = name;
        _description = description;
        _points = points;
        _distance = distance;
        _speed = speed;
        _pace = pace;
    }

    public void GetSummary()
    {
        Console.WriteLine($"{_date} {_activity} ({_time} min)- Distance {_distance} km, Speed {_speed} kpm, Pace: {_pace} min per km");
    }

    public abstract void Calculate();
}