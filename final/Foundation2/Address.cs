/*
The address contains a string for the street address, the city, state/province, and country.
The address should have a method that can return whether it is in the USA or not.
The address should have a method to return a string all of its fields together 
in one string (with newline characters where appropriate)
*/

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    // Constructor (street address, city, state, country)
    public Address(string streetAddress, string city, string state, string country){
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUSA(){
        return _country == "USA"; // check if it's in the USA
    }

    public string GetFullAddress(){
        return $"{_streetAddress}\n{_city}, {_state}, {_country}"; // get the full address
    }
}