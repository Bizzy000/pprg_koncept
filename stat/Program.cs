using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj imie bohatera:");
        string imie = Console.ReadLine()!;
        Console.WriteLine("Podaj zdrowie poczatkowe bohatera:");
        int currenthealth = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Podaj podstawowy dmg broni bohatera:");
        int basedmg = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Podaj sile bohatera:");
        int sila = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Podaj ratio specjalnego dmg:");
        double ratio = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Podaj ilosc atakow:");
        int ovratk = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Podaj ilosc miejsca w plecaku:");
        int miejsce = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Ile masz itemow:");
        int itemy = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Podaj ilosc monet w skarbie:");
        int wartosc = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Podaj ile osob bylo w zalodze:");
        int osoby = int.Parse(Console.ReadLine()!);

        int wolnemiejsce = miejsce - itemy;
        int zdrowie = 100;
        int obrazeniacalkowite = basedmg + (int)(basedmg * ratio) * ovratk;
        int pozostalezdrowie = currenthealth - obrazeniacalkowite;
        bool Zyje = pozostalezdrowie > 0;
        bool mapelnezycie = currenthealth == zdrowie;
        double procentzdrowia = (double)pozostalezdrowie / zdrowie * 100;
        int obrazenianormalne = basedmg * sila;
        int reszta = (int)(wartosc % osoby);
        bool mapa = true;
        bool leczenie = true;



        Console.WriteLine("+++++++++++++++BOHATER+++++++++++++++");
        Console.WriteLine($"Imie bohatera: {imie}");
        Console.WriteLine("Ikona bohatera: @");
        Console.WriteLine("-------------STATYSTYKI--------------");
        Console.WriteLine($"Zdrowie : {pozostalezdrowie}/{zdrowie} {procentzdrowia}%");
        Console.WriteLine($"Sila: {sila}");
        Console.WriteLine($"Obrazenia broni: {basedmg}");
        Console.WriteLine($"Atak normalny: {obrazenianormalne}");
        Console.WriteLine($"Mnoznik specjalnego ataku: {ratio}");
        Console.WriteLine($"Atak specjalny: {basedmg * ratio}");
        Console.WriteLine("---------------ZASOBY----------------");
        Console.WriteLine($"Ilosc miejsca w plecaku: {itemy}/{miejsce}");
        Console.WriteLine($"Wolne miejsce: {wolnemiejsce}");
        Console.WriteLine($"Wartość skarbu: {wartosc}");
        Console.WriteLine($"Ilosc osob w zalodze: {osoby}");
        Console.WriteLine($"Podzial skarbu: {wartosc / osoby}");
        Console.WriteLine($"Reszta skarbu: {reszta}");
        Console.WriteLine("-------------INFORMACJE----------------");
        Console.WriteLine($"Czy masz mape?: {mapa}");
        Console.WriteLine($"Czy bohater zyje?: {Zyje}");
        Console.WriteLine($"Czy bohater ma pelne zdrowie?: {mapelnezycie}");
        Console.WriteLine($"Czy bohater potrzebuje leczenia?: {leczenie}");
        Console.WriteLine("Ma wolne miejsce w plecaku?: " + (wolnemiejsce > 0));
        Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++");


    }
}