using System;

public class Customer
{
    private string _name;
    private Address _address;

    // Properties
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public Address Address
    {
        get { return _address; }
        set { _address = value; }
    }

    // Constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Determine if the customer lives in the USA
    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

    // Generate customer shipping label
    public string GetShippingLabel()
    {
        return $"{_name}\n{_address.GetFullAddress()}";
    }
}
