public class EternalGoal : Goal
{
    private int _eventCount;
    
    public EternalGoal(string name, string description, int pointValue) : base(name, description, pointValue)
    {

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