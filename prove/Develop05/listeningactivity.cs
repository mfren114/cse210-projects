public class Listing : Activity
{
    private int _count;
    private List<string> _prompt;

    public Listing(string name, string description, int duration, int count) : base(name, description, duration)
    {
        _count = count;
        _prompt = new List<string>
        {
            "What are you grateful for today?",
            "What are some nice things you can say to your spouse today?",
            "What did you do with your children today?",
            "What are some of the funnest places you've been?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();
        GetRandomPrompt();
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Console.WriteLine("List as many things as you can for this prompt:");
        Console.WriteLine();
        int randomPrompt = new Random().Next(0, _prompt.Count());
        Console.WriteLine(_prompt[randomPrompt]);
    }

    public List<string> GetListFromUser()
    {
        return _prompt;
    }
}
