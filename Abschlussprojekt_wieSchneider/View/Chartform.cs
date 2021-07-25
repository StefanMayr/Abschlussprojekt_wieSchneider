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
        //Property Interface
        List<DataList> IConnectChartform.Chartlist { get => Listtopresent; set => Listtopresent = value; }

        private List<DataList> Listtopresent;
        ConfigPresenter MyConfigpresenter;


        public Chartform()
        {
            InitializeComponent();
        }

        //Opens the Config Form
        private void btn_Config_Click(object sender, EventArgs e)
        {
            MyConfigpresenter = new ConfigPresenter(this);
            MyConfigpresenter.RunConfig();
        }

        //Close Button
        private void btn_progend_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Loads the chart and the DataGridView
        private void btn_update_Click(object sender, EventArgs e)
        {
            chart1 = LoadFormCharacterisitc.Loaddata(chart1, Listtopresent);
            this.dataGridView1 = LoadFormCharacterisitc.CreateDataGrid(dataGridView1, Listtopresent);
            Headline_lbl.Text = LoadFormCharacterisitc.CreateLabel(Listtopresent);
        }
    }
}
