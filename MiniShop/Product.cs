using System.Diagnostics;

namespace MiniShop
{
    public class Product
    {
        private int id;
        private string name;
        private double price;
        private string descr = string.Empty;

        private bool promo = false;
        private bool active = true;
        public string Name { get { return name; } }
        public double Price { get { return price; } }

        public Product(int id, string name, double price, string descr="")
        {
            this.id = id; this.name = name; this.price = price; this.descr = descr;
        }
    }
}