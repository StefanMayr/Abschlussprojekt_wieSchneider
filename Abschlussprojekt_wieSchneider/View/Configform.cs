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
    public partial class Configform : Form
    {
        public Configform()
        {
            InitializeComponent();
        }

        private void Testbutton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Filedownload newfile = new Filedownload();
            bool j = newfile.ReadFile("", "");
            if(j == true)
            {
                MessageBox.Show("Funkt");
            }
            else
            {
                MessageBox.Show("Funkt nicht");
            }
        }
    }
}
