using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abschlussprojekt_wieSchneider
{
    internal class ConfigPresenter
    {
        //Für Bundeslandliste
        private Configform mynewConfig;

        //Objekt des Models
        private DataList Bundeslandlist;

        //Interfaces
        //Hier beide da jene die Schnitttelle der Chart über die ConfigForm ins Model gelangt
        //Namen müssen noch umbenannt werden
        private IConnectConfig ConfigConnect;
        private IConnectChartform Uergabe;

        //Für Umweg zum Chartpresenter für Interfaceübergabe
        private Chartpresenter Umweg;

        //Leerer Konstruktor
        public ConfigPresenter()
        {

        }

        //Aufruf um Configform zu erstellen und dann zu starten
        public ConfigPresenter(Configform myConfigform)
        {
            mynewConfig = myConfigform;
        }

        //Dritter überladener Konstruktor um Interface weiterzuschicken
        //Bool Werte haben keine Bedeutung, werden nur gebraucht damit genau dieser Konstruktor aufgerufen wird
        //Weil mit dem this (das bei Interfaces übergeben wird ruft er oft den falschen auf) => mit diesem geht es
        public ConfigPresenter(bool j, bool k, IConnectChartform input)
        {
            Uergabe = input;
        }

        //Funktion die die Form startet
        public void RunConfig()
        {
            mynewConfig.ShowDialog();
        }

        //Funktion die das Model mit der View verbindet
        public void ConnectConfigandStatelist()
        {
            ConfigConnect.Bundeslandliste = Bundeslandlist.StatelistinModel;
        }

        //Funktion lädt die BUndesländer
        public void LoadText(IConnectConfig Configview)
        {
            ConfigConnect = Configview;
            Bundeslandlist = new DataList();
            Bundeslandlist.Stateloader();
            //Connect Presenter and View
            ConnectConfigandStatelist();
        }

        //Funktion schickt selectedtext (Bundeland) ins Model welches die Liste mit den Daten an die Chartform schickt
        public void NextstopChartpresenter(string selectedtext)
        {
            //hier liegt Problem
            //Übergabe ist null
            Umweg = new Chartpresenter(Uergabe);
            Umweg.LoadDatatoChart(selectedtext);
        }
    }
}
