public class Word
{
    private string _text; // Stores the text of the word.
    private bool _isHidden; // Indicates whether the word is hidden or not.

    // Constructor initializes a word with the provided text.
    public Word(string text)
    {
        _text = text;
        _isHidden = false; // By default, the word is not hidden.
    }

    // Method to hide the word.
    public void Hide()
    {
        _isHidden = true; // Sets the word as hidden.
    }

    // Method to show the word.
    public void Show()
    {
        // Logic to show the word.
        // This method is currently not implemented.
    }

    // Method to check if the word is hidden.
    public bool IsHidden()
    {
        // Returns a value indicating whether the word is hidden.
        return _isHidden;
    }

    // Method to obtain the display text of the word.
    public string GetDisplayText()
    {
        // Returns the display text of the word.
        // If the word is hidden, it returns "___", otherwise, it returns the actual text.
        if (!_isHidden)
        {
            return _text; // If not hidden, return the actual text.
        }
        else
        {
            return "___"; // If hidden, return "___".
        }
    }
}
