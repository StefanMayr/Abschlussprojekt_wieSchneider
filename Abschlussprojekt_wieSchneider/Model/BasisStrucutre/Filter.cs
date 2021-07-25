using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abschlussprojekt_wieSchneider
{
    static class Filter
    {
        /// <summary>
        /// Filter function for the states
        /// </summary>
        /// <param name="Rawdownload"></param>
        /// <param name="selectedtext"></param>
        /// <returns></returns>
        public static List<DataList> Statefilter(List<BasisstructureData> Rawdownload, string selectedtext)
        {
            List<DataList> Conversionlist = new List<DataList>();
            for (int i = 0; i < Rawdownload.Count; i++)
            {

                if (Rawdownload[i].EqualTextandState(selectedtext) == true)
                {
                    int k = Conversionlist.Count;
                    Conversionlist.Add(new DataList());
                    Conversionlist[k].Date = Rawdownload[i].Date;
                    Conversionlist[k].ConfirmedCases = Rawdownload[i].ConfirmedCases;
                    Conversionlist[k].Deaths = Rawdownload[i].Deaths;
                    Conversionlist[k].Recovered = Rawdownload[i].Recovered;
                    Conversionlist[k].Hospitalizations = Rawdownload[i].Hospitalizations;
                    Conversionlist[k].IntenisveCare = Rawdownload[i].IntenisveCare;
                    Conversionlist[k].Tested = Rawdownload[i].Tested;
                    Conversionlist[k].TestedPCR = Rawdownload[i].TestedPCR;
                    Conversionlist[k].TestedANT = Rawdownload[i].TestedANT;
                }
            }
            return Conversionlist;
        }

        /// <summary>
        /// Function to calculate arithmetic mean of the weeks
        /// </summary>
        /// <param name="selectedtext"></param>
        /// <param name="Listtoprepare"></param>
        /// <returns></returns>
        public static List<DataList> Calcarithmeticfilter(string selectedtext, List<DataList> Listtoprepare)
        {
            List<DataList> Transferlist = new List<DataList>();
            int runvar = 0;
            int daysoftheweek = 7;
            for (int i = 0; i < 16; i++)
            {
                Transferlist.Add(new DataList());
                Transferlist[i].State = selectedtext;
                Transferlist[i].ConfirmedCases = Arithmeticmean(runvar, daysoftheweek, Listtoprepare, "ConfirmedCases");
                Transferlist[i].Deaths = Arithmeticmean(runvar, daysoftheweek, Listtoprepare, "Deaths");
                Transferlist[i].Recovered = Arithmeticmean(runvar, daysoftheweek, Listtoprepare, "Recovered");
                Transferlist[i].Hospitalizations = Arithmeticmean(runvar, daysoftheweek, Listtoprepare, "Hospitalization");
                Transferlist[i].IntenisveCare = Arithmeticmean(runvar, daysoftheweek, Listtoprepare, "IntensiveCare");
                Transferlist[i].Tested = Arithmeticmean(runvar, daysoftheweek, Listtoprepare, "Tested");
                Transferlist[i].TestedPCR = Arithmeticmean(runvar, daysoftheweek, Listtoprepare, "TestedPCR");
                Transferlist[i].TestedANT = Arithmeticmean(runvar, daysoftheweek, Listtoprepare, "TestedANT");
                if ((Listtoprepare.Count - runvar) >= 7)
                {
                    runvar = runvar + 7;
                }
                if ((Listtoprepare.Count - runvar) < 7)
                {
                    runvar = (Listtoprepare.Count - runvar);
                    daysoftheweek = (Listtoprepare.Count - runvar);
                }
            }
            return Transferlist;
        }

        /// <summary>
        /// Private function, help to calculate the arithmeitc mean
        /// </summary>
        /// <param name="runvar"></param>
        /// <param name="daysofweek"></param>
        /// <param name="MyListtomaketheAM"></param>
        /// <param name="Property"></param>
        /// <returns></returns>
        private static double Arithmeticmean(int runvar, int daysofweek, List<DataList> MyListtomaketheAM, string Property)
        {
            double sum = 0;
            for (int g = 0; g < daysofweek; g++)
            {
                sum = sum + (MyListtomaketheAM[runvar + g].GetPropertyforArithmetic(Property));
            }
            sum = sum / daysofweek;
            sum = Math.Round(sum, 2);
            return sum;
        }

        /// <summary>
        /// Function to scale the axis
        /// </summary>
        /// <param name="Listtoprepare"></param>
        /// <returns></returns>
        public static List<DataList> ScaleAxis(List<DataList> Listtoprepare)
        {
            if (Listtoprepare[0].State == "Burgenland")
            {
                for (int i = 0; i < Listtoprepare.Count; i++)
                {
                    Listtoprepare[i].ConfirmedCases = Listtoprepare[i].ConfirmedCases / 100;
                    Listtoprepare[i].Recovered = Listtoprepare[i].Recovered / 100;
                    Listtoprepare[i].Tested = Listtoprepare[i].Tested / 10000;
                    Listtoprepare[i].TestedPCR = Listtoprepare[i].TestedPCR / 10000;
                    Listtoprepare[i].TestedANT = Listtoprepare[i].TestedANT / 10000;
                }
            }
            if (Listtoprepare[0].State == "Kärnten")
            {
                for (int i = 0; i < Listtoprepare.Count; i++)
                {
                    Listtoprepare[i].ConfirmedCases = Listtoprepare[i].ConfirmedCases / 100;
                    Listtoprepare[i].Recovered = Listtoprepare[i].Recovered / 100;
                    Listtoprepare[i].Tested = Listtoprepare[i].Tested / 10000;
                    Listtoprepare[i].TestedPCR = Listtoprepare[i].TestedPCR / 10000;
                    Listtoprepare[i].TestedANT = Listtoprepare[i].TestedANT / 10000;
                }
            }
            if (Listtoprepare[0].State == "Vorarlberg")
            {
                for (int i = 0; i < Listtoprepare.Count; i++)
                {
                    Listtoprepare[i].ConfirmedCases = Listtoprepare[i].ConfirmedCases / 100;
                    Listtoprepare[i].Recovered = Listtoprepare[i].Recovered / 100;
                    Listtoprepare[i].Tested = Listtoprepare[i].Tested / 10000;
                    Listtoprepare[i].TestedPCR = Listtoprepare[i].TestedPCR / 10000;
                    Listtoprepare[i].TestedANT = Listtoprepare[i].TestedANT / 10000;
                }
            }
            if (Listtoprepare[0].State == "Tirol")
            {
                for (int i = 0; i < Listtoprepare.Count; i++)
                {
                    Listtoprepare[i].ConfirmedCases = Listtoprepare[i].ConfirmedCases / 100;
                    Listtoprepare[i].Recovered = Listtoprepare[i].Recovered / 100;
                    Listtoprepare[i].Tested = Listtoprepare[i].Tested / 10000;
                    Listtoprepare[i].TestedPCR = Listtoprepare[i].TestedPCR / 10000;
                    Listtoprepare[i].TestedANT = Listtoprepare[i].TestedANT / 10000;
                }
            }
            if (Listtoprepare[0].State == "Salzburg")
            {
                for (int i = 0; i < Listtoprepare.Count; i++)
                {
                    Listtoprepare[i].ConfirmedCases = Listtoprepare[i].ConfirmedCases / 100;
                    Listtoprepare[i].Recovered = Listtoprepare[i].Recovered / 100;
                    Listtoprepare[i].Tested = Listtoprepare[i].Tested / 10000;
                    Listtoprepare[i].TestedPCR = Listtoprepare[i].TestedPCR / 10000;
                    Listtoprepare[i].TestedANT = Listtoprepare[i].TestedANT / 10000;
                }
            }
            if (Listtoprepare[0].State == "Oberösterreich")
            {
                for (int i = 0; i < Listtoprepare.Count; i++)
                {
                    Listtoprepare[i].ConfirmedCases = Listtoprepare[i].ConfirmedCases / 100;
                    Listtoprepare[i].Recovered = Listtoprepare[i].Recovered / 100;
                    Listtoprepare[i].Tested = Listtoprepare[i].Tested / 10000;
                    Listtoprepare[i].TestedPCR = Listtoprepare[i].TestedPCR / 10000;
                    Listtoprepare[i].TestedANT = Listtoprepare[i].TestedANT / 10000;
                }
            }
            if (Listtoprepare[0].State == "Niederösterreich")
            {
                for (int i = 0; i < Listtoprepare.Count; i++)
                {
                    Listtoprepare[i].ConfirmedCases = Listtoprepare[i].ConfirmedCases / 100;
                    Listtoprepare[i].Recovered = Listtoprepare[i].Recovered / 100;
                    Listtoprepare[i].Tested = Listtoprepare[i].Tested / 10000;
                    Listtoprepare[i].TestedPCR = Listtoprepare[i].TestedPCR / 10000;
                    Listtoprepare[i].TestedANT = Listtoprepare[i].TestedANT / 10000;
                }
            }
            if (Listtoprepare[0].State == "Wien")
            {
                for (int i = 0; i < Listtoprepare.Count; i++)
                {
                    Listtoprepare[i].ConfirmedCases = Listtoprepare[i].ConfirmedCases / 100;
                    Listtoprepare[i].Recovered = Listtoprepare[i].Recovered / 100;
                    Listtoprepare[i].Tested = Listtoprepare[i].Tested / 10000;
                    Listtoprepare[i].TestedPCR = Listtoprepare[i].TestedPCR / 10000;
                    Listtoprepare[i].TestedANT = Listtoprepare[i].TestedANT / 10000;
                }
            }
            if (Listtoprepare[0].State == "Steiermark")
            {
                for (int i = 0; i < Listtoprepare.Count; i++)
                {
                    Listtoprepare[i].ConfirmedCases = Listtoprepare[i].ConfirmedCases / 100;
                    Listtoprepare[i].Recovered = Listtoprepare[i].Recovered / 100;
                    Listtoprepare[i].Tested = Listtoprepare[i].Tested / 10000;
                    Listtoprepare[i].TestedPCR = Listtoprepare[i].TestedPCR / 10000;
                    Listtoprepare[i].TestedANT = Listtoprepare[i].TestedANT / 10000;
                }
            }
            if (Listtoprepare[0].State == "Österreich")
            {
                for (int i = 0; i < Listtoprepare.Count; i++)
                {
                    Listtoprepare[i].ConfirmedCases = Listtoprepare[i].ConfirmedCases / 100;
                    Listtoprepare[i].Recovered = Listtoprepare[i].Recovered / 100;
                    Listtoprepare[i].Tested = Listtoprepare[i].Tested / 10000;
                    Listtoprepare[i].TestedPCR = Listtoprepare[i].TestedPCR / 10000;
                    Listtoprepare[i].TestedANT = Listtoprepare[i].TestedANT / 10000;
                }
            }
            return Listtoprepare;
        }
    }
}
