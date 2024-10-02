public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _time;


    public void GetDate()
    {
        DateTime currentTime = DateTime.Now;
        _date = currentTime.ToShortDateString();
    }

    public void GetTime()
    {
        //TimeOnly time = TimeOnly.
        var now = TimeOnly.FromDateTime(DateTime.Now);
        _time = now.ToShortTimeString();
    }

    public void Response()
    {
        Console.Write("> ");
        _entryText = Console.ReadLine();
    }
}