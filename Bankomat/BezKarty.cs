/*!
 * \author Alona Kovtun Vladyslava Tokar 
 * \version 1.0
 * \date 18.06.2019
 */
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
    public partial class BezKarty : Form
    {
        public BezKarty()
        {
            InitializeComponent();
        }
        public string Nik = "nik";//!< Prawidlowy nik
        public string Haslo = "haslo";//!< Prawidlowe hasło
        public string nik;//!< nik wpisany użytkownikiem
        public string haslo;//!< hasło wpisane użytkownikiem
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
         * \brief Jeżeli nik i hasło pasują, to użytkownik może zalogować się w systemie. W innym przypadku będzie wiadomość o tym, że dane są nieprawidlowe
         * \param sender obiekt, który wyzwala zdarzenie.
         * \param e zmienna argumentu
         * 
         */

        private void button2_Click(object sender, EventArgs e)
        {
            nik = textBox1.Text;
            haslo = textBox2.Text;
            if (Nik == nik && Haslo == haslo)
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

        /*!
         * \param sender obiekt, który wyzwala zdarzenie.
         * \param e zmienna argumentu.
         */
        private void BezKarty_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
    }
}
