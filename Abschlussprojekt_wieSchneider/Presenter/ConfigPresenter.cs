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
        //Dieser wird das Configfenster bedienen
        //Idee: Dieser kommuniziert mit den Models und öffnet das ConfigFenster

        private Configform mynewConfig;
        private IConnectConfig test;
        private Filter Testfilter = new Filter();

        public ConfigPresenter(Configform myConfigform)
        {
            mynewConfig = myConfigform;
        }

        public ConfigPresenter(Configform mysecondConfigform, IConnectConfig input)
        {
            mynewConfig = mysecondConfigform;
            test = input;
        }

        public void RunConfig()
        {
            mynewConfig.ShowDialog();
        }

        public void ConnectConfigandChart()
        {
            Testfilter.Textfeld = test.Textfeld;
        }

        public void Returnthatshit()
        {
            ConnectConfigandChart();
            test.ReturnTextfeld = Testfilter.ReturnTestvalue();
        }
    }
}
