using System;
using System.Collections.Generic;

public class Product
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

