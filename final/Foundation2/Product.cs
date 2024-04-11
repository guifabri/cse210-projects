public class Product
{
    private string _name;
    private string _productId;
    private decimal _price;
    private int _quantity;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string ProductId
    {
        get { return _productId; }
        set { _productId = value; }
    }

    public decimal Price
    {
        get { return _price; }
        set { _price = value; }
    }

    public int Quantity
    {
        get { return _quantity; }
        set { _quantity = value; }
    }

    public decimal CalculateTotalCost()
    {
        return _price * _quantity;
    }
}
