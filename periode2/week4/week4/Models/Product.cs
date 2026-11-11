namespace week4.Models
{
    internal class Product : Item
    {
        public decimal Price { get; set; }
        public Category Category { get; set; }

        public Product(string name, decimal price, Category category) : base(name)
        {
            Price = price;
            Category = category;
        }

        public string GetPriceText()
        {
            return $"Dit product {Name} kost {Price} euro";
        }
    }
}