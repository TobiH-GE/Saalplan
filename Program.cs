using System;

namespace Schauspielhaus
{
    class Saalplan
    {
        Veranstaltung Veranstaltung;
        Spielstätte Spielstätte;
        Platz[] AllePlaetze;

        public void istFrei()
        {

        }
        public void reservieren()
        {

        }
        public void getSpielstaette()
        {

        }
        public void setSpielstaette()
        {

        }
        public void getVeranstaltung()
        {

        }
        public void setVeranstaltung()
        {


        }
        public void getPlaetze()
        {

        }
        public void setPlaetze()
        {


        }
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

        public void getSaalplan()
        {

        }
        public void setSaalplan()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
