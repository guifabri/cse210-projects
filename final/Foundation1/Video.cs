using System;
using System.Collections.Generic;

class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Duration { get; set; }
    public List<VideoComment> Comments { get; set; }

    public Video(string title, string author, int duration)
    {
        Title = title;
        Author = author;
        Duration = duration;
        Comments = new List<VideoComment>();
    }

    public void AddComment(VideoComment comment)
    {
        Comments.Add(comment);
    }

    public int NumComments()
    {
        return Comments.Count;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Duration: {Duration} seconds");
        Console.WriteLine($"Number of Comments: {NumComments()}");
        Console.WriteLine("Comments:");
        foreach (var comment in Comments)
        {
            comment.ShowInfo();
        }
    }
}
