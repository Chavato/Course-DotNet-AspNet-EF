
namespace Entities.Class192
{
    class Product
    {
        public string Name { get; private set; }
        public int Quant { get; private set; }
        public double Price { get; private set; }


        public Product(string name, int quant, double price)
        {
            Name = name;
            Quant = quant;
            Price = price;
        }

        public double Total()
        {
            return Quant * Price;
        }
    }


}