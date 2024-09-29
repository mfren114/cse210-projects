public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;


    public void GetDate()
    {
        DateTime currentTime = DateTime.Now;
        _date = currentTime.ToShortDateString();
    }

    public void Response()
    {
        Console.Write("> ");
        _entryText = Console.ReadLine();
    }
}