public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;
    public Address()
    {
        
    }
    public Address(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }
    public bool IsUSA()
    {
        if (_country == "United States Of America" || _country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string ReturnAddress()
    {
        return $"Address: {_street}, {_city}\nState/Provence: {_stateProvince}\nCountry: {_country}";
    }
}