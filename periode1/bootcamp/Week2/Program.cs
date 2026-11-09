Console.WriteLine("====== For loop ======");
int getal = 2;
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"{getal} - macht {i + 1}");
    getal *= 2;
}

Console.WriteLine("====== While ======");

int count = 0;
getal = 2;
while (count < 10)
{
    Console.WriteLine($"{getal} - macht {count + 1}");
    count++;
    getal *= 2;
}

Console.WriteLine("====== Do While ======");

count = 0;
getal = 2;
do
{
    Console.WriteLine($"{getal} - macht {count + 1}");
    count++;
    getal *= 2;
} while (count < 10);

Console.ReadKey();
Console.Clear();

// Deel 2 - opdracht A - 5

int invoer = 0;
int max = 0;

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Voer een getal in:");
    invoer = Convert.ToInt32(Console.ReadLine());

    if (invoer > max)
    {
        max = invoer;
    }
}

Console.WriteLine($"Grootste getal is {max}");

Console.ReadKey();
Console.Clear();

// ==============================
// Deel 2 - Opdracht B - Fibbonacci
// ==============================
int fib1 = 0;
int fib2 = 1;

for (int i = 2; i < 15; i++)
{
    Console.WriteLine(fib1);

    int fib3 = fib1 + fib2;

    fib1 = fib2;
    fib2 = fib3;
}

Console.ReadKey();
Console.Clear();

// ==============================
// Deel 2 - Opdracht B - spel
// ==============================\
Console.WriteLine("Voer uw inzet");
int inzet = Convert.ToInt32(Console.ReadLine());
int multiplier = 0;

for (int i = 0; i < 4; i++)
{
    int countOfSix = 0;

    for (int j = 0; j < 2; j++)
    {
        Random r = new Random();
        int dice1 = r.Next(1, 7);
        int dice2 = r.Next(1, 7);

        if (dice1 == 6) countOfSix++;
        if (dice2 == 6) countOfSix++;

        // Geijk getallen is +10
        if (dice1 == dice2) multiplier += 10;
        // Beide 1 is reset
        if (dice1 == 1 && dice2 == 1) multiplier = 0;
        // Beide 6 is +50
        if (dice1 == 6 && dice2 == 6) multiplier += 50;

        Console.WriteLine($"Doublesteen 1 is {dice1}");
        Console.WriteLine($"Doublesteen 2 is {dice2}");
        Console.WriteLine($"Multiplier is {multiplier}");
    }

    if (countOfSix > 4) multiplier += 2;
}

Console.WriteLine($"Uw inzet is: {invoer}");
Console.WriteLine($"Uw multiplier is: {multiplier}");
Console.WriteLine($"De prijs is {multiplier * inzet}.");