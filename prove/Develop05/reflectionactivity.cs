public class Reflection : Activity
{
private List<string> _prompts;
private List<string> _questions;

public Reflection(string name, string description, int duration) : base(name, description, duration)
    {
        _prompts = new List<string>
        {
            "Think of a time when you did something really difficult",
            "Think of a time when you did something really crazy",
            "Think of a time when you laughed really hard",
            "Think of a time when you felt extreme joy"
        };
        _questions = new List<string>
        {
            "How does this make you feel now?",
            "Would you do that again?",
            "How long ago was?",
            "What if you did that now?"
        };
    }

public void Run()
{
    DisplayStartingMessage();
    DisplayPrompt();
    DisplayQuestions();
    DisplayEndingMessage();
}

public void DisplayPrompt()
{
    Console.WriteLine("Take time to think on this prompt.");
    Console.WriteLine();

    int randomPrompt = new Random().Next(0, _prompts.Count);
    Console.WriteLine(_prompts[randomPrompt]);
    Console.WriteLine();

    Console.WriteLine("Once a thought comes to mind press ENTER.");
    Console.WriteLine();
}

public void DisplayQuestions()
{
    List<int> indexes = new List<int>();

    for (int i = 0; i < 4; i++);
    {
        int randomInt = new Random().Next(0, _questions.Count());
        while ( indexes.Contains(randomInt))
        {
            randomInt = new Random().Next(0, _questions.Count());
        }
        indexes.Add(randomInt);

    }
    Console.Clear();
    Console.WriteLine("Think on this question in relation to your experience.");
    
}

}