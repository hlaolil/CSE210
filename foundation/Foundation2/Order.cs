using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    // Property for customer
    public Customer Customer
    {
        get { return _customer; }
        set { _customer = value; }
    }

    // Constructor
    public Order(Customer customer)
    {
        _customer = customer;
    }

    // Add product to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Calculate the total cost including shipping
    public double GetTotalCost()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        // Add shipping cost based on customer's location
        double shippingCost = _customer.LivesInUSA() ? 5 : 35;
        return total + shippingCost;
    }

    // Generate packing label
    public string GetPackingLabel()
    {
        string label = "Packing List:\n";
        foreach (Product product in _products)
        {
            label += $"- {product.GetProductLabel()}\n";
        }
        return label;
    }

    // Generate shipping label
    public string GetShippingLabel()
    {
        return $"Shipping To:\n{_customer.GetShippingLabel()}";
    }
}
