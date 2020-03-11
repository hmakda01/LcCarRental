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
        public void ListAndCountOK()
        {
            //cretae an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test dat to assign to thwe property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add a item to the ;list
            //cretae the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.Active = true;
            TestItem.Username = "John123";
            TestItem.CustomerFirstName = "John";
            TestItem.CustomerLastName = "Smith";
            TestItem.CustomerEmail = "";
            TestItem.CustomerTelephone = "01163480420";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }


        [TestMethod]
        public void AddMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.Active = true;
            TestItem.Username = "John123";
            TestItem.CustomerFirstName = "John";
            TestItem.CustomerLastName = "Smith";
            TestItem.CustomerEmail = "";
            TestItem.CustomerTelephone = "01163480420";
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            //assign the data to the property
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }
    }

}
