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
            /*
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
            */
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
            myConfigpresenter.RunConfig(this);

        }

        //Funktion von uns
        //Lädt die Daten der Liste dann ins Chart
        //MUss noch ausgelagert werden
        public void Loadchart()
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
            objChart.AxisY.Minimum = 0;
            objChart.AxisY.Maximum = 480;//24000
            // clear
            chart1.Series.Clear();

            Random random = new Random();

            string name = "Confirmed Cases";
            chart1.Series.Add(name);
            chart1.Series[name].Color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            chart1.Series[name].Legend = "Legend1";
            chart1.Series[name].ChartArea = "ChartArea1";
            chart1.Series[name].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            for (int i = 0; i < 16; i++)
            {
                //chart1.Series[t.State].Points.AddXY(i, Convert.ToInt32(t[$"Monat{i}"]));
                chart1.Series[name].Points.AddXY(i + 1, Listtopresent[i].ConfirmedCases);
            }

            string name2 = "Deaths";
            chart1.Series.Add(name2);
            chart1.Series[name2].Color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            chart1.Series[name2].Legend = "Legend1";
            chart1.Series[name2].ChartArea = "ChartArea1";
            chart1.Series[name2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            for (int i = 0; i < 16; i++)
            {
                //chart1.Series[t.State].Points.AddXY(i, Convert.ToInt32(t[$"Monat{i}"]));
                chart1.Series[name2].Points.AddXY(i + 1, Listtopresent[i].Deaths);
            }

            string name3 = "Recovered";
            chart1.Series.Add(name3);
            chart1.Series[name3].Color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            chart1.Series[name3].Legend = "Legend1";
            chart1.Series[name3].ChartArea = "ChartArea1";
            chart1.Series[name3].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            for (int i = 0; i < 16; i++)
            {
                //chart1.Series[t.State].Points.AddXY(i, Convert.ToInt32(t[$"Monat{i}"]));
                chart1.Series[name3].Points.AddXY(i + 1, Listtopresent[i].Recovered);
            }

            string name4 = "Hospitalization";
            chart1.Series.Add(name4);
            chart1.Series[name4].Color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            chart1.Series[name4].Legend = "Legend1";
            chart1.Series[name4].ChartArea = "ChartArea1";
            chart1.Series[name4].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            for (int i = 0; i < 16; i++)
            {
                //chart1.Series[t.State].Points.AddXY(i, Convert.ToInt32(t[$"Monat{i}"]));
                chart1.Series[name4].Points.AddXY(i + 1, Listtopresent[i].Hospitalizations);
            }

            string name5 = "Intensive Care";
            chart1.Series.Add(name5);
            chart1.Series[name5].Color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            chart1.Series[name5].Legend = "Legend1";
            chart1.Series[name5].ChartArea = "ChartArea1";
            chart1.Series[name5].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            for (int i = 0; i < 16; i++)
            {
                //chart1.Series[t.State].Points.AddXY(i, Convert.ToInt32(t[$"Monat{i}"]));
                chart1.Series[name5].Points.AddXY(i + 1, Listtopresent[i].IntenisveCare);
            }

            string name6 = "Tested";
            chart1.Series.Add(name6);
            chart1.Series[name6].Color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            chart1.Series[name6].Legend = "Legend1";
            chart1.Series[name6].ChartArea = "ChartArea1";
            chart1.Series[name6].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            for (int i = 0; i < 16; i++)
            {
                //chart1.Series[t.State].Points.AddXY(i, Convert.ToInt32(t[$"Monat{i}"]));
                chart1.Series[name6].Points.AddXY(i + 1, Listtopresent[i].Tested);
            }

            string name7 = "TestedPCR";
            chart1.Series.Add(name7);
            chart1.Series[name7].Color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            chart1.Series[name7].Legend = "Legend1";
            chart1.Series[name7].ChartArea = "ChartArea1";
            chart1.Series[name7].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            for (int i = 0; i < 16; i++)
            {
                //chart1.Series[t.State].Points.AddXY(i, Convert.ToInt32(t[$"Monat{i}"]));
                chart1.Series[name7].Points.AddXY(i + 1, Listtopresent[i].TestedPCR);
            }

            string name8 = "TestedANT";
            chart1.Series.Add(name8);
            chart1.Series[name8].Color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            chart1.Series[name8].Legend = "Legend1";
            chart1.Series[name8].ChartArea = "ChartArea1";
            chart1.Series[name8].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            for (int i = 0; i < 16; i++)
            {
                //chart1.Series[t.State].Points.AddXY(i, Convert.ToInt32(t[$"Monat{i}"]));
                chart1.Series[name8].Points.AddXY(i + 1, Listtopresent[i].TestedANT);
            }
        }

        //Test button 
        //Ruft die Funktion auf um die Daten in die Lsite zu laden
        private void button1_Click(object sender, EventArgs e)
        {
            Loadchart();
        }

        private void btn_Config_Click(object sender, EventArgs e)
        {
            Configform NeueForm = new Configform(this);
            ConfigPresenter myConfigpresenter = new ConfigPresenter(NeueForm);
            myConfigpresenter.RunConfig(this);
        }

        private void btn_progend_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
