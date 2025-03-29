using System;

public class Payment
{
    private string _paymentMethod;
    private string _paymentStatus;
    private float _amountPaid;

    public Payment(string paymentMethod, float amountPaid)
    {
        _paymentMethod = paymentMethod;
        _amountPaid = amountPaid;
        _paymentStatus = "Pending";
    }

    public string GetPaymentStatus() => _paymentStatus;

    public void ProcessPayment()
    {
        // Simulating payment processing
        _paymentStatus = "Successful";
        Console.WriteLine($"Payment of ${_amountPaid} using {_paymentMethod} was {_paymentStatus}");
    }

    public void Refund()
    {
        _paymentStatus = "Refunded";
        Console.WriteLine($"Refund of ${_amountPaid} has been processed.");
    }
}
