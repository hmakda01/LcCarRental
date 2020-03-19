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
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrders);
        }
        [TestMethod]
        public void OrderListOk()
        {

            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            TestItem.StaffID = 1;
            TestItem.CarID = 1;
            TestItem.Date = DateTime.Now.Date;
            TestItem.Email = "";
            TestItem.Price = 1;
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
           // TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            TestItem.StaffID = 1;
            TestItem.CarID = 1;
            TestItem.Date = DateTime.Now.Date;
            TestItem.Email = "jkjkjkj";
            TestItem.Price = 177;
            AllOrder.ThisOrder = TestItem;
            PrimaryKey = AllOrder.Add();
            TestItem.OrderID = PrimaryKey;
            AllOrder.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrder.ThisOrder, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOk()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            //TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            TestItem.StaffID = 1;
            TestItem.CarID = 1;
            TestItem.Date = DateTime.Now.Date;
            TestItem.Email = "";
            TestItem.Price = 1;
            AllOrder.ThisOrder = TestItem;
            PrimaryKey = AllOrder.Add();
            TestItem.OrderID = PrimaryKey;
            AllOrder.ThisOrder.Find(PrimaryKey);
            AllOrder.Delete();
            Boolean Found = AllOrder.ThisOrder.Find(PrimaryKey);
            Assert.IsFalse(Found);

        }
        [TestMethod]
        public void UpdateMethodOk()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            //TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            TestItem.StaffID = 1;
            TestItem.CarID = 1;
            TestItem.Date = DateTime.Now.Date;
            TestItem.Email = "";
            TestItem.Price = 1;
            AllOrder.ThisOrder = TestItem;
            PrimaryKey = AllOrder.Add();
            TestItem.OrderID = PrimaryKey;
           // TestItem.OrderID = 2;
            TestItem.CustomerID = 2;
            TestItem.StaffID = 2;
            TestItem.CarID = 2;
            TestItem.Date = DateTime.Now.Date;
            TestItem.Email = "";
            TestItem.Price = 2;
            AllOrder.ThisOrder = TestItem;
            AllOrder.update();
            AllOrder.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrder.ThisOrder, TestItem);

        }
        [TestMethod]
        public void ReportByEmailMethodOK()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            clsOrderCollection FilteredOrder = new clsOrderCollection();
            FilteredOrder.ReportByEmail("");
            Assert.AreEqual(AllOrder.Count, FilteredOrder.Count);

        }

        [TestMethod]
        public void ReportByEmailNoneFound()
        {
            clsOrderCollection FilteredOrder = new clsOrderCollection();
            FilteredOrder.ReportByEmail("xxxxx@xxxxxxxxxxx");
            Assert.AreEqual(0, FilteredOrder.Count);
        }

        [TestMethod]
        public void ReportByEmailTestDataFound()
        {
            clsOrderCollection FilteredOrder = new clsOrderCollection();
            Boolean OK = true;
            FilteredOrder.ReportByEmail("hm@hotmail.co.uk");
            if (FilteredOrder.Count == 1)
            {
                if (FilteredOrder.OrderList[0].OrderID != 1)
                {
                    OK = false;
                }
                //if (FilteredOrder.OrderList[1].OrderID != 25)
                //{
                //    OK = false;
                //}
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}


















