namespace week4.Models
{
    internal abstract class Item
    {
        public string Name { get; set; } = "";

        protected Item(string name)
        {
            this.Name = name;
        }
    }
}