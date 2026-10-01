using System;

class Program
{
    static void Main()
    {
        decimal cena = 864.33m;
        Console.WriteLine("Na ile nocy chcesz zostac?");
        int nocy = int.Parse(Console.ReadLine()!);
        decimal koszt = cena * nocy;
        Console.WriteLine($"Koszt twojego zakwaterowania to {koszt} zl.");

    }
}
