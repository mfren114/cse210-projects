using System.Dynamic;

public class Customer
{
    private string _name {get; set;}

    Address _address {get; set;}

    public Customer (string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public float ShippingCost()
    {
        float ShippingCost;
        if (_address.LocatedInUSA() == "USA")
        {
            ShippingCost = 5;
        }
        else
        {
            ShippingCost = 35;
        }
        return ShippingCost;
    }

    public void DisplayCustomer()
    {
        Console.WriteLine($"Name: {_name}");
        _address.DisplayAdress();
        _address.LocatedInUSA();
    }
}