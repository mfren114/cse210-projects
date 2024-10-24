public class Swimming : Activity
{
    private double _laps;

    public Swimming(double length, double laps) : base(length)
    {
        _laps = laps;
    }

    public override double CalculateDistance()
    {
        double _distance = _laps * 50 / 1000 * 0.62;
        return _distance;
    }

    public override double CalculateSpeed()
    {
        double _speed = CalculateDistance() / GetLength() * 60;
        return _speed;
    }

    public override double CalculatePace()
    {
        double _pace = GetLength() / CalculateDistance();
        return _pace;
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{GetDate()} Swimming {GetLength()} (mins) - Distance {CalculateDistance()} Laps - Speed {CalculateSpeed()} MPH - Pace {CalculatePace()} min per lap");
    }
}