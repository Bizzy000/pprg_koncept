using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Czesc podrozniku!!!");
        Console.WriteLine("Ile kilometrow masz do celu?");
        int km = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Ile kilometrow pokonujesz dziennie?");
        int km_dziennie = int.Parse(Console.ReadLine()!);
        int dni = km / km_dziennie;
        Console.WriteLine($"Potrzbujesz na pokonanie dystansu {dni} dni.");

    }
}



