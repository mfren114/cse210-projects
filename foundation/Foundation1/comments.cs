public class Comments
{
    public string _name;
    public string _comment;

    public void DisplayComments()
    {
        Console.WriteLine($">{_name}: {_comment}");
    }
}