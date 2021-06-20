using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Abschlussprojekt_wieSchneider
{
    class Filedownload : IDownload
    {
        public Filedownload()
        {
            //default constructor
        }

        public bool ReadFile(string input2, string input)
        {
            List<BasisstructureData> downloaddata = new List<BasisstructureData>();
            input2 = @"C:\Users\Stefa\source\repos\Abschlussprojekt_wieSchneider\Abschlussprojekt_wieSchneider\Files";
            input = "timeline-faelle-bundeslaender.csv";
            BasisstructureData[] Rawdata = new BasisstructureData[default];
            string helper = "";
            string pathandfile = input2 + "\\" + input;
            string path = input2;
            bool directory = false;
            bool file = false;
            int conversion;

            try
            {
                //Testing file and directory
                directory = Directory.Exists(input2);
                file = File.Exists(pathandfile);
                if ((directory == false && file == false) || (directory == false && file == true) || (directory == true && file == false))
                {
                    throw new ArgumentNullException();
                }

                using (StreamReader newstream = new StreamReader(pathandfile))
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

            //Liste wegschicken (noch nicht erstellt)
            //Code
            for (int i = 0; i < Rawdata.Length; i++)
            {
                downloaddata.Add(Rawdata[i]);
            }

            return true;
        }

        public bool WriteFile(string input, string input2)
        {
            return false;
        }
    }
}
