using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BambooTest;

namespace BambooTTest
{
    [TestClass]
    public class CalTest
    {
        [TestMethod]
        public void Add()
        {
            Calculate ex = new Calculate();
            Assert.AreEqual(31, ex.Add(20, 11));
        }

        [TestMethod]
        public void Sub()
        {
            Calculate ex = new Calculate();
            Assert.AreEqual(10, ex.Sub(20, 10));
        }

        [TestMethod]
        public void Mul()
        {
            Calculate ex = new Calculate();
            Assert.AreEqual(6, ex.Mul(2, 3));
        }

        [TestMethod]
        public void Div()
        {
            Calculate ex = new Calculate();
            Assert.AreEqual(6, ex.Div(48, 6));
        }
    }
}
