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
        public ConfigPresenter(Configform myConfigform)
        {
            mynewConfig = myConfigform;
        }

        public void RunConfig()
        {
            mynewConfig.ShowDialog();
        }
    }
}
