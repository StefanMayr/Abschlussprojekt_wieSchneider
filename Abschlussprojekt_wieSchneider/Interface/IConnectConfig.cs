using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abschlussprojekt_wieSchneider
{
    interface IConnectConfig
    {
        //Liste mit den String Werten für das Auswahlfenster
        //Durch das Interface wird die Verbindung in die ConfigForm erstellt
        List<string> Bundeslandliste { get; set; }
    }
}
