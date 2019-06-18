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
        public int kasa;
        public double konto = 1500;

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StanKonta_Load(object sender, EventArgs e)
        {
           MessageBox.Show("Na twoim koncie " + konto + " zlotych");
        }

       
    }
}
