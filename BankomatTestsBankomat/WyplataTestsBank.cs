using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bankomat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat.TestsBankomat
{
    [TestClass()]
    public class WyplataTestsBank
    {
        [TestMethod()]
        public void button1_ClickTestWyplata_1()
        {
            //arrange
            Bankomat.Wyplata wyp = new Bankomat.Wyplata();
            double expected = 1480;

            //act
            wyp.button1_Click(null, null);

            //assert
            Assert.AreEqual(expected, wyp.SumaNaKoncie);
        }

        [TestMethod()]
        public void button2_ClickTestWyplata_2()
        {
            //arrange
            Bankomat.Wyplata wyp = new Bankomat.Wyplata();
            double expected = 1450;

            //act
            wyp.button2_Click(null, null);

            //assert
            Assert.AreEqual(expected, wyp.SumaNaKoncie);
        }

        [TestMethod()]
        public void button3_ClickTestWplata_3()
        {
            //arrange
            Bankomat.Wyplata wyp = new Bankomat.Wyplata();
            double expected = 1400;

            //act
            wyp.button3_Click(null, null);

            //assert
            Assert.AreEqual(expected, wyp.SumaNaKoncie);
        }

        [TestMethod()]
        public void button4_ClickTestWplata_4()
        {
            //arrange
            Bankomat.Wyplata wyp = new Bankomat.Wyplata();
            double expected = 1300;

            //act
            wyp.button4_Click(null, null);

            //assert
            Assert.AreEqual(expected, wyp.SumaNaKoncie);
        }
    }
}