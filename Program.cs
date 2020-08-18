using System;

namespace Schauspielhaus
{
    class Saalplan
    {
        Veranstaltung Veranstaltung;
        Spielstätte Spielstätte;
        Platz[] AllePlaetze;
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

        public void bestaetigt()
        {
            
        }
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
