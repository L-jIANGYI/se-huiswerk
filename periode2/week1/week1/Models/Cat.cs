namespace week1.Models
{
    internal class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }

        public override string GetAnimalType()
        {
            return "Kat";
        }
    }
}