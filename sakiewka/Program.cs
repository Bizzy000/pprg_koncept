using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbe miedzianych monet:");
        int miedziane = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Podaj liczbe srebrnych monet:");
        int srebrne = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Podaj liczbe zlote monet:");
        int zlote = int.Parse(Console.ReadLine()!);
        double wartosc = miedziane * 0.01 + srebrne * 0.1 + zlote * 1;
        Console.WriteLine($"Wartosc wszystkich monet wynosi: {wartosc}");

    }
}
