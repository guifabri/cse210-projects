public class Order
{
    public List<Product> Products { get; set; }
    public Customer Customer { get; set; }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;

        foreach (Product product in Products)
        {
            totalCost += product.CalculateTotalCost();
        }

        if (Customer.IsInUSA())
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

        foreach (Product product in Products)
        {
            packagingLabel += $"Product: {product.Name}, ID: {product.ProductId}\n";
        }

        return packagingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = $"Customer: {Customer.Name}\n";
        shippingLabel += $"Address: {Customer.Address.GetFullAddress()}";

        return shippingLabel;
    }
}
