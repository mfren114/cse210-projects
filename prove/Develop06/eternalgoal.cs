public class EternalGoal : Goal
{
    private string _type = "Eternal";
    private int _eventCount;
    private int _pointValue;
    
    public EternalGoal(string name, string description, int eventCount, int pointValue) : base(name, description)
    {
        _eventCount = eventCount;
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

    
    public string RecordEvent()
    {
        return "";
    }

    public int GetEventCount()
    {
        return 0;
    }

}