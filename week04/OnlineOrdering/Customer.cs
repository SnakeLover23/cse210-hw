public class Customer
{
    private string _name;
    private Address _address = new Address();
    public Customer()
    {
        
    }
    public Customer(string name, string street, string city, string stateProvince, string country)
    {
        _name = name;
        _address = new Address(street, city, stateProvince, country);
    }
    public string GetName()
    {
        return _name;
    }
    public Address GetAddress()
    {
        return _address;
    }
    public bool IsUSA()
    {
        bool isUSA = _address.IsUSA();
        return isUSA;
    }
}