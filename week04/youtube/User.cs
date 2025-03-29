using System;

public class User
{
    public string Username { get; set; }
    public string Email { get; set; }
    private string Password { get; set; }

    public User(string username, string email, string password)
    {
        Username = username;
        Email = email;
        Password = password;
    }

    public bool Login(string email, string password)
    {
        return Email == email && Password == password;
    }

    public void Subscribe(Channel channel)
    {
        channel.IncreaseSubscribers();
        Console.WriteLine($"{Username} subscribed to {channel.ChannelName}");
    }

    public void CommentOnVideo(Video video, string commentText)
    {
        video.AddComment(new Comment(Username, commentText));
    }
}
