public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // Constructor para referencias con un solo versículo
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    // Constructor para referencias con rango de versículos
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    // Método para obtener el texto de visualización de la referencia
    public string GetDisplayText()
    {
        // Lógica para construir el texto de visualización
        string element = $"{_book} {_chapter}:{_verse}";

        return element;
    }
}
