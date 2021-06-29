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
    internal partial class Configform : Form, IConnectConfig
    {
        //Für Bundeslandliste
        List<string> IConnectConfig.Bundeslandliste{ get => testinterface; set => testinterface = value; }
        //Für Bundeslandliste
        private ConfigPresenter Listboxpresenter;
        private List<string> testinterface;
        //INterface des Charts
        private IConnectChartform Testobgeht;

        //KOnstruktor
        public Configform(IConnectChartform view)
        {
            Testobgeht = view;
            InitializeComponent();
        }

        //Schließen button
        private void Testbutton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Priate Funktion die die Strings der Bundesländer in die Listbox lädt
        private void UpdateList()
        {
            listBox1.Items.Clear();

            for(int i = 0; i < testinterface.Count; i++)
            {
                listBox1.Items.Add(testinterface[i]);
            }
        }

        //Funktion lädt die Bundeländer
        private void btn_Import_Click(object sender, EventArgs e)
        {
            Listboxpresenter = new ConfigPresenter();
            Listboxpresenter.LoadText(this);
            UpdateList();
        }

        //Funktion schickt Befehl ins Model die Daten in des ausgewählten BUndeslandes in die Chart zu laden
        private void btn_Present_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)
            {
                //Zum Models und mit den Daten in die Chartform
                //hier übergeben
                Listboxpresenter = new ConfigPresenter(true, true, Testobgeht);

                //Funktion
                Listboxpresenter.NextstopChartpresenter(listBox1.SelectedItem.ToString());
                this.Close();
            }
            else
            {
                MessageBox.Show("Es wurde kein Element ausgewählt.", "Achtung");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedItems != null)
            {
                SelectedSource.Text = listBox1.SelectedItem.ToString();
            }
        }
    }
}
