using System;
using System.Collections.Generic;

public class Channel
{
    public string ChannelName { get; set; }
    public int SubscribersCount { get; private set; }
    public string ChannelDescription { get; set; }
    private List<Video> _videos = new List<Video>();

    public Channel(string name, string description)
    {
        ChannelName = name;
        ChannelDescription = description;
        SubscribersCount = 0;
    }

    public void UploadVideo(Video video)
    {
        _videos.Add(video);
        Console.WriteLine($"New video uploaded: {video.Title}");
    }

    public void DeleteVideo(Video video)
    {
        _videos.Remove(video);
        Console.WriteLine($"Video deleted: {video.Title}");
    }

    public void IncreaseSubscribers()
    {
        SubscribersCount++;
    }

    public void DisplayChannel()
    {
        Console.WriteLine($"Channel: {ChannelName} | Subscribers: {SubscribersCount}");
        Console.WriteLine("Videos:");
        foreach (var video in _videos)
        {
            video.DisplayVideo();
        }
    }
}
