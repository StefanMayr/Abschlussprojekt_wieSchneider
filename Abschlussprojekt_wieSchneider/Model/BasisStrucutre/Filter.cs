using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abschlussprojekt_wieSchneider
{
    static class Filter
    {
        public static List<DataList> Statefilter(List<BasisstructureData> Rawdownload, string selectedtext)
        {
            List<DataList> Umwandlungsliste = new List<DataList>();
            for (int i = 0; i < Rawdownload.Count; i++)
            {

                if (Rawdownload[i].EqualTextandState(selectedtext) == true)
                {
                    int k = Umwandlungsliste.Count;
                    Umwandlungsliste.Add(new DataList());
                    Umwandlungsliste[k].Date = Rawdownload[i].Date;
                    Umwandlungsliste[k].ConfirmedCases = Rawdownload[i].ConfirmedCases;
                    Umwandlungsliste[k].Deaths = Rawdownload[i].Deaths;
                    Umwandlungsliste[k].Recovered = Rawdownload[i].Recovered;
                    Umwandlungsliste[k].Hospitalizations = Rawdownload[i].Hospitalizations;
                    Umwandlungsliste[k].IntenisveCare = Rawdownload[i].IntenisveCare;
                    Umwandlungsliste[k].Tested = Rawdownload[i].Tested;
                    Umwandlungsliste[k].TestedPCR = Rawdownload[i].TestedPCR;
                    Umwandlungsliste[k].TestedANT = Rawdownload[i].TestedANT;
                }
            }
            return Umwandlungsliste;
        }

        public static List<DataList> Calcarithmeticfilter(string selectedtext, List<DataList> BearbeitendeListe)
        {
            List<DataList> PrivateÜbergabeListemitfertigenDaten = new List<DataList>();
            int Laufvariable = 0;
            int daysoftheweek = 7;
            for (int i = 0; i < 16; i++)
            {
                PrivateÜbergabeListemitfertigenDaten.Add(new DataList());
                PrivateÜbergabeListemitfertigenDaten[i].State = selectedtext;
                PrivateÜbergabeListemitfertigenDaten[i].ConfirmedCases = Arithmeticmean(Laufvariable, daysoftheweek, BearbeitendeListe, "ConfirmedCases");
                PrivateÜbergabeListemitfertigenDaten[i].Deaths = Arithmeticmean(Laufvariable, daysoftheweek, BearbeitendeListe, "Deaths");
                PrivateÜbergabeListemitfertigenDaten[i].Recovered = Arithmeticmean(Laufvariable, daysoftheweek, BearbeitendeListe, "Recovered");
                PrivateÜbergabeListemitfertigenDaten[i].Hospitalizations = Arithmeticmean(Laufvariable, daysoftheweek, BearbeitendeListe, "Hospitalization");
                PrivateÜbergabeListemitfertigenDaten[i].IntenisveCare = Arithmeticmean(Laufvariable, daysoftheweek, BearbeitendeListe, "IntensiveCare");
                PrivateÜbergabeListemitfertigenDaten[i].Tested = Arithmeticmean(Laufvariable, daysoftheweek, BearbeitendeListe, "Tested");
                PrivateÜbergabeListemitfertigenDaten[i].TestedPCR = Arithmeticmean(Laufvariable, daysoftheweek, BearbeitendeListe, "TestedPCR");
                PrivateÜbergabeListemitfertigenDaten[i].TestedANT = Arithmeticmean(Laufvariable, daysoftheweek, BearbeitendeListe, "TestedANT");
                if ((BearbeitendeListe.Count - Laufvariable) >= 7)
                {
                    Laufvariable = Laufvariable + 7;
                }
                if ((BearbeitendeListe.Count - Laufvariable) < 7)
                {
                    Laufvariable = (BearbeitendeListe.Count - Laufvariable);
                    daysoftheweek = (BearbeitendeListe.Count - Laufvariable);
                }
            }
            return PrivateÜbergabeListemitfertigenDaten;
        }

        private static double Arithmeticmean(int Laufvariable, int daysofweek, List<DataList> MyListtomaketheAM, string Property)
        {
            double sum = 0;
            for (int g = 0; g < daysofweek; g++)
            {
                sum = sum + (MyListtomaketheAM[Laufvariable + g].GetPropertyforArithmetic(Property));
            }
            sum = sum / daysofweek;
            return sum;
        }

        public static List<DataList> ScaleAxis(List<DataList> BearbeitendeListe)
        {
            //List<DataList> FertigeListe = new List<DataList>();

            if (BearbeitendeListe[0].State == "Burgenland")
            {
                for (int i = 0; i < BearbeitendeListe.Count; i++)
                {
                    BearbeitendeListe[i].ConfirmedCases = BearbeitendeListe[i].ConfirmedCases / 100;
                    BearbeitendeListe[i].Recovered = BearbeitendeListe[i].Recovered / 100;
                    BearbeitendeListe[i].Tested = BearbeitendeListe[i].Tested / 10000;
                    BearbeitendeListe[i].TestedPCR = BearbeitendeListe[i].TestedPCR / 10000;
                    BearbeitendeListe[i].TestedANT = BearbeitendeListe[i].TestedANT / 10000;
                }
            }
            if (BearbeitendeListe[0].State == "Kärnten")
            {
                for (int i = 0; i < BearbeitendeListe.Count; i++)
                {
                    BearbeitendeListe[i].ConfirmedCases = BearbeitendeListe[i].ConfirmedCases / 100;
                    BearbeitendeListe[i].Recovered = BearbeitendeListe[i].Recovered / 100;
                    BearbeitendeListe[i].Tested = BearbeitendeListe[i].Tested / 10000;
                    BearbeitendeListe[i].TestedPCR = BearbeitendeListe[i].TestedPCR / 10000;
                    BearbeitendeListe[i].TestedANT = BearbeitendeListe[i].TestedANT / 10000;
                }
            }
            if (BearbeitendeListe[0].State == "Vorarlberg")
            {
                for (int i = 0; i < BearbeitendeListe.Count; i++)
                {
                    BearbeitendeListe[i].ConfirmedCases = BearbeitendeListe[i].ConfirmedCases / 100;
                    BearbeitendeListe[i].Recovered = BearbeitendeListe[i].Recovered / 100;
                    BearbeitendeListe[i].Tested = BearbeitendeListe[i].Tested / 10000;
                    BearbeitendeListe[i].TestedPCR = BearbeitendeListe[i].TestedPCR / 10000;
                    BearbeitendeListe[i].TestedANT = BearbeitendeListe[i].TestedANT / 10000;
                }
            }
            if (BearbeitendeListe[0].State == "Tirol")
            {
                for (int i = 0; i < BearbeitendeListe.Count; i++)
                {
                    BearbeitendeListe[i].ConfirmedCases = BearbeitendeListe[i].ConfirmedCases / 100;
                    BearbeitendeListe[i].Recovered = BearbeitendeListe[i].Recovered / 100;
                    BearbeitendeListe[i].Tested = BearbeitendeListe[i].Tested / 10000;
                    BearbeitendeListe[i].TestedPCR = BearbeitendeListe[i].TestedPCR / 10000;
                    BearbeitendeListe[i].TestedANT = BearbeitendeListe[i].TestedANT / 10000;
                }
            }
            if (BearbeitendeListe[0].State == "Salzburg")
            {
                for (int i = 0; i < BearbeitendeListe.Count; i++)
                {
                    BearbeitendeListe[i].ConfirmedCases = BearbeitendeListe[i].ConfirmedCases / 100;
                    BearbeitendeListe[i].Recovered = BearbeitendeListe[i].Recovered / 100;
                    BearbeitendeListe[i].Tested = BearbeitendeListe[i].Tested / 10000;
                    BearbeitendeListe[i].TestedPCR = BearbeitendeListe[i].TestedPCR / 10000;
                    BearbeitendeListe[i].TestedANT = BearbeitendeListe[i].TestedANT / 10000;
                }
            }
            if (BearbeitendeListe[0].State == "Oberösterreich")
            {
                for (int i = 0; i < BearbeitendeListe.Count; i++)
                {
                    BearbeitendeListe[i].ConfirmedCases = BearbeitendeListe[i].ConfirmedCases / 100;
                    BearbeitendeListe[i].Recovered = BearbeitendeListe[i].Recovered / 100;
                    BearbeitendeListe[i].Tested = BearbeitendeListe[i].Tested / 10000;
                    BearbeitendeListe[i].TestedPCR = BearbeitendeListe[i].TestedPCR / 10000;
                    BearbeitendeListe[i].TestedANT = BearbeitendeListe[i].TestedANT / 10000;
                }
            }
            if (BearbeitendeListe[0].State == "Niederösterreich")
            {
                for (int i = 0; i < BearbeitendeListe.Count; i++)
                {
                    BearbeitendeListe[i].ConfirmedCases = BearbeitendeListe[i].ConfirmedCases / 100;
                    BearbeitendeListe[i].Recovered = BearbeitendeListe[i].Recovered / 100;
                    BearbeitendeListe[i].Tested = BearbeitendeListe[i].Tested / 10000;
                    BearbeitendeListe[i].TestedPCR = BearbeitendeListe[i].TestedPCR / 10000;
                    BearbeitendeListe[i].TestedANT = BearbeitendeListe[i].TestedANT / 10000;
                }
            }
            if (BearbeitendeListe[0].State == "Wien")
            {
                for (int i = 0; i < BearbeitendeListe.Count; i++)
                {
                    BearbeitendeListe[i].ConfirmedCases = BearbeitendeListe[i].ConfirmedCases / 100;
                    BearbeitendeListe[i].Recovered = BearbeitendeListe[i].Recovered / 100;
                    BearbeitendeListe[i].Tested = BearbeitendeListe[i].Tested / 10000;
                    BearbeitendeListe[i].TestedPCR = BearbeitendeListe[i].TestedPCR / 10000;
                    BearbeitendeListe[i].TestedANT = BearbeitendeListe[i].TestedANT / 10000;
                }
            }
            if (BearbeitendeListe[0].State == "Steiermark")
            {
                for (int i = 0; i < BearbeitendeListe.Count; i++)
                {
                    BearbeitendeListe[i].ConfirmedCases = BearbeitendeListe[i].ConfirmedCases / 100;
                    BearbeitendeListe[i].Recovered = BearbeitendeListe[i].Recovered / 100;
                    BearbeitendeListe[i].Tested = BearbeitendeListe[i].Tested / 10000;
                    BearbeitendeListe[i].TestedPCR = BearbeitendeListe[i].TestedPCR / 10000;
                    BearbeitendeListe[i].TestedANT = BearbeitendeListe[i].TestedANT / 10000;
                }
            }
            if (BearbeitendeListe[0].State == "Österreich")
            {
                for (int i = 0; i < BearbeitendeListe.Count; i++)
                {
                    BearbeitendeListe[i].ConfirmedCases = BearbeitendeListe[i].ConfirmedCases / 100;
                    BearbeitendeListe[i].Recovered = BearbeitendeListe[i].Recovered / 100;
                    BearbeitendeListe[i].Tested = BearbeitendeListe[i].Tested / 10000;
                    BearbeitendeListe[i].TestedPCR = BearbeitendeListe[i].TestedPCR / 10000;
                    BearbeitendeListe[i].TestedANT = BearbeitendeListe[i].TestedANT / 10000;
                }
            }
            return BearbeitendeListe;
        }
    }
}
