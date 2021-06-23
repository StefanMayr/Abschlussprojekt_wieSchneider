using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abschlussprojekt_wieSchneider
{
    interface IConnectChartform
    {
        //Liste mit den Daten für das Chart
        //Durch das Interface wird die Verbindung in die Chartform erstellt
        List<DataList> Chartlist {get;set;}
    }
}
