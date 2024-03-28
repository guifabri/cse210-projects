public class Word
{
    private string _text;
    private bool _isHidden;

    // Constructor que inicializa una palabra con el texto proporcionado
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Método para ocultar la palabra
    public void Hide()
    {
        _isHidden = true;
    }

    // Método para mostrar la palabra
    public void Show()
    {
        // Lógica para mostrar la palabra
    }

    // Método para verificar si la palabra está oculta
    public bool IsHidden()
    {
        // Devuelve un valor que indica si la palabra está oculta
        return _isHidden;
    }

    // Método para obtener el texto de visualización de la palabra
    public string GetDisplayText()
    {
        // Devuelve el texto de visualización de la palabra
        if (!_isHidden)
        {
            return _text;
        }
        else
        {
            return "___";
        }
    }
}
