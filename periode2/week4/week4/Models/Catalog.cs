namespace week4.Models
{
    internal class Catalog
    {
        public List<Product> Products = [];
        public List<Category> Categories = [];

        public void PrintProducts()
        {
            Console.WriteLine("Lijst met producten:");
            for (int i = 0; i < Products.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Products[i].Name}");
            }
        }

        public void PrintCategories()
        {
            Console.WriteLine("Lijst met categorieen:");
            for (int i = 0; i < Categories.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Categories[i].Name}");
            }
        }
    }
}