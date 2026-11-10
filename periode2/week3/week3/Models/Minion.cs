namespace week3.Models
{
    internal class Minion : Person
    {
        public string Weakness { get; set; }

        public Minion(string name)
        {
            Name = name;
        }

        public Minion(string name, string weakness) : this(name)
        {
            Weakness = weakness;
        }

        public Minion(string name, int evilness) : base(evilness)
        {
            Name = name;
        }

        public Minion(string name, string weakness, int evilness) : this(name, evilness)
        {
            Weakness = weakness;
        }
    }
}