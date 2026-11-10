using System.Diagnostics;
using week3.Models;

namespace week3
{
    internal class Program
    {
        private static List<Person> _persons = [];

        private static void Main(string[] args)
        {
            TestMyCode();
        }

        public static void TestMyCode()
        {
            // voor de test: toevoegen personen en eigenschappen
            Villain ozymandias = new Villain("Adrian Veidt");
            Villain joker = new Villain("Mr. J");
            Hero robin = new Hero("Jason Todd", joker);
            Hero batman = new Hero("Bruce Wayne", joker);
            batman.AddStrength("Intelligence");
            batman.AddStrength("Wealth");
            batman.UpdateSidekick(robin);
            Hero rorschach = new Hero("Walter Joseph Kovacs", ozymandias);

            Villain gru = new Villain("Gru");
            gru.AddStrength("Inspiration");
            Minion bob = new Minion("Bob");
            Minion kevin = new Minion("Kevin");
            Minion stuart = new Minion("Stuart");
            gru.AddMinion(bob);
            gru.AddMinion(kevin);
            gru.AddMinion(stuart);

            _persons.Add(batman);
            _persons.Add(robin);
            _persons.Add(rorschach);
            _persons.Add(gru);

            // Output om de functies te testen
            Debug.WriteLine("Aantal toegevoegde personen: " + _persons.Count);
            int heroCount = 0;
            int villainCount = 0;
            int minionCount = 0;

            foreach (Person p in _persons)
            {
                if (p is Hero hero)
                {
                    heroCount++;
                    Debug.WriteLine(heroCount + ". " + p.Name);
                    Debug.WriteLine("Strength: " + String.Join("; ", hero.GetStrengths()));
                    Debug.WriteLine("Evilness: " + hero.GetEvilness());
                    Debug.WriteLine("Archnemesis " + (hero.GetArchnemesis() == null ? "" : hero.GetArchnemesis().Name));

                    Person? sidekick = hero.GetSidekick();
                    Debug.WriteLine("Sidekick: " + (sidekick == null ? "geen" : sidekick.Name));
                }
                else if (p is Villain villain)
                {
                    villainCount++;
                    minionCount += villain.Minions.Count;
                }
                else if (p is Minion)
                {
                    minionCount++;
                }
            }

            Debug.WriteLine("Aantal heroes: " + heroCount);
            Debug.WriteLine("Aantal villains: " + villainCount);
            Debug.WriteLine("Aantal minions: " + minionCount);
        } //set breakpoint
    }
}