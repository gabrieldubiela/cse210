public class Video {

private string _title;
private string _author;
private int _length;
private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }
    public int GetNumberOfComments() 
    {
        return _comments.Count;
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void Display () 
    {
        Console.WriteLine($"Title: {_title}\nAuthor: {_author}\nLength: {_length} seconds\nNumber of Comments: {GetNumberOfComments()}");
        foreach (var comment in _comments) 
        {
            Console.WriteLine(comment.Display());
        }
        Console.WriteLine("");
    }
}