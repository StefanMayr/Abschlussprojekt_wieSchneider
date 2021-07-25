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

        //Default constructor
        public DataList()
        {

        }

        /// <summary>
        /// Function to load the States
        /// </summary>
        public void Stateloader()
        {
            Filedownloader = new Filedownload();
            List<string> listtostring = new List<string>();

            //bool j = Filedownloader.ReadFile("", "");
            bool j = Filedownloader.ReadFilefromExplorer();

            listtostring.Add(Filedownloader.path);
            if (j == true)
            {
                for (int i = 1; i <= 10; i++)
                {
                    listtostring.Add(Filedownloader.Teststrinback[i].GetBundesland());
                }
            }
            
            StatelistinModel = listtostring;
        }

        /// <summary>
        /// Function to load the data and to convert the data for the chart
        /// </summary>
        /// <param name="selectedtext"></param>
        public void DownloadDataforChartandConvert(string selectedtext, string path)
        {
            Filedownloader = new Filedownload();
            bool j = Filedownloader.ReadFile(path);
            List<DataList> ConvertList = new List<DataList>();
            ConvertedDataforList = new List<DataList>();

            if (j == true)
            {
                ConvertList = Filter.Statefilter(Filedownloader.Rawdownload, selectedtext);
                ConvertedDataforList = Filter.Calcarithmeticfilter(selectedtext, ConvertList);
                ConvertedDataforList = Filter.ScaleAxis(ConvertedDataforList);
            }
        }
    }
}
