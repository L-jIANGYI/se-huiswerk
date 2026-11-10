using week3.Interfaces;

namespace week3.Models
{
    internal class Hero : Person, IHasStrengths
    {
        public Villain Archnemesis { get; set; }
        public List<string> Strengths { get; set; } = new List<string>();
        private Person? _sidekick;

        public Hero(string name, Villain archnemesis)
        {
            Name = name;
            Archnemesis = archnemesis;
        }

        public Hero(string name, Villain archnemesis, Person sidekick) : this(name, archnemesis)
        {
            _sidekick = sidekick;
        }

        public Hero(string name, Villain archnemesis, int evilness)
            : base(evilness)
        {
            Name = name;
            Archnemesis = archnemesis;
        }

        public Hero(string name, Villain archnemesis, Person sidekick, int evilness)
            : this(name, archnemesis, evilness)
        {
            _sidekick = sidekick;
        }

        public Villain GetArchnemesis()
        {
            return Archnemesis;
        }

        public Person? GetSidekick()
        {
            return _sidekick;
        }

        public void UpdateSidekick(Person sidekick)
        {
            _sidekick = sidekick;
        }

        public void AddStrength(string strength)
        {
            Strengths.Add(strength);
        }

        public List<string> GetStrengths()
        {
            return Strengths;
        }
    }
}