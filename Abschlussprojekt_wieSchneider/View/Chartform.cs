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
    public partial class Chartform : Form, IConnectChartform
    {
        //Verbindung Interface
        List<DataList> IConnectChartform.Chartlist { get => Listtopresent; set => Listtopresent = value; }

        //INterface gibt Daten an dieses private Objekt um die von hier in das Chart zu laden
        private List<DataList> Listtopresent;
        ConfigPresenter myConfigpresenter;


        public Chartform()
        {
            InitializeComponent();
        }

        //Test button 
        //Ruft die Funktion auf um die Daten in die Lsite zu laden
        private void button1_Click(object sender, EventArgs e)
        {
            chart1 = Chartloader.Loaddata(chart1, Listtopresent);

            dataGridView1.Rows.Clear();
            Headline_lbl.Text = "Covid 19 Daten: " + Listtopresent[0].State;
            dataGridView1.ColumnCount = 10;
            this.dataGridView1.Rows.Add($"Woche", $"Bestätigte Fälle [100/Einw.]", $"Tode", $"Genesene [100/Einw.]", $"Hospitalisierungen", $"Intensiv Station", $"Getested [10000/Einw.]", $"Getested PCR [10000/Einw.]", $"Getested Antigen [10000/Einw.]");

            for (int i = 0; i < Listtopresent.Count; i++)
            {
                this.dataGridView1.Rows.Add($" Woche {i + 1}", $"{Listtopresent[i].ConfirmedCases}", $"{Listtopresent[i].Deaths}", $"{Listtopresent[i].Recovered}", $"{Listtopresent[i].Hospitalizations}", $"{Listtopresent[i].IntenisveCare}", $"{Listtopresent[i].Tested}", $"{Listtopresent[i].TestedPCR}", $"{Listtopresent[i].TestedANT}");
            }
        }

        private void btn_Config_Click(object sender, EventArgs e)
        {
            myConfigpresenter = new ConfigPresenter(this);
            myConfigpresenter.RunConfig();
        }

        private void btn_progend_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
