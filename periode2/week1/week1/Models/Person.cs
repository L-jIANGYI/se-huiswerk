namespace week1.Models
{
    internal class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private List<Animal> pets = new List<Animal>();

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public void AddPet(Animal pet)
        {
            pets.Add(pet);
        }

        public List<Animal> GetPets()
        {
            return pets;
        }

        public string GetName()
        {
            return firstName + " " + lastName;
        }

        public int GetAge()
        {
            return age;
        }

        public override string ToString()
        {
            return GetName();
        }
    }
}