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
        private double tankinhalt,gefahrenekm;

        public Auto(string marke, string farbe, int ps, int tankgroese, int verbrauch)
        {
            this.marke = marke;
            this.farbe = farbe;
            this.ps = ps;
            this.tankgroese = tankgroese;
            this.verbrauch = verbrauch;
        }

        public double Tanken(double tanken)
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

        public double Fahren(double fahren)
        {
            if (tankinhalt - (fahren*verbrauch/100.0) >= 0)
            {
                tankinhalt -= fahren * verbrauch / 100.0;
                gefahrenekm += fahren;
            }
            else
            {
                tankinhalt = 0;
                for (int i = Convert.ToInt32(tankinhalt); i > 0; i--)
                {
                    gefahrenekm += verbrauch / 100.0;
                }
            }
            return tankinhalt;
        }

        public string[] Ausgabe()
        {
            string[] s = new string[5]{marke,gefahrenekm.ToString(),farbe,ps.ToString(),tankinhalt.ToString()};
            return s;
        }
    }
}
