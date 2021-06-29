using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;


namespace Abschlussprojekt_wieSchneider
{
    class ChartMaker
    {
        private Chartform chart1;
        private ChartMaker maker;
        public ChartMaker(Chartform chart1)
        {
            this.chart1 = chart1;
        }
        public void  MakeChart()
        {
            BasisstructureData data = new BasisstructureData();
            List <string> list=new List<string>();
            List<double> listdata=new List<double>();
            list.Add("Confirmed Cases");
            list.Add("Deaths");
            list.Add("Recovered");
            list.Add("Hospitalization");
            list.Add("Intensive Care");
            list.Add("Tested");
            list.Add("TestedPCR");
            list.Add("TestedANT");
            listdata.Add(data.ConfirmedCases);
            listdata.Add(data.Deaths);
            listdata.Add(data.Recovered);
            listdata.Add(data.Hospitalizations);
            listdata.Add(data.IntenisveCare);
            listdata.Add(data.Tested);
            listdata.Add(data.TestedPCR);
            listdata.Add(data.TestedANT);
            string name;
            double case1;
            for (int i = 0; i < list.Count; i++)
			{
                name=list[i];
                case1=listdata[i];
                maker.FillChart(name,case1);
			}
        }

        private void CreateChart()
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
            objChart.AxisY.Maximum = 24000;
            // clear
            chart1.Series.Clear();
           
        }
        private void FillChart(string name,double case1)
        {  
                Random random = new Random();
                chart1.Series.Add(name);
                chart1.Series[name].Color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                chart1.Series[name].Legend = "Legend1";
                chart1.Series[name].ChartArea = "ChartArea1";
                chart1.Series[name].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                for (int i = 0; i < 16; i++)
                {
                    //chart1.Series[t.State].Points.AddXY(i, Convert.ToInt32(t[$"Monat{i}"]));
                    chart1.Series[name].Points.AddXY(i, Listtopresent[i].case1);
                }

        }
    }
}
