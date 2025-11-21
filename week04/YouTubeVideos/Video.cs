using System;
using System.Configuration.Assemblies;
class Video
{
    private string _title;
    private string _author;
    private int _length;
    private int _amountOfComments;
    private List<Comment> _comments = new List<Comment>();

    public void setVideo(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void addComment(string name, string contents)
    {
        Comment comment = new Comment();
        comment.createComment(name, contents);
        _comments.Add(comment);
        _amountOfComments = _comments.Count;
    }

    public void displayVideo()
    {
        Console.WriteLine($"Video Title: {_title}");
        Console.WriteLine($"Video Author: {_author}");
        Console.WriteLine($"Video Length: {_length} seconds");
        Console.WriteLine($"Amount of Comments: {_amountOfComments}");
    }

    public void displayComments()
    {
        foreach (Comment comment in _comments)
        {
            comment.displayText();
        }
    }
}