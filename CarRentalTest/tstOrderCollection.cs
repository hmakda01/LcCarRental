using System;
using CarRentalClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CarRentalTest
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.IsNotNull(AllOrders);
        }
        [TestMethod]
        public void OrderListOk()
        {

            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.CarReg = 1;
            TestItem.CustomerID = 1;
            TestItem.OrderID = 1;
            TestItem.StaffID = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Email = "";
            TestItem.Price = 1;
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void ListAndCountOk()
        {

            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.CarReg = 1;
            TestItem.CustomerID = 1;
            TestItem.OrderID = 1;
            TestItem.StaffID = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Email = "";
            TestItem.Price = 1;
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }







    }
}
