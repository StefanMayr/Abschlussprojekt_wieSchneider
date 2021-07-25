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
        //Properties
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

        //Function to get the state as object
        public string GetBundesland()
        {
            return $"{State}";
        }

        //Function to to compare the string with the property
        public bool EqualTextandState(string selectstring)
        {
            bool test = false;
            return test = String.Equals($"{State}", selectstring);
        }

        //Function to get the property to calcualte the Arithmetic Mean
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
    }
}
