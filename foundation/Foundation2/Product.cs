using System;

public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    // Properties
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

    public double Price
    {
        get { return _price; }
        set { _price = value; }
    }

    public int Quantity
    {
        get { return _quantity; }
        set { _quantity = value; }
    }

    // Constructor
    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // Calculate total cost for the product
    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    // Generate product info for packing label
    public string GetProductLabel()
    {
        return $"{_name} (ID: {_productId})";
    }
}
