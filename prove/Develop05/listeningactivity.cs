public class Listing : Activity
{
    private int _count;
    private List<string> _prompt;

    public Listing(string name, string description, int duration, int count) : base(name, description, duration)
    {
        _count = count;
    }

    public void Run()
    {
        DisplayStartingMessage();
    }

    public string GetRandomPrompt()
    {
        return "";
    }

    public List<string> GetListFromUser()
    {
        return _prompt;
    }
}
