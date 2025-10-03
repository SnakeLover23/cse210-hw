public class Address
{
    string _street;
    string _city;
    string _stateProvince;
    string _country;
    public Address(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }
    public bool IsUSA()
    {
        if (_country == "United States Of America")
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
        return $"{_street}\n{_city} {_stateProvince}\n{_country}";
    }
}