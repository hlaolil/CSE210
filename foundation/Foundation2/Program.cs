using System;
using System.Collections.Generic;

class Program
    {
        static void Main(string[] args)
        {
            // Create addresses
            Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
            Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");

            // Create customers
            Customer customer1 = new Customer("John Doe", address1);
            Customer customer2 = new Customer("Alice Smith", address2);

            // Create orders and add products
            Order order1 = new Order(customer1);
            order1.AddProduct(new Product("Laptop", "A123", 999.99, 1));
            order1.AddProduct(new Product("Mouse", "B456", 25.50, 2));

            Order order2 = new Order(customer2);
            order2.AddProduct(new Product("Phone", "C789", 799.99, 1));
            order2.AddProduct(new Product("Headphones", "D012", 49.99, 1));

            // Display order details
            DisplayOrderDetails(order1);
            DisplayOrderDetails(order2);
        }

        // Method to display order details
        static void DisplayOrderDetails(Order order)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order.GetTotalCost():F2}");
            Console.WriteLine("\n--------------------------\n");
        }
    }

