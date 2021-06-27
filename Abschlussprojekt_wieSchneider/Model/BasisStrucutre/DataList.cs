using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abschlussprojekt_wieSchneider
{
    class DataList : BasisstructureData
    {
        //Liste mit den Bundesländern
        public List<string> StatelistinModel { get; private set; }

        //Liste mit den fertignen Daten
        public List<DataList> ConvertedDataforList { get; private set; }
        private Filedownload Filedownloader;

        //Diese Klasse ist der Filter / hier werden die Rohdaten zur fertigen Liste verarbeitet und übergeben
        public DataList()
        {

        }

        //Funktion um aus den Rohdaten die Bundesländern herauszufiltern
        public void Stateloader()
        {
            //Hier wird der Filedownloader erstellt
            Filedownloader = new Filedownload();
            List<string> listtostring = new List<string>();

            //Hier wird die Readfile aufgerufen / nur bool Wert für Modularität
            //Weitergemacht wird nur wenn der Download erfolgreich war => bool = true
            //Gespeichert wird auf Property
            bool j = Filedownloader.ReadFile("", "");
            
            if(j == true)
            {
                for (int i = 1; i <= 10; i++)
                {
                    listtostring.Add(Filedownloader.Teststrinback[i].GetBundesland());
                }
            }
            
            //wird hier dem Property übergeben
            StatelistinModel = listtostring;
        }

        //Filter der Daten 
        public void DownloadDataforChartandConvert(string selectedtext)
        {
            //Filedownloader wird erstellt
            Filedownloader = new Filedownload();

            //Gleich wie oben Download mit bool => weitermachen wenn Download erfolgreich
            bool j = Filedownloader.ReadFile("", "");

            //Hier wird eine Zwischenliste mit den Werten für das Bundesland erstellt
            List<DataList> ConvertList = new List<DataList>();

            //Wird wird das Property instanziert
            ConvertedDataforList = new List<DataList>();


            //Aufgerufen wenn Download erfolgreich
            if (j == true)
            {
                //Filter1 funkt
                //Filter2 Beim bool testet musseigeneFunktion gebaut werden da er sonst nur den ´double in den string umwandelt
                ConvertList = Filter1(Filedownloader.Rawdownload, selectedtext);
                ConvertedDataforList = Filter2(selectedtext, ConvertList);
                
            }
        }

        private List<DataList> Filter1(List<BasisstructureData> Rawdownload, string selectedtext)
        {
            List<DataList> Umwandlungsliste = new List<DataList>();
            for (int i = 0; i < Filedownloader.Rawdownload.Count; i++)
            {
                
                if (Filedownloader.Rawdownload[i].EqualTextandState(selectedtext) == true)
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

        private List<DataList> Filter2(string selectedtext, List<DataList> BearbeitendeListe)
        {
            List<DataList> PrivateÜbergabeListemitfertigenDaten = new List<DataList>();
            int Laufvariable = 0;
            int daysoftheweek = 7;
            for(int i = 0; i < 16; i++)
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
                if((BearbeitendeListe.Count - Laufvariable) >= 7)
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

        private double Arithmeticmean(int Laufvariable, int daysofweek, List<DataList> MyListtomaketheAM, string Property)
        {
            double sum = 0;
            for (int g = 0; g < daysofweek; g++)
            {
                sum = sum + (MyListtomaketheAM[Laufvariable + g].GetPropertyforArithmetic(Property));
            }
            sum = sum / daysofweek;
            return sum;
        }

        private List<DataList> Filter3(List<DataList> BearbeitendeListe)
        {
            List<DataList> FertigeListe = new List<DataList>();

            if (BearbeitendeListe[0].State == "Burgenland")
            {

            }

            return FertigeListe;
        }

    }
}
