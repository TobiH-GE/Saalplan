using System;

namespace Schauspielhaus // nicht komplett, nicht funktionsfähig !!!
{
    class Veranstaltungsplan
    {
        Saalplan[] Saalplaene;

        public Saalplan getSaalplan()
        {
            return Saalplaene[0];
        }
        public void setSaalplan(Saalplan Saalplan)
        {

        }
    }
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
        public void setPlaetze(Platz EinPlaetz)
        {
            this.AllePlaetze[0] = EinPlaetz;
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
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Veranstaltung!");

            const int MaxPlaene = 100;

            Veranstaltungsplan[] AlleVeranstaltungsplaene = new Veranstaltungsplan[MaxPlaene];

            AlleVeranstaltungsplaene[0] = new Veranstaltungsplan();

            Saalplan NeuerSaalplan = new Saalplan();
            Veranstaltung NeueVeranstaltung = new Veranstaltung();
            Spielstätte NeueSpielstaette = new Spielstätte();
            Platz NeuerPlatz = new Platz();

            NeuerSaalplan.setPlaetze(NeuerPlatz);
            NeuerSaalplan.setVeranstaltung(NeueVeranstaltung);
            NeuerSaalplan.setSpielstaette(NeueSpielstaette);
            AlleVeranstaltungsplaene[0].setSaalplan(NeuerSaalplan);         
        }
    }
}
