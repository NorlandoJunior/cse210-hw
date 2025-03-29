using System;

public class Product
{
    private string _productName;
    private float _price;
    private int _quantity;

    public Product(string productName, float price, int quantity)
    {
        _productName = productName;
        _price = price;
        _quantity = quantity;
    }

    public string GetProductName() => _productName;
    public float GetPrice() => _price;
    public int GetQuantity() => _quantity;

    public void UpdateStock(int newQuantity)
    {
        _quantity = newQuantity;
    }

    public void ApplyDiscount(float discountPercentage)
    {
        _price -= _price * (discountPercentage / 100);
    }
}
