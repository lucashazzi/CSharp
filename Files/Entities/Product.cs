using System;
using System.Collections.Generic;
using System.Text;

namespace Files.Entities
{
    class Product
    {
        public Product()
        {
        }

        public string Name { get; set; }
        public double Value { get; set; }
        public int Amount { get; set; }

        public Product(string name, double value, int amount)
        {
            Name = name;
            Value = value;
            Amount = amount;
        }

        public double GetTotalValue()
        {
            return Value * Amount;
        }
    }
}
