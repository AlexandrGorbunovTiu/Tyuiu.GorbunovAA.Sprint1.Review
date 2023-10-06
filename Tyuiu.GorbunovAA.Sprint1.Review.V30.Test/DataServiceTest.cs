using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GorbunovAA.Sprint1.Review.V30.Lib;

namespace Tyuiu.GorbunovAA.Sprint1.Review.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 0;
            int y = 1;
            var otvet = 1.2; 
            var res = ds.Calculate(x, y);
            Assert.AreEqual(res, otvet);

        }
    }
}
