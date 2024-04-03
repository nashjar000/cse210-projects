/*
Contains a list of products and a customer. Can calculate the total cost of the order. 
Can return a string for the packing label. Can return a string for the shipping label.
The total price is calculated as the sum of the total cost of each product plus a one-time shipping cost.
This company is based in the USA. If the customer lives in the USA, then the shipping cost is $5. 
If the customer does not live in the USA, then the shipping cost is $35.
A packing label should list the name and product id of each product in the order.
A shipping label should list the name and address of the customer
*/

using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;
    private decimal _shippingCost;

    // Constructor (products, customer, shipping cost)
    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
        _shippingCost = _customer.IsInUSA() ? 5.00m : 35.00m;
    }

    // Method to calculate total cost of the order
    public decimal GetTotalCost()
    {
        decimal totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.totalCost();
        }
        // Adding shipping cost
        totalCost += _shippingCost;
        return totalCost;
    }

    // Method to get packing label
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products)
        {
            label += $"Product: {product.GetName()}, Product ID: {product.GetId()}\n";
        }
        return label;
    }

    // Method to get shipping label
    public string GetShippingLabel()
    {
        string label = "Shipping Label:\n";
        label += $"Name: {_customer.GetName()}\n";
        label += _customer.Address().GetFullAddress();
        return label;
    }
}
