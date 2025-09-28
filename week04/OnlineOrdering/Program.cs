using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Order 1
        Address addr1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Alice Johnson", addr1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P123", 1200.00f, 1));
        order1.AddProduct(new Product("Mouse", "P124", 25.50f, 2));

        // Order 2
        Address addr2 = new Address("456 King Rd", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Bob Smith", addr2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Headphones", "P125", 150.75f, 1));
        order2.AddProduct(new Product("Monitor", "P126", 300.00f, 1));

        DisplayOrder(order1);
        Console.WriteLine();
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total: ${order.CalculateTotal()}");
    }
}
