public abstract class Activity
{
    private DateTime _date = DateTime.Now;
    private int _minutes;
    public Activity(int minutes)
    {
        _minutes = minutes;
    }
    public int GetMinutes()
    {
        return _minutes;
    }
    public DateOnly GetDate()
    {
        return DateOnly.FromDateTime(_date);
    }
    public abstract double Distance();
    public abstract double Speed();
    public abstract double Pace();
    public abstract string GetActivity();
    public string GetSummary()
    {
        return $"{GetDate()} {GetActivity()} ({GetMinutes()} minutes): Distance {Distance()} miles, speed {Speed()} mph, Pace: {Pace()} min per mile";
    }
}