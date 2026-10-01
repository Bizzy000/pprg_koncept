using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Jak masz na imię?");
        string name = Console.ReadLine()!;
        Console.WriteLine("Witaj, " + name + "!. Skad przybywasz?");
        string kraina = Console.ReadLine()!;
        Console.WriteLine("ile trwa twoja podróż?");
        double czas = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Ah, tak więc pochodzisz z " + kraina + " i twoja podróż trwa " + czas + ".");

    }
}
