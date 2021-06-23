using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Abschlussprojekt_wieSchneider
{
    class BasisstructureData
    {
        public string Source { get; set; }


        //nur Testproperties
        //können dann geöscht werden
        //sind nur für den Test vorhanden => diese sind mit den DataGrid der Chartform verbunden
        //das heißt im Programmstart können unten Werte eingegeben werden werden mithilfe des DataGridview mit diesen Properties verbunden sind
        //dadurch wird das Chart manuell erstellt
        //für unser Programm eig nicht relevant
        public double Monat1 { get; set; }
        public double Monat2 { get; set; }
        public double Monat3 { get; set; }

        public double Monat4 { get; set; }

        public double Monat5 { get; set; }
        public double Monat6 { get; set; }
        public double Monat7 { get; set; }
        public double Monat8 { get; set; }
        public double Monat9 { get; set; }
        public double Monat10 { get; set; }
        public double Monat11 { get; set; }
        public double Monat12 { get; set; }


        //richtige Properties
        //Diese Klasse wird beim Filedownload erstellt 
        //Enthält sozusagen die Rohdaten des Files
        public string Date { get; set; }

        public string State { get; set; }
        public double ConfirmedCases { get; set; }
        public double Deaths { get; set; }
        public double Recovered { get; set; }
        public double Hospitalizations { get; set; }
        public double IntenisveCare { get; set; }
        public double Tested { get; set; }
        public double TestedPCR { get; set; }
        public double TestedANT { get; set; }

        //Schon vorgefertigt => wird beim Laden des Charts aufgerufen
        public object this[string propertyName]
        {
            get { return this.GetType().GetProperty(propertyName).GetValue(this, null); }
            set { this.GetType().GetProperty(propertyName).SetValue(this, value, null); }
        }

        //Funktion um das Bundesland des Objektes zu erhalten
        public string GetBundesland()
        {
            return $"{State}";
        }

        //Funktion um den ankommenden String mit dem Property zu vergleichen
        //Wird verwendet um bei DataList (dem Filter) die Daten des ausgewählten Bundeslandes downzuloaden
        public bool EqualTextandState(string selectstring)
        {
            bool test = false;
            return test = String.Equals($"{State}", selectstring);
        }
    }
}
