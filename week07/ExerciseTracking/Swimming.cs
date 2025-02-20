public class Swimming : Activity
{
    private int _laps;
    private int _distance;
    private int _speed;
    private int _pace;

    public Swimming(string activity, DateTime date, int min, int distance) : base(activity, date, min, distance)
    {
        _distance = distance;
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{_date} {_activity} ({_time} min)- {DisplayInfo()}");
    }

    public override void Calculate()
    {
        _pace = _time / _distance;
        _speed = _distance / _time * 60;
        _laps = _distance / 50;
    }

    public override string DisplayInfo()
    {
        return $"Laps: {_laps}, Distance {_distance} km, Speed {_speed} kpm, Pace: {_pace} min per km";
    }
}