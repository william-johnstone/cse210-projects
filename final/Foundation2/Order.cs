class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public decimal CalculateTotalCost()
    {
        decimal total = 0;
        foreach (var product in _products)
        {
            total += product.GetTotalPrice();
        }

        // Adding shipping cost based on if the customer is in USA or not
        if (_customer.IsInUSA() is true)
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
        foreach (var product in _products)
        {
            packingLabel += $"{product.GetProductInfo()}\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\nCustomer: {_customer.GetName()}\nAddress: {_customer.GetAddress().GetFullAddress()}";
    }
}