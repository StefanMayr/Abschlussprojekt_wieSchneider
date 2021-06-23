using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abschlussprojekt_wieSchneider
{
    interface IDownload
    {
        //Interface mit zwei Methoden zum Downloaden
        //ReadFile wird zum Download der Daten verwendet
        //WriteFile ist nicht implementiert / keine Ahnung ob das überhaupt gefragt ist
        bool ReadFile(string path, string filename);
        bool WriteFile(string path, string filename);
    }
}
