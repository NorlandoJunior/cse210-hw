using System;
using System.Collections.Generic;

public class Order
{
    private string _orderID;
    private DateTime _orderDate;
    private float _totalAmount;
    private string _status;
    private List<Product> _products;
    private Customer _customer;

    public Order(string orderID, Customer customer)
    {
        _orderID = orderID;
        _orderDate = DateTime.Now;
        _status = "Pending";
        _products = new List<Product>();
        _customer = customer;
    }

    public string GetOrderID() => _orderID;
    public string GetStatus() => _status;
    public Customer GetCustomer() => _customer;

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void CalculateTotal()
    {
        _totalAmount = 0;
        foreach (var product in _products)
        {
            _totalAmount += product.GetPrice() * product.GetQuantity();
        }
    }

    public void UpdateStatus(string newStatus)
    {
        _status = newStatus;
    }

    public void DisplayOrderDetails()
    {
        Console.WriteLine($"Order ID: {_orderID}");
        Console.WriteLine($"Customer: {_customer.GetName()}");
        Console.WriteLine($"Status: {_status}");
        Console.WriteLine("Products:");

        foreach (var product in _products)
        {
            Console.WriteLine($"- {product.GetProductName()} (${product.GetPrice()} x {product.GetQuantity()})");
        }

        CalculateTotal();
        Console.WriteLine($"Total Amount: ${_totalAmount}");
    }
}
