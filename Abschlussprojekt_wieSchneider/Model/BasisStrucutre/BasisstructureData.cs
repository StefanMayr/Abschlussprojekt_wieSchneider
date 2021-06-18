using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Abschlussprojekt_wieSchneider
{
    class BasisstructureData
    {
        public string Source { get; set; }


        //nur Testproperties
        public double Monat1 { get; set; }
        public double Monat2 { get; set; }
        public double Monat3 { get; set; }

        public double Monat4 { get; set; }

        public double Monat5 { get; set; }
        public double Monat6 { get; set; }
        public double Monat7 { get; set; }
        public double Monat8 { get; set; }
        public double Monat9 { get; set; }
        public double Monat10 { get; set; }
        public double Monat11 { get; set; }
        public double Monat12 { get; set; }


        //richitge Properties / nur die Tage 
        public int Tag1 { get; set; }
        public int Tag2 { get; set; }
        public int Tag3 { get; set; }
        public int Tag4 { get; set; }
        public int Tag5 { get; set; }
        public int Tag6 { get; set; }
        public int Tag7 { get; set; }
        public int Tag8 { get; set; }
        public int Tag9 { get; set; }
        public int Tag10 { get; set; }
        public int Tag11 { get; set; }
        public int Tag12 { get; set; }
        public int Tag13 { get; set; }
        public int Tag14 { get; set; }
        public int Tag15 { get; set; }
        public int Tag16 { get; set; }
        public int Tag17 { get; set; }
        public int Tag18 { get; set; }
        public int Tag19 { get; set; }
        public int Tag20 { get; set; }
        public int Tag21 { get; set; }
        public int Tag22 { get; set; }
        public int Tag23 { get; set; }
        public int Tag24 { get; set; }
        public int Tag25 { get; set; }
        public int Tag26 { get; set; }
        public int Tag27 { get; set; }
        public int Tag28 { get; set; }
        public int Tag29 { get; set; }
        public int Tag30 { get; set; }
        public int Tag31 { get; set; }
        public int Tag32 { get; set; }
        public int Tag33 { get; set; }
        public int Tag34 { get; set; }
        public int Tag35 { get; set; }
        public int Tag36 { get; set; }
        public int Tag37 { get; set; }
        public int Tag38 { get; set; }
        public int Tag39 { get; set; }
        public int Tag40 { get; set; }
        public int Tag41 { get; set; }
        public int Tag42 { get; set; }
        public int Tag43 { get; set; }
        public int Tag44 { get; set; }
        public int Tag45 { get; set; }
        public int Tag46 { get; set; }
        public int Tag47 { get; set; }
        public int Tag48 { get; set; }
        public int Tag49 { get; set; }
        public int Tag50 { get; set; }
        public int Tag51 { get; set; }
        public int Tag52 { get; set; }
        public int Tag53 { get; set; }
        public int Tag54 { get; set; }
        public int Tag55 { get; set; }
        public int Tag56 { get; set; }
        public int Tag57 { get; set; }
        public int Tag58 { get; set; }
        public int Tag59 { get; set; }
        public int Tag60 { get; set; }
        public int Tag61 { get; set; }
        public int Tag62 { get; set; }
        public int Tag63 { get; set; }
        public int Tag64 { get; set; }
        public int Tag65 { get; set; }
        public int Tag66 { get; set; }
        public int Tag67 { get; set; }
        public int Tag68 { get; set; }
        public int Tag69 { get; set; }
        public int Tag70 { get; set; }
        public int Tag71 { get; set; }
        public int Tag72 { get; set; }
        public int Tag73 { get; set; }
        public int Tag74 { get; set; }
        public int Tag75 { get; set; }
        public int Tag76 { get; set; }
        public int Tag77 { get; set; }
        public int Tag78 { get; set; }
        public int Tag79 { get; set; }
        public int Tag80 { get; set; }
        public int Tag81 { get; set; }
        public int Tag82 { get; set; }
        public int Tag83 { get; set; }
        public int Tag84 { get; set; }
        public int Tag85 { get; set; }
        public int Tag86 { get; set; }
        public int Tag87 { get; set; }
        public int Tag88 { get; set; }
        public int Tag89 { get; set; }
        public int Tag90 { get; set; }
        public int Tag91 { get; set; }
        public int Tag92 { get; set; }
        public int Tag93 { get; set; }
        public int Tag94 { get; set; }
        public int Tag95 { get; set; }
        public int Tag96 { get; set; }
        public int Tag97 { get; set; }
        public int Tag98 { get; set; }
        public int Tag99 { get; set; }
        public int Tag100 { get; set; }
        public int Tag101 { get; set; }
        public int Tag102 { get; set; }
        public int Tag103 { get; set; }
        public int Tag104 { get; set; }
        public int Tag105 { get; set; }
        public int Tag106 { get; set; }
        public int Tag107 { get; set; }
        
        public object this[string propertyName]
        {
            get { return this.GetType().GetProperty(propertyName).GetValue(this, null); }
            set { this.GetType().GetProperty(propertyName).SetValue(this, value, null); }
        }

    }
}
