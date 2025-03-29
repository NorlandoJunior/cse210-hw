using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
       
        User user1 = new User("Alice", "alice@example.com", "password123");
        User user2 = new User("Bob", "bob@example.com", "securepass");
        
        
        Channel myChannel = new Channel("Tech Insights", "Technology news and reviews");

        
        Video video1 = new Video("How works Encapsulation", "Tech Guru", 600);
        Video video2 = new Video("Top 10 Programming Languages", "Code Master", 900);
        Video video3 = new Video("Web Development Trends 2025", "Dev Pro", 750);

       
        myChannel.UploadVideo(video1);
        myChannel.UploadVideo(video2);
        myChannel.UploadVideo(video3);

       
        user1.CommentOnVideo(video1, "Great explanation!");
        user2.CommentOnVideo(video1, "Very insightful!");
        user1.CommentOnVideo(video2, "Loved the content!");

        
        user1.Subscribe(myChannel);
        user2.Subscribe(myChannel);

        
        myChannel.DisplayChannel();
    }
}

