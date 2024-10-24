public class Running : Activity
{
    private double _distance;

    public Running(double length, double distance) : base(length)
    {
        _distance = distance;
    }

    public override double CalculateDistance()
    {
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
        Console.WriteLine($"{GetDate()} Running {GetLength()} (mins) - Distance {CalculateDistance()} Miles - Speed {CalculateSpeed()} MPH - Pace {CalculatePace()} min per mile");
    }
}