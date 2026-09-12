using System;
using NUnit.Framework;

using Tyuiu.ZhuravlevKD.Sprint0.Task5.V0.Lib;

namespace Tyuiu.ZhuravlevKD.Sprint0.Task5.V0.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }

        [Test]
        public void CheckedSubtractionValid()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));
        }

        [Test]
        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));
        }

        [Test]
        public void CheckedDivisionValid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }
    }
}