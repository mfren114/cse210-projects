using System.ComponentModel;

public class Products
{
    private string _productName {get; set;}
    private int _productId {get; set;}
    private int _price {get; set;}
    private int _quantity {get; set;}

    public Products (string productName, int productId, int price, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public float TotalCost()
    {
        float price = _price;
        float quantity = _quantity;

        float totalCost = price * quantity;

        return totalCost;
    }

    public void DisplayProduct()
    {
        Console.WriteLine($"Product Name: {_productName}");
        Console.WriteLine($"ID: {_productId}");
        Console.WriteLine($"Price: {_price}");
        Console.WriteLine($"QTY: {_quantity}");

        Console.WriteLine($"Total Cost = {TotalCost}");

    }
}