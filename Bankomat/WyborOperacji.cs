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

    public partial class WyborOperacji : Form
    {
        
        public WyborOperacji()
        {
            InitializeComponent();
        }

        /*!
          * Zamknięcie 
          * param sender
          * param e
          */
        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }


        /*!
        * \brief Wybieramy operacje Wyplata 
        * \param sender
        * \param e
        * 
        */

        private void button1_Click(object sender, EventArgs e)
        {
            Wyplata wypl = new Wyplata();
            wypl.Show();
            this.Close();
        }

        /*!
        * \brief Wybieramy operacje Wplata 
        * \param sender
        * \param e
        * 
        */
        private void button3_Click(object sender, EventArgs e)
        {
            Wplata wpl = new Wplata();
            wpl.Show();
            this.Close();

        }

        /*!
        * \brief Wybieramy operacje Stan konta 
        * \param sender
        * \param e
        * 
        */
        private void button2_Click(object sender, EventArgs e)
        {
            StanKonta sk = new StanKonta();
            sk.Show();
            this.Close();
        }

        /*!
        * param sender
        * param e
        */
        private void WyborOperacji_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
    }
}
