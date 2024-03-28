using System.Linq.Expressions;

public class Scripture
{
    private Reference _reference; // Reference object for the scripture.
    private List<Word> _words; // List to store individual words of the scripture.

    // Constructor initializes the reference and word list.
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] verseList = text.Split(' ');
        foreach (string element in verseList)
        {
            _words.Add(new Word(element));
        }
    }

    // Method to hide a random number of words.
    public void HideRandomWords(int numberToHide)
    {
        Random rnd = new Random();
        int wordsHidden = 0;

        while (wordsHidden < numberToHide)
        {
            int randomIndex = rnd.Next(0, _words.Count);

            if (!_words[randomIndex].IsHidden())
            {
                _words[randomIndex].Hide();
                wordsHidden++;
            }

            if (IsCompletelyHidden())
            {
                break; // Exit loop if all words are hidden.
            }
        }
    }

    // Method to get the display text of the scripture.
    public string GetDisplayText()
    {
        // Get the display text of the reference.
        string element = _reference.GetDisplayText();
        string verse = null;
        // Iterate through the array and compose the verse.
        foreach (Word word in _words)
        {
            verse += word.GetDisplayText() + " ";
        }

        return $"{element} {verse}";
    }

    // Method to check if all words are completely hidden.
    public bool IsCompletelyHidden()
    {
        // Check if all words are completely hidden.
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false; // If any word is not hidden, return false.
            }
        }

        return true; // If all words are hidden, return true.
    }
}
