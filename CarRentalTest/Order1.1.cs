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
            clsOrder AnOrder = new clsOrder();
            Assert.IsNotNull(AnOrder);
        }
    

    [TestMethod]
    public void CarIDPropertyOK()
    {
        clsOrder AnOrder = new clsOrder();
        Int32 TestData = 010420;
            AnOrder.CarID = TestData;
        Assert.AreEqual(AnOrder.CarID, TestData);
    }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 978634;
            AnOrder.CustomerID = TestData;
            Assert.AreEqual(AnOrder.CustomerID, TestData);
        }

        [TestMethod]
        public void OrderIDPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 978634;
            AnOrder.OrderID = TestData;
            Assert.AreEqual(AnOrder.OrderID, TestData);
        }

        [TestMethod]
        public void StaffIDPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 978634;
            AnOrder.StaffID = TestData;
            Assert.AreEqual(AnOrder.StaffID, TestData);
        }

        [TestMethod]
    public void DateAddedPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            AnOrder.DateAdded = TestData;
            Assert.AreEqual(AnOrder.DateAdded, TestData);
        }
        [TestMethod]
        public void EmailPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            string TestData = "hfhggjjkkyfh";
            AnOrder.Email = TestData;
            Assert.AreEqual(AnOrder.Email, TestData);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 978634;
            AnOrder.Price = TestData;
            Assert.AreEqual(AnOrder.Price, TestData);
        }


    }
}
