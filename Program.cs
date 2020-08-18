using System;

namespace Saalplan
{
    class Saalplan
    {
        Veranstaltung Veranstaltung;
        Spielstätte Spielstätte;
    }
    class Veranstaltung
    {
        string Name;
        double Datum;
        double Zeit;
    }
    class Spielstätte
    {
        string Name;
        string Anschrift;
    }
    class Platz
    {
        int Nummer;
        int Reihe;
    }
    class Veranstaltungsplan
    {
        Saalplan Saalplan;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
