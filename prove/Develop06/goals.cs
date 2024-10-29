public abstract class Goal
{
    private string _name;
    private string _description;
    private Boolean _completed;
    private int _pointValue;

    public Goal(string name, string description,int pointValue)
    {
        _name = name;
        _description = description;
        _pointValue = pointValue;
    }




}