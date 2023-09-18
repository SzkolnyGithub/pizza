using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzaBadowski4c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Rodzaj_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void srednia_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void duza_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pomidory_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void szynka_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ser_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void grube_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cienkie_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void oblicz_Click(object sender, EventArgs e)
        {
            int koszt = 0;
            if(mala.Checked == true)
            {
                koszt += 20;
            } else if(srednia.Checked == true) {
                koszt += 40;
            } else if(duza.Checked == true)
            {
                koszt += 60;
            }

            if(rodzaj.Text == "Margherita")
            {
                koszt += 50;
            } else if(rodzaj.Text == "Pepperoni")
            {
                koszt += 70;
            } else if(rodzaj.Text == "New Yorker")
            {
                koszt += 100;
            } else if(rodzaj.Text == "Hawajska")
            {
                koszt += 120;
            } else if(rodzaj.Text == "Jalapeno")
            {
                koszt += 150;
            }

            if(salata.Checked)
            {
                koszt += 20;
            }
            if(pomidory.Checked)
            {
                koszt += 15;
            }
            if(szynka.Checked)
            {
                koszt += 25;
            }
            if(ser.Checked)
            {
                koszt += 5;
            }

            if(grube.Checked)
            {
                koszt += 40;
            } else if(cienkie.Checked)
            {
                koszt += 20;
            }

            cena.Text = "Cena to: " + koszt.ToString() + "zł.";
        }

        private void cena_Click(object sender, EventArgs e)
        {

        }
    }
}
