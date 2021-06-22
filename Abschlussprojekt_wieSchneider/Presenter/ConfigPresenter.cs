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
        //Für Bundeslandliste
        private Configform mynewConfig;
        //Test verbinden Bundeslandliste mit Configview
        private DataList Bundeslandlist;

        //Interfaces
        private IConnectConfig ConfigConnect;
        private IConnectChartform Übergabe;

        //Für Umweg zum Chartpresenter für Interfaceübergabe
        private Chartpresenter Umweg;

        //
        public ConfigPresenter()
        {

        }

        public ConfigPresenter(Configform myConfigform)
        {
            mynewConfig = myConfigform;
        }

        public ConfigPresenter(bool j, bool k, IConnectChartform input)
        {
            Übergabe = input;
        }

        public void RunConfig(IConnectChartform view)
        {
            Übergabe = view;
            mynewConfig.ShowDialog();
        }

        public void ConnectConfigandStatelist()
        {
            //Testfilter.Textfeld = test.Textfeld;
            ConfigConnect.Bundeslandliste = Bundeslandlist.StatelistinModel;
        }

        public void LoadText(IConnectConfig Configview)
        {
            ConfigConnect = Configview;
            Bundeslandlist = new DataList();
            Bundeslandlist.Stateloader();
            //Connect Presenter and View
            ConnectConfigandStatelist();
        }

        public void NextstopChartpresenter(string selectedtext)
        {
            //hier liegt Problem
            //Übergabe ist null
            Umweg = new Chartpresenter(Übergabe);
            Umweg.LoadDatatoChart(selectedtext);
        }
    }
}
