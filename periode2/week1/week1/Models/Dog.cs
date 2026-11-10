namespace week1.Models
{
    internal class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }

        public override string GetAnimalType()
        {
            return "Hond";
        }
    }
}