using System;
using System.Globalization;

namespace BasicClasses

{
    class Product
    {
        private string _name;
        public double Price { get; private set; }
        public int Quant { get; private set; }


        public Product(string name, double price, int quant)
        {
            _name = name;
            Price = price;
            Quant = quant;
        }
        public Product(string name, double price)
        {
            _name = name;
            Price = price;
            Quant = 1;
        }

        public string Nome
        {
            get { return _name; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _name = value;
                }
            }
        }

        public double StockValue()
        {
            return Price * Quant;
        }

        public void AddProduct(int quantity)
        {
            Quant += quantity;
        }

        public void RemoveProduct(int quantity)
        {
            Quant -= quantity;
        }

        public override string ToString()
        {
            return _name + " -> $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quant
                + " unit(s), Total: $"
                + StockValue().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}