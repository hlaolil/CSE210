using System;
using System.Collections.Generic;

namespace OnlineOrderingSystem
{
    // Product class to store product details
    class Product
    {
        private string name;
        private string productId;
        private double price;
        private int quantity;

        public Product(string name, string productId, double price, int quantity)
        {
            this.name = name;
            this.productId = productId;
            this.price = price;
            this.quantity = quantity;
        }

        // Calculate total cost for the product
        public double GetTotalCost()
        {
            return price * quantity;
        }

        // Generate product info for packing label
        public string GetProductLabel()
        {
            return $"{name} (ID: {productId})";
        }
    }

    // Address class to store address details
    class Address
    {
        private string street;
        private string city;
        private string state;
        private string country;

        public Address(string street, string city, string state, string country)
        {
            this.street = street;
            this.city = city;
            this.state = state;
            this.country = country;
        }

        // Determine if the address is in the USA
        public bool IsInUSA()
        {
            return country.ToUpper() == "USA";
        }

        // Return full address as a formatted string
        public string GetFullAddress()
        {
            return $"{street}\n{city}, {state}\n{country}";
        }
    }

    // Customer class to store customer details
    class Customer
    {
        private string name;
        private Address address;

        public Customer(string name, Address address)
        {
            this.name = name;
            this.address = address;
        }

        // Determine if the customer lives in the USA
        public bool LivesInUSA()
        {
            return address.IsInUSA();
        }

        // Generate customer shipping label
        public string GetShippingLabel()
        {
            return $"{name}\n{address.GetFullAddress()}";
        }
    }

    // Order class to manage products and customer details
    class Order
    {
        private List<Product> products = new List<Product>();
        private Customer customer;

        public Order(Customer customer)
        {
            this.customer = customer;
        }

        // Add product to the order
        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        // Calculate the total cost including shipping
        public double GetTotalCost()
        {
            double total = 0;
            foreach (Product product in products)
            {
                total += product.GetTotalCost();
            }

            // Add shipping cost based on customer's location
            double shippingCost = customer.LivesInUSA() ? 5 : 35;
            return total + shippingCost;
        }

        // Generate packing label
        public string GetPackingLabel()
        {
            string label = "Packing List:\n";
            foreach (Product product in products)
            {
                label += $"- {product.GetProductLabel()}\n";
            }
            return label;
        }

        // Generate shipping label
        public string GetShippingLabel()
        {
            return $"Shipping To:\n{customer.GetShippingLabel()}";
        }
    }

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
}
