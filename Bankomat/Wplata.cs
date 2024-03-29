﻿using System;
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
    public partial class Wplata : Form
    {
        public int kasa;//!< Ilość wpisanej kasy
        public double konto = 1500;//!< stan konta
        public Wplata()
        {
            InitializeComponent();
        }
        /*!
        * \ brief wpisujemy kasę
        */
        public void getkasa()
        {
            kasa = Int32.Parse(textBox1.Text);
        }
        /*!
        * \brief Powrót do wybora operacja
        * \param sender obiekt, który wyzwala zdarzenie.
        * \param e zmienna argumentu
        */
        private void button2_Click(object sender, EventArgs e)
        {
            WyborOperacji wyb = new WyborOperacji();
            wyb.Show();
            this.Close();
        }

        /*!
         * \brief Gdy użytkownik realizuje wplatę, jego stan konta zwieksza się na te ilość kasy
         * \param sender obiekt, który wyzwala zdarzenie.
         * \param e zmienna argumentu
         */

        public void button1_Click(object sender, EventArgs e)
        {
            getkasa();
            konto = konto + kasa;
            MessageBox.Show("Kasa przyjeta" + "\n" + "Na twoim koncie " + konto + " zlotych");
        }


        /*!
        * \param sender obiekt, który wyzwala zdarzenie.
        * \param e zmienna argumentu 
        */
        private void Wplata_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
    }
}
