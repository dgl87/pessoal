namespace CSharpCompleto
{
    class Product
    {
        public string Nome { get; set; }
        public double Price { get; set; }

        public Product(string nome, double price)
        {
            Nome = nome;
            Price = price;
        }
    }
}
