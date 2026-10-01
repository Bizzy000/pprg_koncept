using System;
class Program
{
    static void Main()
    {
        int krysztaly = 3;
        int ziola = 2;
        Console.WriteLine($"ile chcesz wykonac mikstur?");
        int mikstury = int.Parse(Console.ReadLine()!);
        double zasoby = krysztaly + ziola;
        Console.WriteLine($"potrzebujesz do tego dokladnie Krysztalow: {mikstury * krysztaly} i dokladnie Ziola: {mikstury * ziola} by wykonac {mikstury} mikstur");
    }
}

