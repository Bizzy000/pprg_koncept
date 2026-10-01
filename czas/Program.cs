using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("ile sekund?");
        int sekundy = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"to jest {sekundy / 60} minut i {sekundy % 60} sekund");
    }
}
