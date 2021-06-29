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
        
        public Chartform()
        {
            InitializeComponent();
        }

        //Funktion noch vom Test / Daten manuell laden,Teil von Schneider nicht von uns => kann dann zuletzt gelöscht werden 
        private void btn_conf_Click(object sender, EventArgs e)
        {
            //Kopf 

            //Hier Text zum File
            var objChart = chart1.ChartAreas[0];
            objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            // monate 1-12
            objChart.AxisX.Minimum = 1;
            objChart.AxisX.Maximum = 16;
            // tempe
            objChart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisY.Minimum = -50;
            objChart.AxisY.Maximum = 50;
            // clear
            chart1.Series.Clear();


            //Befüllen hier

            // random color
            Random random = new Random();

            // loop row
            //Ladet die Daten (zumjetzigen Zeitpunkt jene die eingegeben wurden) in das Chart
            foreach (BasisstructureData t in basisstructureDataBindingSource.DataSource as List<BasisstructureData>)
            {
                chart1.Series.Add(t.Source);
                chart1.Series[t.Source].Color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                chart1.Series[t.Source].Legend = "Legend1";
                chart1.Series[t.Source].ChartArea = "ChartArea1";
                chart1.Series[t.Source].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                for (int i = 1; i <= 12; i++)
                {
                    chart1.Series[t.Source].Points.AddXY(i, Convert.ToInt32(t[$"Monat{i}"]));
                }
            }
        }

        //War auch schon da, ist glaube ich die Verbindung des DataGrids zum Model
        private void Form1_Load(object sender, EventArgs e)
        {
            //basisstructureDataBindingSource.DataSource = new List<BasisstructureData>();
        }

        //Nur Tesfunktion um Configfenster zu öffnen
        private void Testbutton_Click(object sender, EventArgs e)
        {
            //HIer!!!!!
            Configform NeueForm = new Configform(this);
            ConfigPresenter myConfigpresenter = new ConfigPresenter(NeueForm);
            myConfigpresenter.RunConfig();

        }

        //Test button 
        //Ruft die Funktion auf um die Daten in die Lsite zu laden
        private void button1_Click(object sender, EventArgs e)
        {
            chart1 = Chartloader.Loaddata(chart1, Listtopresent);
        }

        private void btn_Config_Click(object sender, EventArgs e)
        {
            Configform NeueForm = new Configform(this);
            ConfigPresenter myConfigpresenter = new ConfigPresenter(NeueForm);
            myConfigpresenter.RunConfig();
        }

        private void btn_progend_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
