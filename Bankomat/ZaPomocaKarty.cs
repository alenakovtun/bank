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
    public partial class ZaPomocaKarty : Form
    {
        public ZaPomocaKarty()
        {
            InitializeComponent();
        }
        public string NumerKarty = "1234567890";//!< Prawidlowy numer karty
        public string Pin= "1234";//!< Prawidlowy pin
        public string numerkarty;//!< numer karty wpisany użytkownikiem
        public string pin;//!< pin wpisany użytkownikiem

        private void label2_Click(object sender, EventArgs e)
        {

        }
        /*!
          * Zamknięcie 
          * \param sender obiekt, który wyzwala zdarzenie.
          * \param e zmienna argumentu
          */
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*!
         * Jeżeli numer karty i pin pasują, to użytkownik może zalogować się w systemie. W innym przypadku będzie wiadomość o tym, że dane są nieprawidlowe
         * \param sender obiekt, który wyzwala zdarzenie.
         * \param e zmienna argumentu
         */

        private void button2_Click(object sender, EventArgs e)
        {
            numerkarty= textBox1.Text;
            pin = textBox2.Text;
            if (NumerKarty == numerkarty && Pin == pin)
            {
                WyborOperacji wo = new WyborOperacji();
                wo.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Blednie podane dane. Sprobuj ponownie");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /*!
        * \param sender obiekt, który wyzwala zdarzenie.
        * \param e zmienna argumentu 
        */

        private void ZaPomocaKarty_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
