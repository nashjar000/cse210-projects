using System;

class Program
{
    static void Main(string[] args)
    {
        // Make products (product name, id, price, quantity)
        Product product1 = new Product("Milk", 5304, 3.99m, 5);
        Product product2 = new Product("Eggs", 2708, 2.99m, 10);
        
        // Make customer (street address, city, state, country)
        Address address1 = new Address("123 Main Street", "Anytown", "CA", "USA");
        Customer customer1 = new Customer("Frodo Baggins", address1);

        Address address2 = new Address("456 Main Street", "Anytown", "NY", "USA");
        Customer customer2 = new Customer("Samwise Gamgee", address2);

        // Make order (products, customer)
        List<Product> orderProducts = new List<Product>{product1, product2};
        Order order1 = new Order(orderProducts, customer1);

        List<Product> orderProducts2 = new List<Product>{product2};
        Order order2 = new Order(orderProducts2, customer2);

        // Print packing label
        /*
        Order #:
        Packing Label:  stuff
        Shipping Label: stuff
        Total Cost: $$$$$
        */

        // Order 1 Shipping Label
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order1.GetTotalCost():C}\n");

        // Order 2 Shipping Label
        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order2.GetTotalCost():C}\n");
    }
}