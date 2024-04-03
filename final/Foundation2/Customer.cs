/*
The customer contains a name and an address.
The name is a string, but the Address is a class.
The customer should have a method that can return 
whether they live in the USA or not. (Hint this should 
call a method on the address to find this.)
*/

using System.Net.Sockets;

public class Customer
{
    private string _name;
    private Address _address;

    // constructor (name, address)
    public Customer(string name, Address address){
        _name = name;
        _address = address;
    }

    public bool IsInUSA(){
        return _address.IsInUSA(); // call address, see if it's in the USA
    }

    public string GetName(){
        return _name; // customer name
    }

    public string Name(){
        return _name; // customer name
    }

    public Address Address(){
        return _address; // customer address
    }

}