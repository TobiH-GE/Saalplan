﻿using System;

namespace Schauspielhaus // nicht komplett, nicht funktionsfähig !!!
{
    class Saalplan
    {
        Veranstaltung Veranstaltung;
        Spielstätte Spielstätte;
        Platz[] AllePlaetze;

        public bool istFrei(Platz Platz)
        {
            if (Platz.bestaetigt() != 0)
                return false;
            else
                return true;
        }
        public void reservieren(Platz Platz)
        {
            
        }
        public Spielstätte getSpielstaette()
        {
            return Spielstätte;
        }
        public void setSpielstaette(Spielstätte Spielstätte)
        {
            this.Spielstätte = Spielstätte;
        }
        public Veranstaltung getVeranstaltung()
        {
            return Veranstaltung;
        }
        public void setVeranstaltung(Veranstaltung Veranstaltung)
        {
            this.Veranstaltung = Veranstaltung;
        }
        public Platz[] getPlaetze()
        {
            return AllePlaetze;
        }
        public void setPlaetze(Platz[] AllePlaetze)
        {
            this.AllePlaetze = AllePlaetze;
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

        public int bestaetigt()
        {
            return Nummer;
        }
    }
    class Veranstaltungsplan
    {
        Saalplan Saalplan;

        public Saalplan getSaalplan()
        {
            return Saalplan;
        }
        public void setSaalplan(Saalplan Saalplan)
        {
            this.Saalplan = Saalplan;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Platz NeuerPlatz = new Platz();
        }
    }
}
