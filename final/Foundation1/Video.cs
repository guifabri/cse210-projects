using System;
using System.Collections.Generic;

class Video
{
    private string Title { get; set; }
    private string Author { get; set; }
    private int Duration { get; set; }
    private List<VideoComment> Comments { get; set; }

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
