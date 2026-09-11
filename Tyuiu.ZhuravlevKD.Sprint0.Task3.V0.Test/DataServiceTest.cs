using System;
using NUnit.Framework;

using Tyuiu.ZhuravlevKD.Sprint0.Task3.V0.Lib;

namespace Tyuiu.ZhuravlevKD.Sprint0.Task3.V0.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void CheckedValid()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}