using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Czesc jak masz na imie?");
        string imie = Console.ReadLine()!;
        Console.WriteLine("Jaki jest twoj ulubiony kolor?");
        string kolor = Console.ReadLine()!;
        Console.WriteLine("Ile masz lat?");
        string wiek = Console.ReadLine()!;
        Console.WriteLine($"Czesc! {imie}. Masz {wiek} lat i twoj ulubiony kolor to {kolor} swietnie wybrales!");
        Console.WriteLine($"Za rok bedziesz miec {int.Parse(wiek) + 1} lat a za pięć {int.Parse(wiek) + 5} lat.");
    }
}

