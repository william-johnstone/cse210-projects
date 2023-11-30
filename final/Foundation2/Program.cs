class Program
{
    static void Main()
    {
        // Creating addresses with street, city, province, country
        Address usaAddress = new Address("123 Main St", "Smallville", "KS", "USA");
        Address internationalAddress = new Address("456 International St", "Toronto", "Ontario", "Canada");

        // Creating customers with name and address
        Customer usaCustomer = new Customer("Joe Young", usaAddress);
        Customer internationalCustomer = new Customer("Mary Cowdery", internationalAddress);

        // Creating products with name, productid, price, quantity
        Product product1 = new Product("Bees wax", 1, 10.99m, 2);
        Product product2 = new Product("Hair dryer", 2, 5.99m, 1);
        Product product3 = new Product("Combs", 3, .99m, 20);

        // Creating orders with customer, product
        Order order1 = new Order(usaCustomer, new List<Product> { product1, product2 });
        Order order2 = new Order(internationalCustomer, new List<Product> { product1, product2 });
        Order order3 = new Order(internationalCustomer, new List<Product> { product3, product2 });

        // Displaying Orders
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalCost():F2}\n");

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalCost():F2}\n");

        Console.WriteLine("Order 3:");
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order3.CalculateTotalCost():F2}\n");
    }
}