using System.Linq.Expressions;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    // Constructor de la clase que inicializa la referencia y la lista de palabras
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

    // Método para ocultar un número aleatorio de palabras
    // Método para ocultar un número específico de palabras de manera aleatoria
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
                break; // Si todas las palabras están ocultas, salimos del bucle
            }
        }
    }

    // Método que devuelve el texto de visualización de la referencia
    public string GetDisplayText()
    {
        // Obtiene el texto de visualización de la referencia
        string element = _reference.GetDisplayText();
        string verse = null;
        // Recorrer el array y componer la frase
        foreach (Word word in _words)
        {
            verse += word.GetDisplayText() + " ";
        }

        return $"{element} {verse}";
    }

    // Método que verifica si todas las palabras están completamente ocultas
    // Método que verifica si todas las palabras están completamente ocultas
    public bool IsCompletelyHidden()
    {
        // Verifica si todas las palabras están completamente ocultas
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false; // Si encuentra una palabra no oculta, retorna false
            }
        }

        return true; // Si todas las palabras están ocultas, retorna true
    }
}
