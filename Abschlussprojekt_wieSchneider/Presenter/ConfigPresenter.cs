using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abschlussprojekt_wieSchneider
{
    class ConfigPresenter
    {
        //Für Bundeslandliste
        private Configform mynewConfig;
        private IConnectConfig ConfigConnect;
        //Test verbinden Bundeslandliste mit Configview
        private DataList Bundeslandlist;

        //

        public ConfigPresenter()
        {

        }

        public ConfigPresenter(Configform myConfigform)
        {
            mynewConfig = myConfigform;
        }

        public ConfigPresenter(Configform mysecondConfigform, IConnectConfig input)
        {
            mynewConfig = mysecondConfigform;
            ConfigConnect = input;
        }

        public void RunConfig()
        {
            mynewConfig.ShowDialog();
        }

        public void ConnectConfigandStalist()
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
            ConnectConfigandStalist();

        }
    }
}
