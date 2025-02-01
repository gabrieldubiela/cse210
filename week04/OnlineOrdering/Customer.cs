using System.Runtime.ExceptionServices;

public class Customer {
    private string _name;
    Address _address;

    public Customer (string first, string last, Address address)
    {
        _name = first + " " + last;
        _address = address;
    }

    public string GetName()
    {
        return _name;
    }

    public bool IsInUsa()
    {
        return _address.IsInUsa();
    }
}