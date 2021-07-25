using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Abschlussprojekt_wieSchneider
{
    class Filedownload : IDownload
    {
        public List<BasisstructureData> Rawdownload { get; set; }
        public BasisstructureData[] Teststrinback;
        public string path{ get; private set; }
        

        public Filedownload()
        {
            //default constructor
        }

        //Readfile zum einfachen Downloaden der rohen Daten
        public bool ReadFile(string input2)
        {
            List<BasisstructureData> downloaddata = new List<BasisstructureData>();
            BasisstructureData[] Rawdata = new BasisstructureData[default];
            string helper = "";
            string path = input2;
            bool file = false;
            int conversion;

            try
            {
                file = File.Exists(input2);
                if (file == false)
                {
                    throw new ArgumentNullException();
                }

                using (StreamReader newstream = new StreamReader(path))
                {
                    int i = 0;
                    while ((helper = newstream.ReadLine()) != null)
                    {
                        Array.Resize(ref Rawdata, Rawdata.Length + 1);
                        string[] splitLine = helper.Split(';');
                        Rawdata[i] = new BasisstructureData();
                        Rawdata[i].Date = splitLine[0];
                        Rawdata[i].State = splitLine[2];
                        if (int.TryParse(splitLine[3], out conversion) == true)
                        {
                            Rawdata[i].ConfirmedCases = Int32.Parse(splitLine[3]);
                        }
                        if (int.TryParse(splitLine[4], out conversion) == true)
                        {
                            Rawdata[i].Deaths = Int32.Parse(splitLine[4]);
                        }
                        if (int.TryParse(splitLine[5], out conversion) == true)
                        {
                            Rawdata[i].Recovered = Int32.Parse(splitLine[5]);
                        }
                        if (int.TryParse(splitLine[6], out conversion) == true)
                        {
                            Rawdata[i].Hospitalizations = Int32.Parse(splitLine[6]);
                        }
                        if (int.TryParse(splitLine[7], out conversion) == true)
                        {
                            Rawdata[i].IntenisveCare = Int32.Parse(splitLine[7]);
                        }
                        if (int.TryParse(splitLine[8], out conversion) == true)
                        {
                            Rawdata[i].Tested = Int32.Parse(splitLine[8]);
                        }
                        if (int.TryParse(splitLine[9], out conversion) == true)
                        {
                            Rawdata[i].TestedPCR = Int32.Parse(splitLine[9]);
                        }
                        if (int.TryParse(splitLine[10], out conversion) == true)
                        {
                            Rawdata[i].TestedANT = Int32.Parse(splitLine[10]);
                        }

                        i++;
                    }
                }
            }
            catch
            {
                return false;
            }

            for (int i = 0; i < Rawdata.Length; i++)
            {
                downloaddata.Add(Rawdata[i]);
            }

            //Zuweisung zu den Properties
            Teststrinback = Rawdata;
            Rawdownload = downloaddata;

            return true;
        }

        public bool ReadFilefromExplorer()
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                }

                List<BasisstructureData> downloaddata = new List<BasisstructureData>();
                BasisstructureData[] Rawdata = new BasisstructureData[default];
                string helper = "";
                int conversion;

                string dateityp = Path.GetExtension(filePath);

                if(dateityp == ".csv")
                {
                    try
                    {
                        using (StreamReader newstream = new StreamReader(filePath))
                        {
                            int i = 0;
                            while ((helper = newstream.ReadLine()) != null)
                            {
                                Array.Resize(ref Rawdata, Rawdata.Length + 1);
                                string[] splitLine = helper.Split(';');
                                Rawdata[i] = new BasisstructureData();
                                Rawdata[i].Date = splitLine[0];
                                Rawdata[i].State = splitLine[2];
                                if (int.TryParse(splitLine[3], out conversion) == true)
                                {
                                    Rawdata[i].ConfirmedCases = Int32.Parse(splitLine[3]);
                                }
                                if (int.TryParse(splitLine[4], out conversion) == true)
                                {
                                    Rawdata[i].Deaths = Int32.Parse(splitLine[4]);
                                }
                                if (int.TryParse(splitLine[5], out conversion) == true)
                                {
                                    Rawdata[i].Recovered = Int32.Parse(splitLine[5]);
                                }
                                if (int.TryParse(splitLine[6], out conversion) == true)
                                {
                                    Rawdata[i].Hospitalizations = Int32.Parse(splitLine[6]);
                                }
                                if (int.TryParse(splitLine[7], out conversion) == true)
                                {
                                    Rawdata[i].IntenisveCare = Int32.Parse(splitLine[7]);
                                }
                                if (int.TryParse(splitLine[8], out conversion) == true)
                                {
                                    Rawdata[i].Tested = Int32.Parse(splitLine[8]);
                                }
                                if (int.TryParse(splitLine[9], out conversion) == true)
                                {
                                    Rawdata[i].TestedPCR = Int32.Parse(splitLine[9]);
                                }
                                if (int.TryParse(splitLine[10], out conversion) == true)
                                {
                                    Rawdata[i].TestedANT = Int32.Parse(splitLine[10]);
                                }

                                i++;
                            }
                        }
                    }
                    catch
                    {
                        return false;
                    }
                    for (int i = 0; i < Rawdata.Length; i++)
                    {
                        downloaddata.Add(Rawdata[i]);
                    }
                    Teststrinback = Rawdata;
                    Rawdownload = downloaddata;
                    path = filePath;

                    return true;
                }
            }
            return false;
        }
    }
}
