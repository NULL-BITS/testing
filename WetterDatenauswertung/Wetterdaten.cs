using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WetterDatenauswertung
{
    public class Wetterdaten
    {
        string datum;
        double temperatur, feuchtigkeit;
        public Wetterdaten(string datum, double temperatur, double feuchtigkeit)
        { 
            this.datum = datum;
            this.temperatur = temperatur;
            this.feuchtigkeit = feuchtigkeit;
        }
        public string Datum
        {
            get { return datum; }
        }
        public double Temperatur
        {
            get { return temperatur; }
        }
        public double Feuchtigkeit
        {
            get { return feuchtigkeit; }
        }
    }
}
