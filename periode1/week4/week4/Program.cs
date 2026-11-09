namespace week4
{
    public class Program
    {
        static void Main(string[] args)
        {
            //OpdrachtA();
            //OpdrachtB();
            OpdrachtC();
        }

        // ===============================================
        // Opdracht A
        // ===============================================
        public static void OpdrachtA()
        {
            Console.Write("Geef je invoer: ");
            string input = Console.ReadLine();

            Console.WriteLine("Middelste letter van Sarah is: " + MiddelsteLetter("Sarah"));
            Console.WriteLine("Middelste letter van deadpool zijn: " + MiddelsteLetter("Deadpool"));
            Console.WriteLine("Middelste letter van jouw invoer is/zijn: " + MiddelsteLetter(input));
        }

        /// <summary>
        /// Return 1/2 middelste letter van het woord.
        /// </summary>
        /// <param name="tekst"></param>
        /// <returns></returns>
        public static string MiddelsteLetter(string tekst)
        {
            int midden = tekst.Length / 2;
            if (tekst.Length % 2 == 0)
            {
                return tekst[midden - 1].ToString() + tekst[midden].ToString();
            }

            return tekst[midden].ToString();
        }

        // ===============================================
        // Opdracht B
        // ===============================================
        public static void OpdrachtB()
        {
            Console.WriteLine("Invoer:");
            string input = Console.ReadLine();

            Console.WriteLine("Index:");
            int index = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(LetterOpIndex(input, index));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static char LetterOpIndex(string text, int index)
        {
            int textLength = text.Length - 1;

            if (index < 0)
            {
                index = 0;
            }
            else if (index > textLength)
            {
                index = textLength;
            }

            char letter = text[textLength - index];

            return letter;
        }

        // ===============================================
        // Opdracht C
        // ===============================================
        public static void OpdrachtC()
        {
            Console.WriteLine("Geef je tekst in: ");
            string input = Console.ReadLine();

            AantalWoorden(input);
            AantalWoorden("Dit zijn vier woorden");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        public static void AantalWoorden(string text)
        {
            string[] wordCount = text.Split(" ");
            Console.WriteLine($"De string - {text} - bevat {wordCount.Length} woorden.");
        }
    }
}