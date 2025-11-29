using System;
using System.Collections.Generic;

class Order
{
    private Customer _customer = new Customer();
    private List<Product> _products = new List<Product>();
    private float _total;

    public void CreateCustomer(string name, string streetAddress, string city, string state, string country)
    {
        _customer.CreateCustomer(name, streetAddress, city, state, country);
    }

    public void OrderProduct(string name, int id, float price, int quantity)
    {
        _products.Add(new Product(name, id, price, quantity));
    }
    public void DisplayPackingLabel()
    {
        Console.WriteLine($"Order for: {_customer.DisplayName()}");
        for (int i = 0; i < _products.Count; i++)
        {
            Console.WriteLine($"{_products[i].DisplayProduct()}");
            _total += _products[i].Total();
        }
        if (_customer.IsUSA())
        {
            Console.WriteLine("Shipping: $5.00");
            _total += 5;
        }
        else
        {
            Console.WriteLine("Shipping: $35.00");
            _total += 35;
        }
        Console.WriteLine($"Total: ${Math.Round(_total, 2)}");
    }
    public void DisplayShippingLabel()
    {
        Console.WriteLine($"To: {_customer.DisplayName()}\n{_customer.DisplayAddress()}");
    }
}