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
            Filedownloader = new Filedownload();
            bool j = Filedownloader.ReadFile("", "");
            List<DataList> ConvertList = new List<DataList>();
            ConvertedDataforList = new List<DataList>();

            //Aufgerufen wenn Download erfolgreich
            if (j == true)
            {
                //Filter
                ConvertList = Filter.Statefilter(Filedownloader.Rawdownload, selectedtext);
                ConvertedDataforList = Filter.Calcarithmeticfilter(selectedtext, ConvertList);
                ConvertedDataforList = Filter.ScaleAxis(ConvertedDataforList);
            }
        }
    }
}
