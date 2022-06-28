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
            Assert.AreEqual(18, Operations.Sum(7, 11));
        }
        [Test]
        public void TestDiff()
        {
            Assert.AreEqual(5, Operations.Diff(8, 3));
        }
        [Test]
        public void TestMult()
        {
            Assert.AreEqual(6.4, Operations.Mult(3.2, 2));
        }
        [Test]
        public void TestDiv()
        {
            Assert.AreEqual(3, Operations.Div(18, 6));
        }
        [Test]
        public void TestStep()
        {
            Assert.AreEqual(2048, Operations.Step(2, 11));
        }
        [Test]
        public void TestOstat()
        {
            Assert.AreEqual(1, Operations.Ostat(5, 2));
        }
    }
}