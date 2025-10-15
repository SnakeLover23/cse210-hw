public class Swimming : Activity
{
    private int _laps;
    public Swimming(int minutes, int laps) : base(minutes)
    {
        _laps = laps;
    }
    public override double Distance()
    {
        return (_laps * 50.0) / 1000.0 * 0.62;
    }
    public override double Speed()
    {
        return (Distance() / GetMinutes()) * 60.0;
    }
    public override double Pace()
    {
        return GetMinutes() / Distance();
    }
    public override string GetActivity()
    {
        return "Swimming";
    }
}