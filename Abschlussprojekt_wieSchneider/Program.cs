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
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Standardkomponenten
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Programm erzeugt hier den Chartpresenter
            //Dieser dient als Einstiegspunkt damit die Form immer über den Presenter wieder geöffnet werdne kann
            Chartpresenter newchartpresenter = new Chartpresenter();
            newchartpresenter.Run();

        }
    }
}
