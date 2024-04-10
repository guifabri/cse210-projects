class VideoComment
{
    public string Name { get; set; }
    public string Text { get; set; }

    public VideoComment(string name, string text)
    {
        Name = name;
        Text = text;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Comment: {Text}");
        Console.WriteLine();
    }
}
