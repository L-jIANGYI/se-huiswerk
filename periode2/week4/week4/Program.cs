using week4.Models;

namespace week4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Categorieen
            Category modern = new Category("Modern");
            Category brocante = new Category("Brocante");
            Category minimalistisch = new Category("Minimalistisch");

            // Producten
            Product keukenkastje = new Product("Keukenkastje", 1.99m, modern);
            Product stoel = new Product("Stoel", 99999.99m, brocante);
            Product tafel = new Product("Tafel", 67.67m, minimalistisch);

            Catalog catalog = new Catalog();
            catalog.Categories.Add(modern);
            catalog.Categories.Add(brocante);
            catalog.Categories.Add(minimalistisch);
            catalog.Products.Add(keukenkastje);
            catalog.Products.Add(stoel);
            catalog.Products.Add(tafel);

            // Lijsten
            catalog.PrintProducts();
            Console.WriteLine();
            catalog.PrintCategories();
            Console.WriteLine();

            while (true)
            {
                Console.Write("Welk product? (nummer): ");
                int inputInNr = Convert.ToInt32(Console.ReadLine());

                if (inputInNr >= 1 && inputInNr <= catalog.Products.Count)
                {
                    Product selected = catalog.Products[inputInNr - 1];
                    Console.WriteLine(selected.GetPriceText());
                    Console.WriteLine($"Categorie: {selected.Category.Name}");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Ongeldige keuze.");
                    Console.WriteLine();
                }
            }
        }
    }
}