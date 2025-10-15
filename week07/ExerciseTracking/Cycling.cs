public class Cycling : Activity
{
    private double _speed;
    public Cycling(int minutes, double speed) : base(minutes)
    {
        _speed = speed;
    }
    public override double Distance()
    {
        double hours = GetMinutes() / 60.0;
        return _speed * hours;
    }
    public override double Speed()
    {
        return _speed;
    }
    public override double Pace()
    {
        return GetMinutes() / Distance();
    }
    public override string GetActivity()
    {
        return "Cycling";
    }
}