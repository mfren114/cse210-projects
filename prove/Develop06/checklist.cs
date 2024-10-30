public class CheckListGoal : Goal
{
    private string _type = "Check List";
    private int _eventTarget;
    private int _completionPoints;
    private int _eventCount;
    private int _pointValue;
    

    public CheckListGoal(string name, string description, int pointValue) : base(name, description)
    {
        _pointValue = pointValue;
    }

    public int GetPointValue()
    {
        return _pointValue;
    }
    public override void DisplayPointValue()
    {
        Console.Write("How many points is this goal worth? ");
        _pointValue = int.Parse(Console.ReadLine());
        return;
    }
    public override string ToStore()
    {
        return $"{_type}, {GetName()}, {GetDescription()}, {GetPointValue()}";
    }

    public string RecordEvent()
    {
        return "";
    }

    public string GetEventCount()
    {
        return "";
    }

    public string GetDescription()
    {
        return "";
    }

}