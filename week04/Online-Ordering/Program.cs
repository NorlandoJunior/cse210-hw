using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating Customer
        Customer customer1 = new Customer("John Doe", "john@example.com", "123 Street, NY", "555-1234");

        // Creating Products
        Product product1 = new Product("Laptop", 1000, 1);
        Product product2 = new Product("Mouse", 50, 2);

        // Creating Order
        Order order1 = new Order("ORD123", customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        customer1.PlaceOrder(order1);
        
        // Display Order Details
        order1.DisplayOrderDetails();

        // Processing Payment
        Payment payment1 = new Payment("Credit Card", 1100);
        payment1.ProcessPayment();

        // Updating Order Status
        order1.UpdateStatus("Shipped");
        Console.WriteLine($"Updated Order Status: {order1.GetStatus()}");
    }
}
