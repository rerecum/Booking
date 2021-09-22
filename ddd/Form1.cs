using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ddd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoWyjazduPozostaloLabel.Text = "Do wyjazdu pozostalo " + (dataPrzyjazdu.Value - dataDzisiaj.Value).Days.ToString() + "dni";

            WyjazdTrwaLabel.Text = "Do wyjazdu pozostalo" + (dataWyjazdu.Value - dataPrzyjazdu.Value).Days.ToString() + "dni";

            KosztLabel.Text = "Koszt wynosi" + (CenaZaDobe.Value * (dataWyjazdu.Value - dataPrzyjazdu.Value).Days).ToString() + "zl";
        }
    }
}
