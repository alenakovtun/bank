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
    public partial class InnaKwota : Form
    {
        public string GetInnaKwota;
      
        public InnaKwota()
        {
            InitializeComponent();
        }

        /*!
        * \param sender obiekt, który wyzwala zdarzenie.
        * \param e zmienna argumentu
        */

        private void button2_Click(object sender, EventArgs e)
        {
            Wyplata wo = new Wyplata();
            wo.Show();
            this.Close();

        }

        /*!
        * \param sender obiekt, który wyzwala zdarzenie.
        * \param e zmienna argumentu
        */

        private void button1_Click(object sender, EventArgs e)
        {
            GetInnaKwota = textBox1.Text;

        }

        /*!
        * \param sender obiekt, który wyzwala zdarzenie.
        * \param e zmienna argumentu
        */
        private void InnaKwota_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
    }
}
