using System;

class Comment
{
    private string _name;
    private string _comment;

    public void createComment(string name, string comment)
    {
        _name = name;
        _comment = comment;
    }

    public void displayText()
    {
        Console.WriteLine($"{_name}: \"{_comment}\"");
    }
}