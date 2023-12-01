class Program
{
    static void Main()
    {
        // Creating addresses with street, city, province, country
        Address address1 = new Address("123 Main St", "Smallville", "KS", "USA");
        Address address2 = new Address("456 International St", "Toronto", "Ontario", "Canada");

        // Creating customers with name and address
        Customer customer1 = new Customer("Joe Young", address1);
        Customer customer2 = new Customer("Mary Cowdery", address2);

        // Creating products with name, productid, price, quantity
        Product product1 = new Product("Bees wax", 1, 10.99m, 2);
        Product product2 = new Product("Hair dryer", 2, 5.99m, 1);
        Product product3 = new Product("Combs", 3, .99m, 20);

        // Creating orders with customer, product
        Order order1 = new Order(customer1, new List<Product> { product1, product2 });
        Order order2 = new Order(customer2, new List<Product> { product1, product2 });
        Order order3 = new Order(customer2, new List<Product> { product3, product2 });

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