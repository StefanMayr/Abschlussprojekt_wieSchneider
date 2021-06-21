using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abschlussprojekt_wieSchneider
{
    public partial class Configform : Form, IConnectConfig
    {
        //Für Bundeslandliste
        List<string> IConnectConfig.Bundeslandliste{ get => testinterface; set => testinterface = value; }

        //Für Bundeslandliste
        private ConfigPresenter Listboxpresenter;
        private List<string> testinterface;

        //Für Graph
        private Chartpresenter Chartformpresenter;
        public Configform()
        {
            InitializeComponent();
        }

        private void Testbutton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateList()
        {
            listBox1.Items.Clear();

            for(int i = 0; i < testinterface.Count; i++)
            {
                listBox1.Items.Add(testinterface[i]);
            }
        }

        private void btn_Import_Click(object sender, EventArgs e)
        {
            Listboxpresenter = new ConfigPresenter();
            Listboxpresenter.LoadText(this);
            UpdateList();
        }

        private void btn_Present_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)
            {
                //Zum Models und mit den Daten in die Chartform
                Chartformpresenter = new Chartpresenter();
                //Funktion
                Chartformpresenter.LoadDatatoChart(listBox1.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Es wurde kein Element ausgewählt.", "Achtung");
            }
        }
    }
}
