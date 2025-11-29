using System;
using System.Collections.Generic;

class Product
{
    private string _productName;
    private int _id;
    private float _price;
    private int _quantity;

    public Product(string name, int id, float price, int quantity)
    {
        _productName = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public float Total()
    {
        return _price * _quantity;
    }

    public string DisplayProduct()
    {
        return $"{_productName} (ID: {_id}) - ${_price} x {_quantity} = ${Math.Round(Total(), 2)}";
    }
}