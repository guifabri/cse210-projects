using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        // Create products
        Product product1 = new Product
        {
            Name = "Product 1",
            ProductId = "P1",
            Price = 10,
            Quantity = 2
        };

        Product product2 = new Product
        {
            Name = "Product 2",
            ProductId = "P2",
            Price = 15,
            Quantity = 3
        };

        // Create customer
        Address address = new Address
        {
            Street = "123 Main St",
            City = "City",
            State = "State",
            Country = "USA"
        };

        Customer customer = new Customer { Name = "John Doe", Address = address };

        // Create order
        Order order = new Order
        {
            Products = new List<Product> { product1, product2 },
            Customer = customer
        };

        // Calculate total cost
        decimal totalCost = order.CalculateTotalCost();

        // Get packaging label
        string packagingLabel = order.GetPackagingLabel();

        // Get shipping label
        string shippingLabel = order.GetShippingLabel();

        // Display results
        Console.WriteLine("Total Cost: $" + totalCost);
        Console.WriteLine("Packaging Label:\n" + packagingLabel);
        Console.WriteLine("Shipping Label:\n" + shippingLabel);
    }
}
