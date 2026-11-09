Opdracht_E_1();

// =======================
// Opdracht A
// =======================

void Opdracht_A_1()
{
    int[] numbers = new int[4];
    for (int i = 0; i < 4; i++)
    {
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }

    foreach (int number in numbers)
    {
        Console.WriteLine(number);
    }
}

void Opdracht_A_2()
{
    Console.WriteLine("Hoeveel getallen invoeren in Array?");
    int count = Convert.ToInt32(Console.ReadLine());
    Console.Clear();

    int[] numbers = new int[count];
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"Voer nu je {i + 1}e getal in en drukt dan op Enter");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
    }

    Console.WriteLine("De ingevoerde getallen zijn:");
    foreach (int number in numbers)
    {
        Console.WriteLine(number);
    }
}

void Opdracht_A_3()
{
    Console.WriteLine("Hoeveel getallen invoeren in Array?");
    int count = Convert.ToInt32(Console.ReadLine());
    Console.Clear();

    int[] numbers = new int[count];
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"Voer nu je {i + 1}e getal in en drukt dan op Enter");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
    }

    double sum = 0;

    Console.WriteLine("De ingevoerde getallen zijn:");
    foreach (int number in numbers)
    {
        Console.WriteLine(number);
        sum += number;
    }

    double average = sum / count;

    Console.WriteLine($"De som van getallen is {sum}");
    Console.WriteLine($"Het gemiddelde is {average:F3}");
}

void Opdracht_A_4()
{
    string[] names = new string[5];
    for (int i = 0; i < 5; i++)
    {
        names[i] = Console.ReadLine();
    }

    foreach (string name in names)
    {
        Console.WriteLine(name);
    }
}

void Opdracht_A_5()
{
    Console.WriteLine("Hoeveel namen wil je in een Array invoeren? Max. 10");
    int count = Convert.ToInt32(Console.ReadLine());
    Console.Clear();

    while (count > 10)
    {
        Console.WriteLine("Ik zeg het al, Maximum 10 namen!");
        count = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
    }

    string[] names = new string[count];
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"Typ de {i + 1}e naam in en dan Enter.");

        if (i == 0)
        {
            Console.WriteLine("Typ 'stop' om stoppen met namen invoeren");
        }

        string input = Console.ReadLine();
        Console.Clear();

        while (input == "")
        {
            Console.WriteLine("Lege invoer is niet mogelijk");
            input = Console.ReadLine();
            Console.Clear();
        }

        if (input == "stop")
        {
            Console.WriteLine("Het programma is gestopt");
            Console.ReadKey();
            Console.Clear();
            break;
        }

        names[i] = input;
    }

    Console.WriteLine("De namen die je hebt ingevoerd zijn:");
    foreach (string name in names)
    {
        if (name != null)
        {
            Console.WriteLine(name);
        }
    }
}

// =======================
// Opdracht B
// =======================
void Opdracht_B_1()
{
    int fib1 = 0;
    int fib2 = 1;

    for (int i = 2; i < 15; i++)
    {
        Console.WriteLine(fib1);

        int fib3 = fib1 + fib2;

        fib1 = fib2;
        fib2 = fib3;
    }
}

void Opdracht_B_2()
{
    Console.WriteLine("Voer uw inzet tussen 5 en 100");
    int inzet = Convert.ToInt32(Console.ReadLine());
    int multiplier = 0;
    Console.Clear();

    while (inzet < 5 || inzet > 100)
    {
        Console.WriteLine("Inzet mag alleen tussen 5 en 100");
        inzet = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
    }

    // 4 worpen
    for (int i = 0; i < 4; i++)
    {
        int countOfSix = 0;
        int dice1 = 0;
        int dice2 = 0;

        // 2 dobbelstenen
        for (int j = 0; j < 2; j++)
        {
            Random r = new Random();
            dice1 = r.Next(1, 7);
            dice2 = r.Next(1, 7);

            if (dice1 == 6) countOfSix++;
            if (dice2 == 6) countOfSix++;

            // Geijk getallen is +10
            if (dice1 == dice2) multiplier += 10;
            // Beide 1 is reset
            if (dice1 == 1 && dice2 == 1) multiplier = 0;
            // Beide 6 is +50
            if (dice1 == 6 && dice2 == 6) multiplier += 50;
        }

        if (countOfSix > 4) multiplier += 2;

        Console.WriteLine($"{i + 1}e werp resultaat is:");
        Console.WriteLine($"Doublesteen 1 is {dice1}");
        Console.WriteLine($"Doublesteen 2 is {dice2}");
        Console.WriteLine($"Multiplier is {multiplier}");

        Console.ReadKey();
        Console.Clear();
    }

    Console.WriteLine("Samenvatting:");
    Console.WriteLine($"Uw inzet is: {inzet}");
    Console.WriteLine($"Uw multiplier is: {multiplier}");
    Console.WriteLine($"De prijs is {multiplier * inzet}.");
}

// =======================
// Opdracht C
// =======================
void Opdracht_C_1()
{
    for (int x = 0; x < 10; x++)
    {
        for (int y = 0; y < 10; y++)
        {
            if ((x + y) % 2 == 0)
            {
                if ((x * y) <= 25)
                    Console.Write("-");
                else
                    break;
            }
            else
                Console.Write("*");
        }

        Console.WriteLine();
    }

    Console.ReadKey();
}

// =======================
// Opdracht D
// =======================
void Opdracht_D_1()
{
    List<bool> inputList = new List<bool>();

    while (true)
    {
        Console.Write("Voer true of false in (of 'stop' om te stoppen): ");
        string input = Console.ReadLine();
        Console.Clear();

        if (input == "stop") break;

        if (input == "true" || input == "True" || input == "TRUE" || input == "T" || input == "1")
        {
            inputList.Add(true);
            Console.WriteLine("Ingevoerd, Enter om volgende invoeren.");
            Console.ReadKey();
            Console.Clear();
        }
        else if (input == "false" || input == "False" || input == "FALSE" || input == "F" || input == "0")
        {
            inputList.Add(false);
            Console.WriteLine("Ingevoerd, Enter om volgende invoeren.");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine("Ongeldig invoer, probeer opnieuw");
            Console.ReadKey();
            Console.Clear();
        }
    }

    int countOfTrue = 0;

    foreach (bool value in inputList)
    {
        if (value) countOfTrue++;
    }

    Console.WriteLine($"Aantal ingevoerde true zijn {countOfTrue} keer.");
}

// =======================
// Opdracht E
// =======================
void Opdracht_E_1()
{
    int[,] temperatures = new int[4, 7]
    {
        { 15, 12, 10, 8, 9, 8, 5 },
        { 6, 4, -2, -3, -5, -7, -2 },
        { 0, 1, -2, -4, -3, -8, -9 },
        { -11, -8, -5, 2, 4, 5, 1 }
    };

    for (int row = 0; row < temperatures.GetLength(0); row++)
    {
        double average = 0;

        for (int col = 0; col < temperatures.GetLength(1); col++)
        {
            average += temperatures[row, col];
            Console.Write($"{temperatures[row, col]}, ");
        }

        average /= temperatures.GetLength(1);

        Console.WriteLine($"\nGemiddelde temperatuur van week {row + 1} is: {average:F}");
    }
}