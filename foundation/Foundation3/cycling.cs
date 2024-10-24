using System.IO.Pipes;

public class Cycling : Activity
{
    private double _speed {get; set;}

    public Cycling(double length, double speed) : base(length)
    {
        _speed = speed;
    }

    public override double CalculateDistance()
    {
        double _distance = GetLength() * CalculateSpeed();
        return _distance;
    }

    public override double CalculateSpeed()
    {
        return _speed;
    }

    public override double CalculatePace()
    {
        double _pace = CalculateDistance() / GetLength();
        return _pace;
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{GetDate()} Cycling {GetLength()} (mins) - Distance {CalculateDistance()} Miles - Speed {CalculateSpeed()} MPH - Pace {CalculatePace()} min per mile");
    }
}

