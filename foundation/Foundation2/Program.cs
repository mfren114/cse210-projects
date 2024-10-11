using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation2 World!");
        //Order 1
        Address address1 = new Address ("101 Dalmation St", "Watertown", "MA", "USA");
        Customer customer1 = new Customer ("Mike Paris", address1);

        //float order1Shipment = customer1.ShippingCost();

        Products order1Product1 = new Products ("Bananas", 4747, 1, 4);
        Products order1Product2 = new Products ("Ham", 2321, 2, 2);

        Order order1 = new Order (customer1);
        order1.AddProduct(order1Product1);
        order1.AddProduct(order1Product2);
        float order1Total = order1.CalculateTotal();

        order1.DisplayPackingLabel();
        order1.DisplayShippingLabel();
        Console.WriteLine($"Total = {order1Total}");
        Console.WriteLine(" ");

        //Order 2

         Address address2 = new Address ("1 Baker St.", "Westminster", "London", "Uk");
        Customer customer2 = new Customer ("Sherlock Holmes", address2);

        //float order1Shipment = customer1.ShippingCost();

        Products order2Product1 = new Products ("Pork Belly", 2345, 5, 5);
        Products order2Product2 = new Products ("Mint Tea", 8987, 1, 1);

        Order order2 = new Order (customer2);
        order2.AddProduct(order2Product1);
        order2.AddProduct(order2Product2);
        float order2Total = order2.CalculateTotal();

        order2.DisplayPackingLabel();
        order2.DisplayShippingLabel();
        Console.WriteLine($"Total = {order2Total}");
        Console.WriteLine(" ");

        
    }
}