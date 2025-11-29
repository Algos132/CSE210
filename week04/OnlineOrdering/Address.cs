using System;

class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public void SetAddress(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        else if (_country == "United States")
        {
            return true;
        }
        else if (_country == "United States of America")
        {
            return true;
        }
        else if (_country == "US")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string DisplayAddress()
    {
        return $"{_streetAddress}, {_city}\n{_state}, {_country}";
    }
}