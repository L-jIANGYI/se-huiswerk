using week3.Interfaces;

namespace week3.Models
{
    internal class Villain : Person, IHasStrengths
    {
        public List<Minion> Minions { get; set; } = new List<Minion>();
        public List<string> Strengths { get; set; } = new List<string>();

        public Villain(string name)
        {
            Name = name;
        }

        public Villain(string name, int evilness) : base(evilness)
        {
            Name = name;
        }

        public void AddMinion(Minion minion)
        {
            Minions.Add(minion);
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