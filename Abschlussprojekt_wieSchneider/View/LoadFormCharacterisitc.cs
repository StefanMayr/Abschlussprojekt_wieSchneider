using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace Abschlussprojekt_wieSchneider
{
    class LoadFormCharacterisitc
    {
        /// <summary>
        /// Loads the Data tó the chart
        /// </summary>
        /// <param name="chart1"></param>
        /// <param name="Listtopresent"></param>
        /// <returns></returns>
        public static Chart Loaddata(Chart chart1, List<DataList> Listtopresent)
        {
            if(Listtopresent != null)
            {
                chart1.Series.Clear();

                var objChart = chart1.ChartAreas[0];
                objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;

                objChart.AxisX.Minimum = 1;
                objChart.AxisX.Maximum = Listtopresent.Count;

                objChart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
                objChart.AxisY.Minimum = 0;
                int width = 2;

                Random random = new Random();
                for (int k = 0; k < 8; k++)
                {
                    string name = GetName(k);
                    chart1.Series.Add(name);
                    chart1.Series[name].Color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                    chart1.Series[name].Legend = "Legend1";
                    chart1.Series[name].ChartArea = "ChartArea1";
                    chart1.Series[name].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    chart1.Series[name].BorderWidth = width;

                    chart1 = AddPoints(name, chart1, Listtopresent);
                }
                return chart1;
            }
            
            return chart1;
        }

        /// <summary>
        /// Private function to get the name from the different series
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private static string GetName(int value)
        {
            string erg = "";
            if (value == 0)
            {
                erg = "Confirmed Cases";
            }
            if (value == 1)
            {
                erg = "Deaths";
            }
            if (value == 2)
            {
                erg = "Recovered";
            }
            if (value == 3)
            {
                erg = "Hospitalization";
            }
            if (value == 4)
            {
                erg = "Intensive Care";
            }
            if (value == 5)
            {
                erg = "Tested";
            }
            if (value == 6)
            {
                erg = "TestedPCR";
            }
            if (value == 7)
            {
                erg = "TestedANT";
            }

            return erg;
        }

        /// <summary>
        /// Private function to add the points to the chart
        /// </summary>
        /// <param name="name"></param>
        /// <param name="chart1"></param>
        /// <param name="Listtopresent"></param>
        /// <returns></returns>
        private static Chart AddPoints(string name, Chart chart1, List<DataList> Listtopresent)
        {
            if(name == "Confirmed Cases")
            {
                for (int i = 0; i < 16; i++)
                {
                    chart1.Series[name].Points.AddXY(i + 1, Listtopresent[i].ConfirmedCases);
                }
            }
            if(name == "Deaths")
            {
                for (int i = 0; i < 16; i++)
                {
                    chart1.Series[name].Points.AddXY(i + 1, Listtopresent[i].Deaths);
                }
            }
            if(name == "Recovered")
            {
                for (int i = 0; i < 16; i++)
                {
                    chart1.Series[name].Points.AddXY(i + 1, Listtopresent[i].Recovered);
                }
            }
            if(name == "Hospitalizations")
            {
                for (int i = 0; i < 16; i++)
                {
                    chart1.Series[name].Points.AddXY(i + 1, Listtopresent[i].Hospitalizations);
                }
            }
            if(name == "IntenisveCare")
            {
                for (int i = 0; i < 16; i++)
                {
                    chart1.Series[name].Points.AddXY(i + 1, Listtopresent[i].IntenisveCare);
                }
            }
            if(name == "Tested")
            {
                for (int i = 0; i < 16; i++)
                {
                    chart1.Series[name].Points.AddXY(i + 1, Listtopresent[i].Tested);
                }
            }
            if(name == "TestedPCR")
            {
                for (int i = 0; i < 16; i++)
                {
                    chart1.Series[name].Points.AddXY(i + 1, Listtopresent[i].TestedPCR);
                }
            }
            if(name == "TestedANT")
            {
                for (int i = 0; i < 16; i++)
                {
                    chart1.Series[name].Points.AddXY(i + 1, Listtopresent[i].TestedANT);
                }
            }
            return chart1;
        }

        /// <summary>
        /// Fills the Datagridview with the data from the list
        /// </summary>
        /// <param name="dataGridView1"></param>
        /// <param name="Listtopresent"></param>
        /// <returns></returns>
        public static DataGridView CreateDataGrid(DataGridView dataGridView1, List<DataList> Listtopresent)
        {
            if(Listtopresent != null)
            {
                dataGridView1.Rows.Clear();
                dataGridView1.ColumnCount = 10;
                dataGridView1.Rows.Add($"Woche", $"Bestätigte Fälle [100/Einw.]", $"Tode", $"Genesene [100/Einw.]", $"Hospitalisierungen", $"Intensiv Station", $"Getested [10000/Einw.]", $"Getested PCR [10000/Einw.]", $"Getested Antigen [10000/Einw.]");

                for (int i = 0; i < Listtopresent.Count; i++)
                {
                    dataGridView1.Rows.Add($" Woche {i + 1}", $"{Listtopresent[i].ConfirmedCases}", $"{Listtopresent[i].Deaths}", $"{Listtopresent[i].Recovered}", $"{Listtopresent[i].Hospitalizations}", $"{Listtopresent[i].IntenisveCare}", $"{Listtopresent[i].Tested}", $"{Listtopresent[i].TestedPCR}", $"{Listtopresent[i].TestedANT}");
                }
                return dataGridView1;
            }
            return dataGridView1;
        }

        /// <summary>
        /// Creates the Headline of the Chartform
        /// </summary>
        /// <param name="Listtopresent"></param>
        /// <returns></returns>
        public static string CreateLabel(List<DataList> Listtopresent)
        {
            if (Listtopresent != null)
            {
                return "Covid 19 Daten: " + Listtopresent[0].State;
            }
            return "Covid 19 Daten: ";
        }
    }
}
