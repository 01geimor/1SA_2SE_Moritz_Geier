using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SA1_Auto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            try
            {
                Auto a = new Auto(txtb_marke.Text,cmb_farbe.Text,Convert.ToInt32(txtb_ps.Text),Convert.ToInt32(txtb_tankgr.Text),Convert.ToInt32(txtb_verbrauch.Text));
                lbl_error.Text = " ";
            }
            catch
            {
                lbl_error.Text = "Eingabe fehlerhaft";
            }
        }

        private void btn_tanken_Click(object sender, EventArgs e)
        {

        }

        private void btn_fahren_Click(object sender, EventArgs e)
        {

        }
    }
}
