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
                for(int i = 0; i < Filedownloader.Rawdownload.Count; i++)
                {
                    //Die Vorschleife zählt herunter und wählt vergleicht die Zeilen(Bundesländer) mit dem ausgewählten Bundesland
                    //IN den Rohdaten sind nämlich alle Bundesländer enthalten
                    //Der Filter holt sich nur die Daten vom Bundesland das augewählt wurde (selectedtext)
                    if(Filedownloader.Rawdownload[i].EqualTextandState(selectedtext) == true)
                    {
                        //For wird gleich abgebrochen
                        //Kann vl besser gemacht werden
                        //k++ wird als unerreichbarer Code angezeigt
                        for (int k = ConvertList.Count; k < ConvertList.Count + 1; k++)
                        {
                            ConvertList.Add(new DataList());
                            ConvertList[k].Date = Filedownloader.Rawdownload[i].Date;
                            ConvertList[k].ConfirmedCases = Filedownloader.Rawdownload[i].ConfirmedCases;
                            ConvertList[k].Deaths = Filedownloader.Rawdownload[i].Deaths;
                            ConvertList[k].Recovered = Filedownloader.Rawdownload[i].Recovered;
                            ConvertList[k].Hospitalizations = Filedownloader.Rawdownload[i].Hospitalizations;
                            ConvertList[k].IntenisveCare = Filedownloader.Rawdownload[i].IntenisveCare;
                            ConvertList[k].Tested = Filedownloader.Rawdownload[i].Tested;
                            ConvertList[k].TestedPCR = Filedownloader.Rawdownload[i].TestedPCR;
                            ConvertList[k].TestedANT = Filedownloader.Rawdownload[i].TestedANT;
                            break;
                        }

                    }
                }


                //Diese Funktion rechnet jeweils 7 Tage zu einer Woche zusammen
                //Die Rohdaten enthält als Objekte die einzelnen Tage (107 Tage)
                //Diese werden hier zu 15 vollen und einer Woche mit 2 Tage zusammengefasst
                //Die Werte sind das arithmetische Mittel 

                //Da hier viele Schritte des öfteren Auftreten könnte sie vl in einer Funktion zusammengefasst werden
                int Laufvariable = 0;
                for (int l = 0; l < 15; l++)
                {
                    ConvertedDataforList.Add(new DataList());

                    ConvertedDataforList[l].State = selectedtext;
                    double sum = 0;
                    for (int g = 0; g < 8; g++)
                    {
                        sum = sum + (ConvertList[Laufvariable + g].ConfirmedCases);
                    }
                    sum = sum / 7;
                    ConvertedDataforList[l].ConfirmedCases = sum;

                    sum = 0;
                    for (int g = 0; g < 8; g++)
                    {
                        sum = sum + (ConvertList[Laufvariable + g].Deaths);
                    }
                    sum = sum / 7;
                    ConvertedDataforList[l].Deaths = sum;

                    sum = 0;
                    for (int g = 0; g < 8; g++)
                    {
                        sum = sum + (ConvertList[Laufvariable + g].Recovered);
                    }
                    sum = sum / 7;
                    ConvertedDataforList[l].Recovered = sum;

                    sum = 0;
                    for (int g = 0; g < 8; g++)
                    {
                        sum = sum + (ConvertList[Laufvariable + g].Hospitalizations);
                    }
                    sum = sum / 7;
                    ConvertedDataforList[l].Hospitalizations = sum;

                    sum = 0;
                    for (int g = 0; g < 8; g++)
                    {
                        sum = sum + (ConvertList[Laufvariable + g].IntenisveCare);
                    }
                    sum = sum / 7;
                    ConvertedDataforList[l].IntenisveCare = sum;

                    sum = 0;
                    for (int g = 0; g < 8; g++)
                    {
                        sum = sum + (ConvertList[Laufvariable + g].Tested);
                    }
                    sum = sum / 7;
                    ConvertedDataforList[l].Tested = sum;

                    sum = 0;
                    for (int g = 0; g < 8; g++)
                    {
                        sum = sum + (ConvertList[Laufvariable + g].TestedPCR);
                    }
                    sum = sum / 7;
                    ConvertedDataforList[l].TestedPCR = sum;

                    sum = 0;
                    for (int g = 0; g < 8; g++)
                    {
                        sum = sum + (ConvertList[Laufvariable + g].TestedANT);
                    }
                    sum = sum / 7;
                    ConvertedDataforList[l].TestedANT = sum;
                    Laufvariable = Laufvariable + 7;
                }


                //Diese Funktion ist dieselbe wie die obere 
                //Jedoch besteht die letzte Woche nur aus 2 Tagen => deswegen wurden Laufvariablen der Indexe angepasst
                //Kann vl mit der oberen zusammen zu einer Funktion zusammengefasst werden zu einer Funktion
                //Diese müsste jedoch die Tage abfragen und bei den letzten dann eben nur die zwei tage rechnen
                int Laufvariable2 = 105;
                for (int l = 15; l < 16; l++)
                {
                    ConvertedDataforList.Add(new DataList());

                    ConvertedDataforList[l].State = selectedtext;
                    double sum = 0;
                    for (int g = 0; g < 2; g++)
                    {
                        sum = sum + (ConvertList[Laufvariable2 + g].ConfirmedCases);
                    }
                    sum = sum / 2;
                    ConvertedDataforList[l].ConfirmedCases = sum;

                    sum = 0;
                    for (int g = 0; g < 2; g++)
                    {
                        sum = sum + (ConvertList[Laufvariable2 + g].Deaths);
                    }
                    sum = sum / 2;
                    ConvertedDataforList[l].Deaths = sum;

                    sum = 0;
                    for (int g = 0; g < 2; g++)
                    {
                        sum = sum + (ConvertList[Laufvariable2 + g].Recovered);
                    }
                    sum = sum / 2;
                    ConvertedDataforList[l].Recovered = sum;

                    sum = 0;
                    for (int g = 0; g < 2; g++)
                    {
                        sum = sum + (ConvertList[Laufvariable2 + g].Hospitalizations);
                    }
                    sum = sum / 2;
                    ConvertedDataforList[l].Hospitalizations = sum;

                    sum = 0;
                    for (int g = 0; g < 2; g++)
                    {
                        sum = sum + (ConvertList[Laufvariable2 + g].IntenisveCare);
                    }
                    sum = sum / 2;
                    ConvertedDataforList[l].IntenisveCare = sum;

                    sum = 0;
                    for (int g = 0; g < 2; g++)
                    {
                        sum = sum + (ConvertList[Laufvariable2 + g].Tested);
                    }
                    sum = sum / 2;
                    ConvertedDataforList[l].Tested = sum;

                    sum = 0;
                    for (int g = 0; g < 2; g++)
                    {
                        sum = sum + (ConvertList[Laufvariable2 + g].TestedPCR);
                    }
                    sum = sum / 2;
                    ConvertedDataforList[l].TestedPCR = sum;

                    sum = 0;
                    for (int g = 0; g < 2; g++)
                    {
                        sum = sum + (ConvertList[Laufvariable2 + g].TestedANT);
                    }
                    sum = sum / 2;
                    ConvertedDataforList[l].TestedANT = sum;
                    Laufvariable2 = Laufvariable2 + 1;

                    
                }

            }
           
        }
    }
}
