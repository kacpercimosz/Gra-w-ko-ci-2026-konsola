using System;

public class Kosc
{
    public static int liczbaInstancji = 0;

    public static string[] nazwyPlikow =
    {
        "kosc0.png",
        "kosc1.png",
        "kosc2.png",
        "kosc3.png",
        "kosc4.png",
        "kosc5.png",
        "kosc6.png"
    };

    public int liczbaOczek;
    public int identyfikatorPliku;
    public bool dostepna;

    public Kosc(int wartosc)
    {
        if (wartosc < 1 || wartosc > 6)
        {
            wartosc = 0;
        }

        liczbaOczek = wartosc;
        identyfikatorPliku = wartosc;
        dostepna = true;

        liczbaInstancji++;
    }

    public Kosc()
    {
        liczbaOczek = Random.Shared.Next(1, 7);
        identyfikatorPliku = liczbaOczek;
        dostepna = true;

        liczbaInstancji++;
    }

    public void Rzut()
    {
        if (dostepna == true)
        {
            liczbaOczek = Random.Shared.Next(1, 7);
            identyfikatorPliku = liczbaOczek;
        }
    }

    public void Zablokuj()
    {
        dostepna = false;
    }

    public string PodajWynikSlownie()
    {
        switch (liczbaOczek)
        {
            case 1: return "jeden";
            case 2: return "dwa";
            case 3: return "trzy";
            case 4: return "cztery";
            case 5: return "pięć";
            case 6: return "sześć";
            default: return "zero";
        }
    }
}