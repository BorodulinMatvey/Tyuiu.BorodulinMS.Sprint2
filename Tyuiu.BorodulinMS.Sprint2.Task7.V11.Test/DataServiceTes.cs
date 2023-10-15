using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BorodulinMS.Sprint2.Task7.V11.Lib;
namespace Tyuiu.BorodulinMS.Sprint2.Task7.V11.Test
{
    [TestClass]
    public class DataServiceTes
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = -0.3;
            double y = 0.7;

            Assert.AreEqual(false, ds.CheckDotInShadedArea(x, y));
        }


    
    }
}