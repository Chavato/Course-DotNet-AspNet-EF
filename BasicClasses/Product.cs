using System;
using System.Globalization;

namespace BasicClasses

{
    class Product
    {
        public string Name;
        public double Price;
        public int Quant;

        double StockValue()
        {
            return Price * Quant;
        }

        void AddProduct(int quantity)
        {
            Quant += quantity;
        }

        void RemoveProduct(int quantity)
        {
            Quant -= quantity;
        }

        public override string ToString()
        {
            return Name + " -> $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quant
                + " unit(s), Total: $"
                + StockValue().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}