public class Video
{
    public string _title;
    public string _author;
    public string _length;
    public List<Comments> _commentList = new List<Comments>();

    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        int commentcount = _commentList.Count();
        Console.WriteLine($"Comments {commentcount}");
        Console.WriteLine();

        foreach (Comments comment in _commentList)
        {
            comment.DisplayComments();
            Console.WriteLine();
        }

    }
}