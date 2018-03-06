using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SA1_Auto
{
    class Auto
    {
        private int tankgroese, verbrauch, ps;
        private string farbe, marke;

        public Auto(string marke, string farbe, int ps, int tankgroese, int verbrauch)
        {
            this.marke = marke;
            this.farbe = farbe;
            this.ps = ps;
            this.tankgroese = tankgroese;
            this.verbrauch = verbrauch;
        }
    }
}
