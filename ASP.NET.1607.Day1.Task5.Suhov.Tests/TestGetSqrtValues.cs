using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ASP.NET._1607.Day1.Task5.Suhov.Tests
{
    [TestClass]
    public class TestGetSqrtValues
    {
        [TestMethod]
        public void TestIntRootValue()
        {
            Assert.AreEqual(SqrtNewton.GetSqrt(32, 5, 0.000001), Math.Pow(32, 1.0 / 5), 0.000001);
        }

        [TestMethod]
        public void TestDoubleRootValue()
        {
            Assert.AreEqual(SqrtNewton.GetSqrt(32, 7, 0.000001), Math.Pow(32, 1.0 / 7), 0.000001);
        }

        [TestMethod]
        public void TestNaNValue()
        {
            Assert.AreEqual(SqrtNewton.GetSqrt(double.NaN, 4, 0.1), double.NaN);
        }

        [TestMethod]
        public void TestPrecision()
        {
            Assert.AreEqual(SqrtNewton.GetSqrt(10, 2, 0.1), Math.Pow(10, 1.0 / 2), 0.1);
        }

        [TestMethod]
        public void TestMaxPrecision()
        {
            Assert.AreEqual(SqrtNewton.GetSqrt(10, 2, 0.000000000000001), Math.Pow(10, 1.0 / 2), 0.000000000000001);
        }

        [TestMethod]
        public void TestNaNRoot()
        {
            Assert.AreEqual(SqrtNewton.GetSqrt(-2, 2, 0.1), Math.Pow(-2, 1d / 2));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestArgumentExceptions()
        {
            SqrtNewton.GetSqrt(2, 2, 16);
        }


        [TestMethod]
        public void TestDoubleValue()
        {
            Assert.AreEqual(SqrtNewton.GetSqrt(5.6, 2, 0.000001), Math.Pow(5.6, 1.0 / 2), 0.000001);
        }

        [TestMethod]
        public void TestZeroValue()
        {
            Assert.AreEqual(SqrtNewton.GetSqrt(0, 2, 0.000001), Math.Pow(0, 1.0 / 2), 0.000001);
        }

    }
}
