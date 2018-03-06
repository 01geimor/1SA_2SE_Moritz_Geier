using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SA1_Auto
{
    class Auto
    {
        private int tankgroese,tankinhalt, verbrauch, ps;
        private string farbe, marke;

        public Auto(string marke, string farbe, int ps, int tankgroese, int verbrauch)
        {
            this.marke = marke;
            this.farbe = farbe;
            this.ps = ps;
            this.tankgroese = tankgroese;
            this.verbrauch = verbrauch;
        }

        public int Tanken(int tanken)
        {
            if (tankinhalt+tanken<=tankgroese)
            {
                tankinhalt += tanken;
            }
            else
            {
                tankinhalt = tankgroese;
            }
            return tankinhalt;
        }

        public int Fahren(int fahren)
        {
            if (tankinhalt + fahren <= tankgroese)
            {
                tankinhalt += fahren;
            }
            else
            {
                tankinhalt = tankgroese;
            }
            return tankinhalt;
        }
    }
}
