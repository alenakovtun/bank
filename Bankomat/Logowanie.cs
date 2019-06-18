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
    public partial class Logowanie : Form
    {
        public Logowanie()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ZaPomocaKarty zpk = new ZaPomocaKarty();
            zpk.Show();

        }
         

        private void button2_Click(object sender, EventArgs e)
        {
            BezKarty bz = new BezKarty();
            bz.Show();

        }

        private void button1_KeyDown()
        {

        }

        private void Logowanie_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
    }
}
