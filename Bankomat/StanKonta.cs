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
    public partial class StanKonta : Form
    {
        public int kasa; //!< wpisana kasa
        public double konto = 1500;//!< stan konta

        public StanKonta()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WyborOperacji wo = new WyborOperacji();
            wo.Show();
            this.Close();

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
        * \ brief Wyświetlanie stanu konta
        * \param sender obiekt, który wyzwala zdarzenie.
        * \param e zmienna argumentu 
        */
        private void StanKonta_Load(object sender, EventArgs e)
        {
           MessageBox.Show("Na twoim koncie " + konto + " zlotych");
        }

       
    }
}
