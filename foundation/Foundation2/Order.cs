using System;
using System.Collections.Generic;

public class Order
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


