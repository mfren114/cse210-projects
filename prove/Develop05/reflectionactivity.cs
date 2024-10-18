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
}

public string GetRandomPrompt()
{
    return "";
}

public string GetRandomQuestion()
{
    return "";
}

public void DisplayPrompt()
{

}

public void DisplayQuestions()
{

}

}