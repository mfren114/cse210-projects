public class Address
{
    private string _address {get; set;}
    private string _city {get; set;}
    private string _state {get; set;}
    private string _country {get; set;}

    public Address (string address, string city, string state, string country)
        {
            _address = address;
            _city = city;
            _state = state;
            _country = country;
        }
    

    public string LocatedInUSA()
    {
        return _country;
    }

    public void DisplayAdress()
    {
        Console.WriteLine($"Address: {_address}, {_city}, {_state}, {_country}");
        
    }
}