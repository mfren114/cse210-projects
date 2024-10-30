using System.ComponentModel;

public abstract class Goal
{
    private string _name;
    private string _description;
   

    public Goal(string name, string description)
    {
        _name = name;
        _description = description;
        
    }

    public string GetName()
    {
        return _name;
    }

    public void setName(string name)
    {
        _name = name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public abstract void DisplayPointValue();


}