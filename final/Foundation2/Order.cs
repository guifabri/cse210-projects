public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public List<Product> Products
    {
        get { return _products; }
        set { _products = value; }
    }

    public Customer Customer
    {
        get { return _customer; }
        set { _customer = value; }
    }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;

        foreach (Product product in _products)
        {
            totalCost += product.CalculateTotalCost();
        }

        if (_customer.IsInUSA())
        {
            totalCost += 5; // Shipping cost for customers in the USA
        }
        else
        {
            totalCost += 35; // Shipping cost for customers outside the USA
        }

        return totalCost;
    }

    public string GetPackagingLabel()
    {
        string packagingLabel = "";

        foreach (Product product in _products)
        {
            packagingLabel += $"Product: {product.Name}, ID: {product.ProductId}\n";
        }

        return packagingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = $"Customer: {_customer.Name}\n";
        shippingLabel += $"Address: {_customer.Address.GetFullAddress()}";

        return shippingLabel;
    }
}
