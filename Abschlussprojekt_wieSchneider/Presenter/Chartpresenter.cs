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
        private Chartform Newchartform;
        private IConnectChartform Connectchartformandpresenter;

        
        DataList DatatoChart;

        //Default constructor
        public Chartpresenter()
        {
             
        }

        //Constructor with InterafACE  
        public Chartpresenter(IConnectChartform view)
        {
            Connectchartformandpresenter = view;
        }

        /// <summary>
        /// Function to load the data for the file and connect with th chart
        /// </summary>
        /// <param name="selectedState"></param>
        public void LoadDatatoChart(string selectedState, string path)
        {
            DatatoChart = new DataList();
            DatatoChart.DownloadDataforChartandConvert(selectedState , path);
            ConnectChartformandPresenter();
        }

        /// <summary>
        /// Function to ConnectChartform and the presenter
        /// </summary>
        public void ConnectChartformandPresenter()
        {
            Connectchartformandpresenter.Chartlist = DatatoChart.ConvertedDataforList;
        }

        /// <summary>
        /// Function to start the Chartform
        /// </summary>
        /// <param name="chartform1"> wird im Main übergeben </param>
        public void Run()
        {
            Newchartform = new Chartform();
            Application.Run(Newchartform);
        }
        
    }
}
