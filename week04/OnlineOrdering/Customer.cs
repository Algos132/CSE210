using System;

class Customer
{
    private string _name;
    private Address _address = new Address();

    public void CreateCustomer(string name, string streetAddress, string city, string state, string country)
    {
        _name = name;
        _address.SetAddress(streetAddress, city, state, country);
    }

    public bool IsUSA()
    {
        return _address.IsUSA();
    }

    public string DisplayName()
    {
        return _name;
    }

    public string DisplayAddress()
    {
        return _address.DisplayAddress();
    }
}