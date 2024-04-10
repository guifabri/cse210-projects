using System;

class Program
{
    static void Main()
    {
        Video video1 = new Video("Video Title 1", "Author 1", 120);
        video1.AddComment(new VideoComment("User1", "Great video!"));
        video1.AddComment(new VideoComment("User2", "Awesome content"));

        Video video2 = new Video("Video Title 2", "Author 2", 180);
        video2.AddComment(new VideoComment("User3", "Interesting topic"));
        video2.AddComment(new VideoComment("User4", "Very informative"));

        Video video3 = new Video("Video Title 3", "Author 3", 150);
        video3.AddComment(new VideoComment("User5", "Great job!"));
        video3.AddComment(new VideoComment("User6", "Loved it"));

        List<Video> videosList = new List<Video> { video1, video2, video3 };

        foreach (var video in videosList)
        {
            video.ShowInfo();
            Console.WriteLine();
        }
    }
}
