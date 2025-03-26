using System.Transactions;

public class Video
{
    private string _title;

    private string _author;

    private int _length;

    private int _commentCount;

    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment newComment)
    {
        _comments.Add(newComment);
    }

    public void DisplayComment()
    {
        foreach(Comment comment in _comments)
        {
            comment.Display();
        }
    }

    public void DisplayVideo()
    {
        Console.WriteLine(_title);
        Console.WriteLine($"author: {_author}");
        Console.WriteLine($"length in seconds: {_length}");
        Console.WriteLine($"{_commentCount} comments");
    }

    public void CommentCount()
    {
        _commentCount = _comments.Count;
    }
}