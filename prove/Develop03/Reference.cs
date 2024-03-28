public class Reference
{
    private string _book; // Stores the name of the book.
    private int _chapter; // Stores the chapter number.
    private int _verse; // Stores the starting verse number.
    private int _endVerse; // Stores the ending verse number if applicable.

    // Constructor for single-verse references.
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    // Constructor for references with a range of verses.
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    // Method to obtain the display text of the reference.
    public string GetDisplayText()
    {
        // Logic to construct the display text.
        string element = $"{_book} {_chapter}:{_verse}";

        return element;
    }
}
