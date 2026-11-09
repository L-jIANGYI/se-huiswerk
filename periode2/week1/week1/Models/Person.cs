namespace week1.Models
{
    internal class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public string GetName()
        {
            return firstName + "" + lastName;
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