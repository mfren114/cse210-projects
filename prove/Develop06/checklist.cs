public class CheckListGoal : Goal
{
    private int _eventTarget;
    private int _completionPoints;
    private int _eventCount;

    public CheckListGoal(string name, string description, int pointValue) : base(name, description, pointValue)
    {

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