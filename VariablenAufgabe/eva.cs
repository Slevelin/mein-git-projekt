Console.Write("Gib deinen Namen ein:");
string name = Console.ReadLine()!;
Console.WriteLine("Hallo, " + name + "! Welche Zahlen Addiren wir heute?");
Console.Write("Gib die erste Zahl ein: ");
int Nummer1 = int.Parse(Console.ReadLine()!);
Console.Write("Gib die zweite Zahl ein: ");
int Nummer2 = int.Parse(Console.ReadLine()!);
int Summe = Nummer1 + Nummer2;
Console.WriteLine("Die Summe ist " + Summe);