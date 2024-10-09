using System.Numerics;

public class Order
{
    private List<Products> _productlist = new List<Products>();
    private Customer _customer {get; set;}

    public Order (Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Products product)
    {
        _productlist.Add(product);
    }

    public float CalculateTotal(Products products, Customer customer)
    {
        float total = products.TotalCost() + customer.ShippingCost();
        return total;
    }

    public void DisplayPackingLabel()
    {
        Console.WriteLine("Packing Label");
        foreach (Products product in _productlist)
        {
           product.DisplayProduct(); 
        }
    }
    
    public void DisplayShippingLabel()
    {
        Console.WriteLine("Shipping Label");
        _customer.DisplayCustomer();
    }
}