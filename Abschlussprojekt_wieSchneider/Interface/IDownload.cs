﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abschlussprojekt_wieSchneider
{
    interface IDownload
    {
        bool ReadFile(string path, string filename);
        bool WriteFile(string path, string filename);
    }
}
