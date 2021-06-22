using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abschlussprojekt_wieSchneider
{
    class DataList : BasisstructureData
    {
        public List<string> StatelistinModel { get; private set; }

        public List<DataList> ConvertedDataforList { get; private set; }
        private Filedownload Filedownloader;

        public DataList()
        {

        }

        public void Stateloader()
        {
            Filedownloader = new Filedownload();
            List<string> listtostring = new List<string>();
            bool j = Filedownloader.ReadFile("", "");
            
            if(j == true)
            {
                for (int i = 1; i <= 10; i++)
                {
                    listtostring.Add(Filedownloader.Teststrinback[i].GetBundesland());
                }
            }
            
             StatelistinModel = listtostring;
        }

        public void DownloadDataforChartandConvert(string selectedtext)
        {
            Filedownloader = new Filedownload();
            bool j = Filedownloader.ReadFile("", "");
            List<DataList> ConvertList = new List<DataList>();
            ConvertedDataforList = new List<DataList>();

            if (j == true)
            {
                for(int i = 0; i < Filedownloader.Rawdownload.Count; i++)
                {
                    if(Filedownloader.Rawdownload[i].EqualTextandState(selectedtext) == true)
                    {
                        
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


                //Auslagern!!
                for(int l = 0; l < 15; l++)
                {
                    int Laufvariable = 0;
                    ConvertedDataforList.Add(new DataList());

                    ConvertedDataforList[l].State = selectedtext;
                    double sum = 0;
                    for (int g = 0; g < 10; g++)
                    {
                        sum = sum + (ConvertList[Laufvariable + g].ConfirmedCases);
                    }
                    sum = sum / 10;
                    ConvertedDataforList[l].ConfirmedCases = sum;

                    sum = 0;
                    for (int g = 0; g < 10; g++)
                    {
                        sum = sum + (ConvertList[Laufvariable + g].Deaths);
                    }
                    sum = sum / 10;
                    ConvertedDataforList[l].Deaths = sum;

                    sum = 0;
                    for (int g = 0; g < 10; g++)
                    {
                        sum = sum + (ConvertList[Laufvariable + g].Recovered);
                    }
                    sum = sum / 10;
                    ConvertedDataforList[l].Recovered = sum;

                    sum = 0;
                    for (int g = 0; g < 10; g++)
                    {
                        sum = sum + (ConvertList[Laufvariable + g].Hospitalizations);
                    }
                    sum = sum / 10;
                    ConvertedDataforList[l].Hospitalizations = sum;

                    sum = 0;
                    for (int g = 0; g < 10; g++)
                    {
                        sum = sum + (ConvertList[Laufvariable + g].IntenisveCare);
                    }
                    sum = sum / 10;
                    ConvertedDataforList[l].IntenisveCare = sum;

                    sum = 0;
                    for (int g = 0; g < 10; g++)
                    {
                        sum = sum + (ConvertList[Laufvariable + g].Tested);
                    }
                    sum = sum / 10;
                    ConvertedDataforList[l].Tested = sum;

                    sum = 0;
                    for (int g = 0; g < 10; g++)
                    {
                        sum = sum + (ConvertList[Laufvariable + g].TestedPCR);
                    }
                    sum = sum / 10;
                    ConvertedDataforList[l].TestedPCR = sum;

                    sum = 0;
                    for (int g = 0; g < 10; g++)
                    {
                        sum = sum + (ConvertList[Laufvariable + g].TestedANT);
                    }
                    sum = sum / 10;
                    ConvertedDataforList[l].TestedANT = sum;
                    Laufvariable = Laufvariable + 10;
                }

                //Auslagern 
                //Für die letzten zwei Tage
                for (int l = 15; l < 16; l++)
                {
                    int Laufvariable = 105;
                    ConvertedDataforList.Add(new DataList());

                    ConvertedDataforList[l].State = selectedtext;
                    double sum = 0;
                    for (int g = 0; g < 2; g++)
                    {
                        sum = sum + (ConvertList[Laufvariable + g].ConfirmedCases);
                    }
                    sum = sum / 2;
                    ConvertedDataforList[l].ConfirmedCases = sum;

                    sum = 0;
                    for (int g = 0; g < 2; g++)
                    {
                        sum = sum + (ConvertList[Laufvariable + g].Deaths);
                    }
                    sum = sum / 2;
                    ConvertedDataforList[l].Deaths = sum;

                    sum = 0;
                    for (int g = 0; g < 2; g++)
                    {
                        sum = sum + (ConvertList[Laufvariable + g].Recovered);
                    }
                    sum = sum / 2;
                    ConvertedDataforList[l].Recovered = sum;

                    sum = 0;
                    for (int g = 0; g < 2; g++)
                    {
                        sum = sum + (ConvertList[Laufvariable + g].Hospitalizations);
                    }
                    sum = sum / 2;
                    ConvertedDataforList[l].Hospitalizations = sum;

                    sum = 0;
                    for (int g = 0; g < 2; g++)
                    {
                        sum = sum + (ConvertList[Laufvariable + g].IntenisveCare);
                    }
                    sum = sum / 2;
                    ConvertedDataforList[l].IntenisveCare = sum;

                    sum = 0;
                    for (int g = 0; g < 2; g++)
                    {
                        sum = sum + (ConvertList[Laufvariable + g].Tested);
                    }
                    sum = sum / 2;
                    ConvertedDataforList[l].Tested = sum;

                    sum = 0;
                    for (int g = 0; g < 2; g++)
                    {
                        sum = sum + (ConvertList[Laufvariable + g].TestedPCR);
                    }
                    sum = sum / 2;
                    ConvertedDataforList[l].TestedPCR = sum;

                    sum = 0;
                    for (int g = 0; g < 2; g++)
                    {
                        sum = sum + (ConvertList[Laufvariable + g].TestedANT);
                    }
                    sum = sum / 2;
                    ConvertedDataforList[l].TestedANT = sum;
                    Laufvariable = Laufvariable + 1;
                }

            }

        }
    }
}
