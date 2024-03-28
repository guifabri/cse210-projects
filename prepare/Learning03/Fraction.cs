public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int num)
    {
        _bottom = 1;
        _top = num;
    }

    public Fraction(int num1, int num2)
    {
        _top = num1;
        _bottom = num2;
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        return _top + "/" + _bottom;
    }

    public double GetDecimalValue()
    {
        Console.WriteLine(_top / _bottom);
        Console.WriteLine(_top);
        Console.WriteLine(_bottom);
        return (double)_top / (double)_bottom;
    }
}
