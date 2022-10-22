namespace Estudo
{
    class Produtos
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Produtos(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
