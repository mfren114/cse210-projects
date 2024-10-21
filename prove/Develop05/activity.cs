using System.Diagnostics;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    static int _spinner = 0;
    static int userDuration = 0;
    private int _userDuration;

    public Activity(string name, string description, int userDuration)
    {
        _name = name;
        _description = description;
        _duration = userDuration;
    }

    public void DisplayStartingMessage()
    {
        _duration = userDuration;
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine("");
        Console.WriteLine($"{_description}.");
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like for your session? ");
        _userDuration = int.Parse(Console.ReadLine());
        Console.WriteLine("");
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine("");
        ShowCountDown(5);

    }

    public int SessionLength()
    {
        return _userDuration;
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!! You've completed the activity.");
    }

    public void ShowSpinner(int numSeconds)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.ElapsedMilliseconds / 301 < numSeconds)
        {
            _spinner++;
            switch (_spinner % 4)
            {
                case 0: Console.Write("+"); break;
                case 1: Console.Write("x"); break;
                case 2: Console.Write("+"); break;
                case 3: Console.Write("x"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(200);
        }
        Console.Write(" ");
    }

    public void ShowCountDown(int numSeconds)
    {
        for (int i = numSeconds; i >= 1; i--)
        {
            Console.Write($"Begin in {i}");
            Console.SetCursorPosition(0, Console.CursorTop);
            Thread.Sleep(1000);
        }
    }

}