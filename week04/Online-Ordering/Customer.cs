using System;
using System.Collections.Generic;

public class Customer
{
    private string _name;
    private string _email;
    private string _address;
    private string _phoneNumber;

    public Customer(string name, string email, string address, string phoneNumber)
    {
        _name = name;
        _email = email;
        _address = address;
        _phoneNumber = phoneNumber;
    }

    public string GetName() => _name;
    public string GetEmail() => _email;
    public string GetAddress() => _address;
    public string GetPhoneNumber() => _phoneNumber;

    public void PlaceOrder(Order order)
    {
        Console.WriteLine($"{_name} placed an order with ID: {order.GetOrderID()}");
    }
}
