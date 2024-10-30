public class SimpleGoal : Goal
{
    private string _type = "simple";
    private int _pointValue;

    public SimpleGoal(string name, string description, int pointValue) : base(name, description)
    {
        _pointValue = pointValue;
    }
    public override void DisplayPointValue()
    {
        Console.Write("How many points is this goal worth? ");
        _pointValue = int.Parse(Console.ReadLine());
        return;
    }
    public int GetPointValue()
    {
        return _pointValue;
    }

    public override string ToStore()
    {
        return $"{_type}, {GetName()}, {GetDescription()}, {GetPointValue()}";
    }
    
    public string RecordEvent()
    {
        return "";
    }
}