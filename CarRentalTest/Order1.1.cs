using System;
using CarRentalClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarRentalTest
{
    [TestClass]
    public class Order1
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrder AnOrder = clsOrder();
            Assert.IsNotNull(AnOrder);
        }
    }
}
