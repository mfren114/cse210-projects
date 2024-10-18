public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine("");
        Console.WriteLine($"{_description}.");
        Console.WriteLine("");
        
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!! You've completed the activity.");
    }

    public void ShowSpinner(int seconds)
    {

    }

    public void ShowCountDown(int seconds)
    {

    }
}