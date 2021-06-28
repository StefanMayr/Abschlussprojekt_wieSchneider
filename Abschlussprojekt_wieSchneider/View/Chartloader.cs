using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;

namespace Abschlussprojekt_wieSchneider
{
    static class Chartloader
    {
        public static Chart Loaddata(Chart chart1, List<DataList> Listtopresent)
        {
            var objChart = chart1.ChartAreas[0];
            objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            // monate 1-12
            objChart.AxisX.Minimum = 1;
            objChart.AxisX.Maximum = 16;
            // tempe
            objChart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisY.Minimum = 0;
            /*
            if(Listtopresent[0].State == "Burgenland")
            {
                objChart.AxisY.Maximum = 400;
            }
            if (Listtopresent[0].State == "Kärnten")
            {
                objChart.AxisY.Maximum = 1000;
            }
            if (Listtopresent[0].State == "Vorarlberg")
            {
                objChart.AxisY.Maximum = 1000;
            }
            if (Listtopresent[0].State == "Tirol")
            {
                objChart.AxisY.Maximum = 1000;
            }
            if (Listtopresent[0].State == "Salzburg")
            {
                objChart.AxisY.Maximum = 600;
            }
            if (Listtopresent[0].State == "Oberösterreich")
            {
                objChart.AxisY.Maximum = 1200;
            }
            if (Listtopresent[0].State == "Niederösterreich")
            {
                objChart.AxisY.Maximum = 1900;
            }
            if (Listtopresent[0].State == "Österreich")
            {
                objChart.AxisY.Maximum = 1000;
            }
            */
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
        
            return chart1;
        }
    }
}
