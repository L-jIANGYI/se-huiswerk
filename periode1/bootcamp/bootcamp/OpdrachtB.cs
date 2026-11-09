// ===================
// Deel 1 - opdracht B
// ===================

string voornaam = "Jiangyi";
Console.WriteLine($"Hello {voornaam}!");

string var1 = "C";
int num1 = 123;
double num2 = 1.5;
Boolean status = false;

Console.WriteLine("===================");
Console.WriteLine($"{var1} {num1}");
Console.WriteLine($"{num2} {status}");
Console.WriteLine("===================");

double rest = num1 % num2;
Console.WriteLine(rest);

Console.ReadKey();
Console.Clear();
Console.ReadKey();

// ===================
// Deel 1 - opdracht C
// ===================
int temperatuur;

Console.WriteLine("Geef een temperatuur in Celsius");
temperatuur = Convert.ToInt32(Console.ReadLine());
double fahrenheit = temperatuur * 1.8 + 32;
Console.WriteLine($"{temperatuur} Celsius is {fahrenheit:F2} Fahrenheit");

Console.ReadKey();
Console.Clear();
Console.ReadKey();

int euro;

Console.WriteLine("Voer getallen in voor Euro");
euro = Convert.ToInt32(Console.ReadLine());
double usd = (euro * 1.16);
Console.WriteLine($"{euro} Euro is {usd:F2} USD");

Console.ReadKey();
Console.Clear();
Console.ReadKey();

// ===================
// Deel 1 - opdracht D
// ===================
Console.WriteLine("Ideaal gewicht berekenen");

Console.ReadKey();

Console.WriteLine("Voer je geslacht in: man / vrouw");
string geslacht = Console.ReadLine();

if (geslacht.ToLower() == "man")
{
    Console.WriteLine("Voer nu je lengte (cm) in:");
    double lengte = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Je ideale gewicht is {((lengte - 100) * 0.9):F2}.");
}
else if (geslacht.ToLower() == "vrouw")
{
    Console.WriteLine("Voer je lengte (cm) in:");
    double lengte = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Voer je polsomtrek (cm) in:");
    double pols = Convert.ToInt32(Console.ReadLine());

    double ideal = (lengte + 4 * pols - 100) / 2;
    Console.WriteLine($"Je ideale gewicht is {ideal:F2}.");
}
else
{
    Console.WriteLine($"{geslacht} zijn er geen berekeningen voor ideale gewicht.");
}

Console.ReadKey();
Console.Clear();
Console.ReadKey();

// opdracht D - 7
Console.WriteLine("Kies een taal uit: Nederlands, Engels, Frans, Duits en Spaans");
string taal = Console.ReadLine();

if (taal == "Nederlands")
{
    Console.WriteLine("Tot ziens");
}
else if (taal == "Engels")
{
    Console.WriteLine("Tot ziens (EN)");
}
else if (taal == "Frans")
{
    Console.WriteLine("Tot ziens (FA)");
}
else if (taal == "Duits")
{
    Console.WriteLine("Tot ziens (DE)");
}
else if (taal == "Spaans")
{
    Console.WriteLine("Tot ziens (ES)");
}

Console.ReadKey();