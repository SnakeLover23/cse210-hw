using System.Security.Cryptography.X509Certificates;

public class Running : Activity
{
    private double _distance;
    public Running(int minutes, double distance) : base(minutes)
    {
        _distance = distance;
    }
    public override double Distance()
    {
        return _distance;
    }
    public override double Speed()
    {
        return (_distance / GetMinutes()) * 60;
    }
    public override double Pace()
    {
        return GetMinutes() / _distance;
    }
    public override string GetActivity()
    {
        return "Running";
    }
}