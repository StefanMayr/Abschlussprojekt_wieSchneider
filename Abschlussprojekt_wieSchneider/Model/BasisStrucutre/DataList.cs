using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abschlussprojekt_wieSchneider
{
    class DataList : BasisstructureData
    {
        //private List<DataList> Listtopresent;
        public List<string> tester { get; set; }

        public DataList()
        {

        }

        public void Testfunktion()
        {
            Filedownload newdownloader = new Filedownload();
            List<string> listtostring = new List<string>();
            bool j = newdownloader.ReadFile("", "");

            for(int i = 1; i <= 10; i++)
            {
                listtostring.Add(newdownloader.Teststrinback[i].GetBundesland());
            }
            
             tester = listtostring;
        }
    }
}
