using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("ile bylo monet w skarbie?");
        int iloscmonet = int.Parse(Console.ReadLine()!);
        Console.WriteLine("ile osob podzieli sie skarbem?");
        int zaloga = int.Parse(Console.ReadLine()!);
        int skarb = iloscmonet / zaloga;
        Console.WriteLine("kazdy czlonek zalogi dostanie " + skarb + " monet");

    }
}
