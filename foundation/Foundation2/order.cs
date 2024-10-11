using System.Numerics;

public class Order
{
    private List<Products> _productList = new List<Products>();
    private Customer _customer {get; set;}

    public Order (Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Products product)
    {
        _productList.Add(product);
    }

    public float CalculateTotal()
    {
        float total = 0;
        foreach (Products product in _productList)
        {
            float productprice = product.TotalCost();
            total += productprice + _customer.ShippingCost();  
        }
        return total;
    }

    public void DisplayPackingLabel()
    {
        Console.WriteLine("Packing Label:");
        Console.WriteLine("____________________");
        foreach (Products product in _productList)
        {
           product.DisplayProduct(); 
        }
        Console.WriteLine(" ");
    }
    
    public void DisplayShippingLabel()
    {
        Console.WriteLine("Shipping Label:");
        Console.WriteLine("____________________");
        _customer.DisplayCustomer();
        Console.WriteLine(" ");
    }
}