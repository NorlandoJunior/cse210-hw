using System;
using System.Collections.Generic;

public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Duration { get; set; }  
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int duration)
    {
        Title = title;
        Author = author;
        Duration = duration;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {Title} | Author: {Author} | Duration: {Duration} sec");
        Console.WriteLine($"Comments ({GetCommentCount()}):");
        foreach (var comment in _comments)
        {
            comment.DisplayComment();
        }
        Console.WriteLine();
    }
}
