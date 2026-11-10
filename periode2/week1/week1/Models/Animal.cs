namespace week1.Models
{
    internal abstract class Animal
    {
        protected string name;

        public Animal(string name)
        {
            this.name = name;
        }

        public abstract string GetAnimalType();

        public override string ToString()
        {
            return $"Naam: {this.name} - Soort: {GetAnimalType()}";
        }
    }
}