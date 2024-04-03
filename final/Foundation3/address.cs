public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _zipCode;

    // Constructor
    public Address(string streetAddress, string city, string state, string xipCode)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _zipCode = xipCode;
    }

    // return full address
    public string GetFullAddress()
    {
        return $"{_streetAddress}\n{_city}, {_state}, {_zipCode}";
    }

}