using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ile obrazen ma bron?");
        int dmg = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Ile bohater ma bazowo obrazen?");
        int baseDmg = int.Parse(Console.ReadLine()!);
        double atak = dmg + baseDmg;
        double mocnyatak = atak * 2;
        double dps = atak * 2 + mocnyatak;
        Console.WriteLine($"Obrazenia z broni: {dmg}");
        Console.WriteLine($"Obrazenia bazowe: {baseDmg}");
        Console.WriteLine($"Atak: {atak}");
        Console.WriteLine($"Mocny atak: {mocnyatak}");
        Console.WriteLine($"DPS: {dps}");
    }
}