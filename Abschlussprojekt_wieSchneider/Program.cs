using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abschlussprojekt_wieSchneider
{
    static class Program
    {
        /// <summary>
        /// Main method
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Chartpresenter, starts the programm
            Chartpresenter newchartpresenter = new Chartpresenter();
            newchartpresenter.Run();

        }
    }
}
