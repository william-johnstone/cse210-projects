class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer, List<Product> products)
    {
        this.customer = customer;
        this.products = products;
    }

    public decimal CalculateTotalCost()
    {
        decimal total = 0;
        foreach (var product in products)
        {
            total += product.GetTotalPrice();
        }

        // Adding shipping cost based on if the customer is in USA or not
        if (customer.IsInUSA() is true)
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    public string GetPackingLabel()
    {
        //write out Packing Label and then loop through products and print a newline for each one
        string packingLabel = "Packing Label:\n";
        foreach (var product in products)
        {
            packingLabel += $"{product.GetProductInfo()}\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{nameof(customer)}: {customer.GetName()}\n{nameof(customer.GetAddress)}: {customer.GetAddress().GetFullAddress()}";
    }
}