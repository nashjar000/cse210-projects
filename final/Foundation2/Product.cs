/*
Contains the name, product id, price per unit, and quantity of each product.
The total cost of this product is computed by multiplying the price per unit 
and the quantity. If the price per unit was $3 and they bought 5, 
the product total cost would be $15.
*/

public class Product
{
    private string _name;
    private int _id;
    private decimal _price;
    private int _quantity;

    // Constructor (name, id, price, quantity)...all private information 
    public Product(string name, int id, decimal price, int quantity){
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public decimal totalCost(){
        return _price * _quantity; // product total cost
    }

    public string GetName(){
        return _name; // product name
    }

    public int GetId(){
        return _id; // product id
    }

}