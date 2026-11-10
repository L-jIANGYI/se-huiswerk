namespace week3.Interfaces
{
    internal interface IHasStrengths
    {
        void AddStrength(string strength);

        List<string> GetStrengths();
    }
}