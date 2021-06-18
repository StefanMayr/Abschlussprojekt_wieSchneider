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
        //Einstieg vom Main hier in den Chartpresenter

        //Startet die ChartForm über den Presenter
        private Chartform newchartform;

        public Chartpresenter()
        {

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
