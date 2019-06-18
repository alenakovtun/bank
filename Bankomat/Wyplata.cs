using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bankomat
{
    public partial class Wyplata : Form
    {
        public double SumaNaKoncie = 1500;
        public Wyplata()
        {
            InitializeComponent();
        }

        /*!
         * Kiedy użytkownik wypłaca 20 zł ze swojego konta, to od jego bieżącego stanu konta będzie odejmowana ta ilość. 
         * Jeżeli na koncie mniej niż 20 zł, to wypłata nie będzie zrealizowana i pojawi się okienko z wiadomością o braku środków 
         * 
         */
        public void button1_Click(object sender, EventArgs e)
        {
            if (SumaNaKoncie < 20)
            {
                MessageBox.Show("Brak srodkow na koncie");
            }
            else
            {
                SumaNaKoncie = SumaNaKoncie - 20;
                MessageBox.Show("Odbierz kase" + "\n" + "Na twoim koncie " + SumaNaKoncie + " zlotych");
            }
        }

        /*!
         * Kiedy użytkownik wypłaca 50 zł ze swojego konta, to od jego bieżącego stanu konta będzie odejmowana ta ilość. 
         * Jeżeli na koncie mniej niż 50 zł, to wypłata nie będzie zrealizowana i pojawi się okienko z wiadomością o braku środków 
         * 
         */

        public void button2_Click(object sender, EventArgs e)
        {
            if (SumaNaKoncie < 50)
            {
                MessageBox.Show("Brak srodkow na koncie");
            }
            else
            {
                SumaNaKoncie = SumaNaKoncie - 50;
                MessageBox.Show("Odbierz kase " + "\n" + "Na twoim koncie " + SumaNaKoncie + " zlotych");
            }
        }

        /*!
         * Kiedy użytkownik wypłaca 100 zł ze swojego konta, to od jego bieżącego stanu konta będzie odejmowana ta ilość. 
         * Jeżeli na koncie mniej niż 100 zł, to wypłata nie będzie zrealizowana i pojawi się okienko z wiadomością o braku środków 
         * 
         */
        public void button3_Click(object sender, EventArgs e)
        {
            if (SumaNaKoncie < 100)
            {
                MessageBox.Show("Brak środków na końcie");
            }
            else
            {
                SumaNaKoncie = SumaNaKoncie - 100;
                MessageBox.Show("Odbierz kase" + "\n" + "Na twoim koncie " + SumaNaKoncie + " zlotych");
            }
        }

        /*!
         * Kiedy użytkownik wypłaca 200 zł ze swojego konta, to od jego bieżącego stanu konta będzie odejmowana ta ilość. 
         * Jeżeli na koncie mniej niż 200 zł, to wypłata nie będzie zrealizowana i pojawi się okienko z wiadomością o braku środków 
         * 
         */
        public void button4_Click(object sender, EventArgs e)
        {
            if (SumaNaKoncie < 200)
            {
                MessageBox.Show("Brak srodkow na koncie");
            }
            else
            {
                SumaNaKoncie = SumaNaKoncie - 200;
                MessageBox.Show("Odbierz kase" + "\n" + "Na twoim koncie " + SumaNaKoncie + " zlotych");
            }

        }
        private void button5_Click(object sender, EventArgs e)
        {
            WyborOperacji wyb = new WyborOperacji();
            wyb.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Wyplata_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            
        }

       

       
    }
}
