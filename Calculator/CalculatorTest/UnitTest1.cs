using NUnit.Framework;
using Calculator;
using System;

namespace CalculatorTest
{
    public class Tests
    {
        [Test]
        public void TestSum()
        {
            double x = 12.3;
            double y = 13.2;
            var sum = new Operations.Sum();
            double result = sum.Calculate(x, y);
            Assert.AreEqual(25.5, result);
        }
        
        [Test]
        public void TestDiff()
        {
            double x = 16.5;
            double y = 30;
            var sum = new Operations.Diff();
            double result = sum.Calculate(x, y);
            Assert.AreEqual(-13.5, result);
        }
        
        [Test]
        public void TestMult()
        {
            double x = 3;
            double y = 30;
            var sum = new Operations.Mult();
            double result = sum.Calculate(x, y);
            Assert.AreEqual(90, result);
        }
        [Test]
        public void TestDiv()
        {
            double x = 14;
            double y = 2;
            var sum = new Operations.Div();
            double result = sum.Calculate(x, y);
            Assert.AreEqual(7, result);
        }
        [Test]
        public void TestPow()
        {
            double x = 2;
            double y = 11;
            var sum = new Operations.Pow();
            double result = sum.Calculate(x, y);
            Assert.AreEqual(2048, result);
        }
        [Test]
        public void TestOstat()
        {
            double x = 40;
            double y = 30;
            var sum = new Operations.Ostat();
            double result = sum.Calculate(x, y);
            Assert.AreEqual(10, result);
        }

        [TestCase(5, 7, 12)]
        [TestCase(1, 2.5, 3.5)]
        [TestCase(100, -1, 99)]
        [TestCase(10, -100, -90)]
        public void TestSumCase(double a, double b, double exp)
        {
            var sumcase = new Operations.Sum();
            double act = sumcase.Calculate(a, b); 
            Assert.AreEqual(exp, act);
        }

        [TestCase(8, 5, 3)]
        [TestCase(9, 12, -3)]
        [TestCase(25, 20, 5)]
        [TestCase(10, 2, 8)]
        public void TestDiffCase(double a, double b, double exp)
        {
            var diffcase = new Operations.Diff();
            double act = diffcase.Calculate(a, b);
            Assert.AreEqual(exp, act);
        }

        [TestCase(2, 5, 10)]
        [TestCase(5, 3, 15)]
        [TestCase(12, 10, 120)]
        [TestCase(10, 3, 30)]
        public void TestMultCase(double a, double b, double exp)
        {
            var multcase = new Operations.Mult();
            double act = multcase.Calculate(a, b);
            Assert.AreEqual(exp, act);
        }

        [TestCase(6, 2, 3)]
        [TestCase(133, 1, 133)]
        [TestCase(35, 5, 7)]
        [TestCase(220, 2, 110)]
        public void TestDivCase(double a, double b, double exp)
        {
            var divcase = new Operations.Div();
            double act = divcase.Calculate(a, b);
            Assert.AreEqual(exp, act);
        }

        [TestCase(9, 2, 81)]
        [TestCase(3, 3, 27)]
        [TestCase(4, 4, 256)]
        [TestCase(2, 0, 1)]
        public void TestPowCase(double a, double b, double exp)
        {
            var powcase = new Operations.Pow();
            double act = powcase.Calculate(a, b);
            Assert.AreEqual(exp, act);
        }

        [TestCase(8, 9, 8)]
        [TestCase(76, 5, 1)]
        [TestCase(99, 9, 0)]
        [TestCase(218, 3, 2)]
        public void TestOstatCase(double a, double b, double exp)
        {
            var ostatcase = new Operations.Ostat();
            double act = ostatcase.Calculate(a, b);
            Assert.AreEqual(exp, act);
        }
    }
}
