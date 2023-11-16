using Microsoft.VisualStudio.TestTools.UnitTesting;
using KalkulatorFi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorFi.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void TambahTest()
        {
            Calculator cal = new Calculator();
            Assert.AreEqual(20, cal.Tambah(1, 19));
            //Assert.Fail();
        }

        [TestMethod()]
        public void KurangTest()
        {
            Calculator cal = new Calculator();
            Assert.AreEqual(20, cal.Kurang(25, 5));
            //Assert.Fail();
        }

        [TestMethod()]
        public void BagiTest()
        {
            Calculator cal = new Calculator();
            Assert.AreEqual(20, cal.Bagi(100, 5));
            //Assert.Fail();
        }

        [TestMethod()]
        public void KaliTest()
        {
            Calculator cal = new Calculator();
            Assert.AreEqual(20, cal.Kali(4, 5));
            //Assert.Fail();
        }

        [TestMethod()]
        public void ModulusTest()
        {
            Calculator cal = new Calculator();
            Assert.AreEqual(1, cal.Modulus(5, 2));
            //Assert.Fail();
        }
    }
}