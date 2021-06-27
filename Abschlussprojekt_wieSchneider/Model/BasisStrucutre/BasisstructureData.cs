using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection;

namespace Abschlussprojekt_wieSchneider
{
    class BasisstructureData
    {
        public string Source { get; set; }

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

        public double GetPropertyforArithmetic(string selectstring)
        {
            bool ConfirmedCasesbool = false;
            bool Deathsbool = false;
            bool Recoveredbool = false;
            bool Hospitalizationbool = false;
            bool IntensiveCarebool = false;
            bool Testedbool = false;
            bool TestedPCRbool = false;
            bool TestedANTbool = false;
            //noch bearbeiten
            ConfirmedCasesbool = String.Equals($"ConfirmedCases", selectstring);
            if(ConfirmedCasesbool == true)
            {
                return Convert.ToDouble(ConfirmedCases);
            }
            Deathsbool = String.Equals($"Deaths", selectstring);
            if (Deathsbool == true)
            {
                return Convert.ToDouble(Deaths);
            }
            Recoveredbool = String.Equals($"Recovered", selectstring);
            if (Recoveredbool == true)
            {
                return Convert.ToDouble(Recovered);
            }
            Hospitalizationbool = String.Equals($"Hospitalization", selectstring);
            if (Hospitalizationbool == true)
            {
                return Convert.ToDouble(Hospitalizations);
            }
            IntensiveCarebool = String.Equals($"IntensiveCare", selectstring);
            if (IntensiveCarebool == true)
            {
                return Convert.ToDouble(IntenisveCare);
            }
            Testedbool = String.Equals($"Tested", selectstring);
            if (Testedbool == true)
            {
                return Convert.ToDouble(Tested);
            }
            TestedPCRbool = String.Equals($"TestedPCR", selectstring);
            if (TestedPCRbool == true)
            {
                return Convert.ToDouble(TestedPCR);
            }
            TestedANTbool = String.Equals($"TestedANT", selectstring);
            if (TestedANTbool == true)
            {
                return Convert.ToDouble(TestedANT);
            }
            return 0;
        }

        public void SetProperty(string selectstring, double value)
        {
            bool ConfirmedCasesbool = false;
            bool Deathsbool = false;
            bool Recoveredbool = false;
            bool Hospitalizationbool = false;
            bool IntensiveCarebool = false;
            bool Testedbool = false;
            bool TestedPCRbool = false;
            bool TestedANTbool = false;
            ConfirmedCasesbool = String.Equals($"ConfirmedCases", selectstring);
            if (ConfirmedCasesbool == true)
            {
                ConfirmedCases = value;
            }
            Deathsbool = String.Equals($"Deaths", selectstring);
            if (Deathsbool == true)
            {
                Deaths = value;
            }
            Recoveredbool = String.Equals($"Recovered", selectstring);
            if (Recoveredbool == true)
            {
                Recovered = value;
            }
            Hospitalizationbool = String.Equals($"Hospitalizations", selectstring);
            if (Hospitalizationbool == true)
            {
                Hospitalizations = value;
            }
            IntensiveCarebool = String.Equals($"IntenisveCare", selectstring);
            if (IntensiveCarebool == true)
            {
                IntenisveCare = value;
            }
            Testedbool = String.Equals($"Tested", selectstring);
            if (Testedbool == true)
            {
                Tested = value;
            }
            TestedPCRbool = String.Equals($"TestedPCR", selectstring);
            if (TestedPCRbool == true)
            {
                TestedPCR = value;
            }
            TestedANTbool = String.Equals($"TestedANT", selectstring);
            if (TestedANTbool == true)
            {
                TestedANT = value;
            }
        }
    }
}
