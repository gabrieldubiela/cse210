public abstract class Activity
{
    protected DateTime _date;
    protected string _activity;
    protected int _time;

    public Activity(string activity, DateTime date, int min, int distance)
    {
        _activity = activity;
        _date = date;
        _time = min;
    }

    public virtual void GetSummary()
    {
        Console.WriteLine($"{_date} {_activity} ({_time} min)- {DisplayInfo()}");
    }

    public abstract void Calculate();

    public abstract string DisplayInfo();

}