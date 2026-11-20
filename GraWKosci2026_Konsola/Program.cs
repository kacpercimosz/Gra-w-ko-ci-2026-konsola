using System;

class Program
{
    static void WyswietlInformacje(Kosc kosc)
    {
        Console.WriteLine();
        Console.WriteLine("Liczba utworzonych kosci: "
            + Kosc.liczbaInstancji);

        Console.WriteLine("Liczba oczek: "
            + kosc.liczbaOczek);

        Console.WriteLine("Wynik slownie: "
            + kosc.PodajWynikSlownie());

        Console.WriteLine("Nazwa pliku: "
            + Kosc.nazwyPlikow[kosc.identyfikatorPliku]);

        Console.WriteLine("-----------------------------");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("================================");
        Console.WriteLine("       GRA W KOSCI 2026");
        Console.WriteLine("================================");

        Console.WriteLine();
        Console.Write("Podaj liczbe oczek pierwszej kosci: ");

        int wartosc;

        if (!int.TryParse(Console.ReadLine(), out wartosc))
        {
            wartosc = 0;
        }

        Kosc pierwszaKosc = new Kosc(wartosc);

        Console.WriteLine();
        Console.WriteLine("PIERWSZA KOSC:");

        WyswietlInformacje(pierwszaKosc);

        Kosc drugaKosc = new Kosc();

        Console.WriteLine("DRUGA KOSC:");

        WyswietlInformacje(drugaKosc);

        Console.WriteLine();
        Console.WriteLine("Nacisnij dowolny klawisz...");
        Console.ReadKey();
    }
}