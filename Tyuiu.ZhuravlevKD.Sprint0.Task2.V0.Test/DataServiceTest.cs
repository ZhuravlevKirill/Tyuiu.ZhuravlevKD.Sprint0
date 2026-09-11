using System;
using NUnit.Framework;

using Tyuiu.ZhuravlevKD.Sprint0.Task2.V0.Lib;

namespace Tyuiu.ZhuravlevKD.Sprint0.Task2.V0.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void Test1()
        {
            {
                var name = "Кирилл";
                var res = DataService.GetMessage(name);
                
                Assert.AreEqual("Привет..., Кирилл", res);
            }
        }
    }
}