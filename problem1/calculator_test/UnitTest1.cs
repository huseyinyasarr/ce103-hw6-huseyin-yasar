using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LesGraphingCalc;

namespace ce103_hw6_calc_test_cs
{
    [TestClass]
    public class UnitTest1
    {
        public void CalculateTest1()
        {
            var expected = RPN.Calculate("30+20");
            var actual = 50;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest2()
        {
            var expected = RPN.Calculate("61-16");
            var actual = 45;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void CalculateTest3()
        {
            var expected = RPN.Calculate("sqrt(25");
            var actual = 5;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest4()
        {
            var expected = RPN.Calculate("ln(e^8");
            var actual = 8;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest5()
        {
            var expected = RPN.Calculate("lg(1000");
            var actual = 3;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest6()
        {
            var expected = RPN.Calculate(" %10");
            var actual = 0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest7()
        {
            var expected = RPN.Calculate(" !6");
            var actual = 720;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest8()
        {
            var expected = RPN.Calculate(" 6 * 4");
            var actual = 24;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest9()
        {
            var expected = RPN.Calculate(" 12/4");
            var actual = 3;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest10()
        {
            var expected = RPN.Calculate(" 3^3");
            var actual = 27;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest11()
        {
            var expected = RPN.Calculate(" 9^2");
            var actual = 81;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest12()
        {
            var expected = RPN.Calculate(" 0^y");
            var actual = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest13()
        {
            var expected = RPN.Calculate("(20/5");
            var actual = 4;
            Assert.AreEqual(expected, actual);
        }
    }
}
