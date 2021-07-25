using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abschlussprojekt_wieSchneider
{
    internal class ConfigPresenter
    {
        private IConnectConfig ConfigConnect;
        private IConnectChartform ConnectertoChartform;
        private Configform MynewConfig;
        private DataList Statelistconfig;
        private Chartpresenter MynewChartpresenter;

        //Default constructor
        public ConfigPresenter(IConnectChartform input)
        {
            ConnectertoChartform = input;
        }

        //Constructor
        public ConfigPresenter(bool j, bool k, IConnectChartform input)
        {
            ConnectertoChartform = input;
        }

        //Function to start the Configform
        public void RunConfig()
        {
            MynewConfig = new Configform(ConnectertoChartform);
            MynewConfig.ShowDialog();
        }

        //Function to connect the Configform with the Statelist
        public void ConnectConfigandStatelist()
        {
            ConfigConnect.Stringlistwithstates = Statelistconfig.StatelistinModel;
        }

        //Function to load the States
        public void LoadText(IConnectConfig Configview)
        {
            ConfigConnect = Configview;
            Statelistconfig = new DataList();
            Statelistconfig.Stateloader();
            ConnectConfigandStatelist();
        }

        //Function to connect the Configform with the Chartpresenter
        public void NextstopChartpresenter(string selectedtext, string path)
        {
            MynewChartpresenter = new Chartpresenter(ConnectertoChartform);
            MynewChartpresenter.LoadDatatoChart(selectedtext, path);
        }

    }
}
