namespace week1.Models
{
    internal class Animal
    {
        private string name;
        private string kind;

        public Animal(string name, string kind)
        {
            this.name = name;
            this.kind = kind;
        }

        public override string ToString()
        {
            return $"Naam: {this.name} - Soort: {this.kind}";
        }
    }
}