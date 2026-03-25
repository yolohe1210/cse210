using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new Customer("Alice", new Address("123 Main St", "Rexburg", "Idaho", "USA"));
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Potato", "1234", 0.5, 5));
        order1.AddProduct(new Product("Tomato", "1235", 0.6, 3));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order1.GetTotalPrice():0.00}");
        Console.WriteLine("---------------------------------------");

 
        Customer customer2 = new Customer("Bob", new Address("456 Elm St", "Toronto", "ON", "Canada"));
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Apple", "1236", 1.2, 4));
        order2.AddProduct(new Product("Banana", "1237", 0.8, 6));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order2.GetTotalPrice():0.00}");
        Console.WriteLine("---------------------------------------");
    }
}