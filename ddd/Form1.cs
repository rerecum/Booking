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
            System.DateTime theDay = new System.DateTime(System.DateTime.Today.Year, 7, 28);
            int compareValue;

            try
            {
                compareValue = theDay.CompareTo(DateTime.Today);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Value is not a DateTime");
                return;
            }

            if (compareValue < 0)
                System.Console.WriteLine("{0:d} its in the past.", theDay);
            else
                {   if (compareValue == 0)
                        System.Console.WriteLine("{0:d} its today!", theDay);
                    else 
                        System.Console.WriteLine("{0:d} has not come yet.", theDay);
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoWyjazduPozostaloLabel.Text = "Do wyjazdu pozostalo " + (dataPrzyjazdu.Value - dataDzisiaj.Value).Days.ToString() + "dni";

            WyjazdTrwaLabel.Text = "Do wyjazdu pozostalo" + (dataWyjazdu.Value - dataPrzyjazdu.Value).Days.ToString() + "dni";

            KosztLabel.Text = "Koszt wynosi" + (CenaZaDobe.Value * (dataWyjazdu.Value - dataPrzyjazdu.Value).Days).ToString() + "zl";
        }

        private void CenaZaDobe_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataPrzyjazdu_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
