namespace week3.Models
{
    internal abstract class Person
    {
        public string Name { get; set; } = "";
        private readonly int _evilness;

        protected Person() : this(50)
        {
        }

        protected Person(int evilness)
        {
            if (evilness < 0 || evilness > 100)
                _evilness = 50;
            else
                _evilness = evilness;
        }

        public int GetEvilness()
        {
            return _evilness;
        }
    }
}