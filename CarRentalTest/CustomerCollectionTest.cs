using System;
using System.Collections.Generic;
using CarRentalClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarRentalTest
{
    [TestClass]
    public class CustomerCollectionTest
    {
        [TestMethod]
        public void TestMethod1()
        {
        }


        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }




        [TestMethod]
        public void AddMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.Active = true;
            TestItem.CustomerID = 4;
            TestItem.Username = "John123";
            TestItem.CustomerFirstName = "John";
            TestItem.CustomerLastName = "Smith";
            TestItem.CustomerEmail = "";
            TestItem.CustomerTelephone = "01163480420";
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            //assign the data to the property
            TestItem.CustomerID = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }


        [TestMethod]
        public void DeleteMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.Active = true;
            TestItem.CustomerID = 1;
            TestItem.Username = "John123";
            TestItem.CustomerFirstName = "John";
            TestItem.CustomerLastName = "Smith";
            TestItem.CustomerEmail = "";
            TestItem.CustomerTelephone = "01163480420";
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            //assign the data to the property
            TestItem.CustomerID = PrimaryKey;
            //
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //
            AllCustomers.Delete();
            //test to see that the two values are the same
            bool Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //
            Assert.IsFalse(Found);

        }
    }

}
