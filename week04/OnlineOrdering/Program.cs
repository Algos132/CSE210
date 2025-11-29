using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        //Create First Order
        Order order1 = new Order();

        order1.CreateCustomer("John Doe", "123 Main St", "Anytown", "CA", "USA");
        order1.OrderProduct("Canned Beans", 1332, 2.95f, 2);
        order1.OrderProduct("Paper Plates", 4335, 23.08f, 1);
        order1.OrderProduct("Bundled Bannanas", 1123, 4.56f, 3);

        //Display First Order's reciept and shipping label
        order1.DisplayPackingLabel();
        Console.WriteLine();
        order1.DisplayShippingLabel();
        Console.WriteLine();

        //Create Second Order
        Order order2 = new Order();

        order2.CreateCustomer("Jane Doe", "123 Main St", "Burnaby", "Vancouver", "Canada");
        order2.OrderProduct("Winter Boots", 44556, 30.24f, 1);
        order2.OrderProduct("Flour", 444323, 1.95f, 2);

        //Display Second Order's reciept and shipping label
        order2.DisplayPackingLabel();
        Console.WriteLine();
        order2.DisplayShippingLabel();
        Console.WriteLine();
    }
}