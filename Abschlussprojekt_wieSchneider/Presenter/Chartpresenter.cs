using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abschlussprojekt_wieSchneider
{
    class Chartpresenter
    {
        //Private Membervariablen 
        private Chartform newchartform;
        private IConnectChartform Connectchartformandpresenter;

        //Für Daten
        DataList DatatoChart;

        //Leerer Konstruktor (default constructor)
        public Chartpresenter()
        {
             
        }

        //Constructor mit Interface für Schnittstelle  
        public Chartpresenter(IConnectChartform view)
        {
            Connectchartformandpresenter = view;
        }

        
        public void LoadDatatoChart(string selectedState)
        {
            //Aufruf DatenListe (unser Filter)
            DatatoChart = new DataList();
            //Download the Data for the Chart
            DatatoChart.DownloadDataforChartandConvert(selectedState);

            //Connect Funktion damit die Daten des Models mit denen der Form verbunden verbunden
            ConnectChartformandPresenter();
        }

        //Verbindungsfunktion
        public void ConnectChartformandPresenter()
        {
            //Hier wird die Liste vom Model der Form übergeben
            Connectchartformandpresenter.Chartlist = DatatoChart.ConvertedDataforList;
        }

        /// <summary>
        /// Funktion um die Chartfomr zu starten
        /// </summary>
        /// <param name="chartform1"> wird im Main übergeben </param>
        public void Run(Chartform chartform1)
        {
            newchartform = chartform1;
            Application.Run(newchartform);
        }
    }
}
