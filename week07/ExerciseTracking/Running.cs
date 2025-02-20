public class Running : Activity
{
    private int _distance;
    private int _speed;
    private int _pace;

    public Running(string activity, DateTime date, int min, int distance) : base(activity, date, min, distance)
    {
        _distance = distance;
    }


    public override void Calculate()
    {
        _pace = _time / _distance;
        _speed = _distance / _time * 60;
    }

    public override string DisplayInfo()
    {
        return $"Distance {_distance} km, Speed {_speed} kpm, Pace: {_pace} min per km";
    }
}