using System;
using descending_order;
using NUnit.Framework;

namespace descending_order_tests
{
    [TestFixture]
    public class Tests
    {
        #region Actual Checks
        [Test]
        public void Test0()
        {
            var input = 21445;
            Assert.AreEqual(54421, Kata.DescendingOrder(input));
        }

        [Test]
        public void Test1()
        {
            var input = 145263;
            Assert.AreEqual(654321, Kata.DescendingOrder(input));
        }

        [Test]
        public void Test2()
        {
            var input = 1254859723;
            Assert.AreEqual(9875543221, Kata.DescendingOrder(input));
        }

        [Test]
        public void TestZero()
        {
            var input = 0;
            Assert.AreEqual(0, Kata.DescendingOrder(input));
        }
        #endregion
    }
}
