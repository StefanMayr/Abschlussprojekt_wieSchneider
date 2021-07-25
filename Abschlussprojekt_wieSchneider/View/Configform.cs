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
        List<string> IConnectConfig.Stringlistwithstates{ get => Statelist; set => Statelist = value; }
        
        private ConfigPresenter Listboxpresenter;
        private List<string> Statelist;
        private IConnectChartform Connectinterface;

        //Constructor
        public Configform(IConnectChartform view)
        {
            Connectinterface = view;
            InitializeComponent();
        }

        //Close Button
        private void Testbutton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Private function to load the states to the Table
        /// </summary>
        private void UpdateList()
        {
            listBox1.Items.Clear();

            for(int i = 1; i < Statelist.Count; i++)
            {
                listBox1.Items.Add(Statelist[i]);
            }
        }

        /// <summary>
        /// Import the data and loads the states
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Import_Click(object sender, EventArgs e)
        {
            Listboxpresenter = new ConfigPresenter(Connectinterface);
            Listboxpresenter.LoadText(this);
            UpdateList();
            

        }

        /// <summary>
        /// Saves data and sends the data to the chartform
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Present_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)
            {
                Listboxpresenter = new ConfigPresenter(true, true, Connectinterface);
                Listboxpresenter.NextstopChartpresenter(listBox1.SelectedItem.ToString(), Statelist[0]);
                this.Close();
            }
            else
            {
                MessageBox.Show("Es wurde kein Element ausgewählt.", "Achtung");
            }
        }

        /// <summary>
        /// Private function to show the choosen state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedItems != null)
            {
                SelectedSource.Text = listBox1.SelectedItem.ToString();
            }
        }
    }
}
