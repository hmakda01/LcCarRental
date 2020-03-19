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
            //put in test data
            Int32 PrimaryKey = 0;
            TestItem.Username = "John123";
            TestItem.CustomerFirstName = "John";
            TestItem.CustomerLastName = "Smith";
            TestItem.CustomerEmail = "";
            TestItem.CustomerAddress = "123 Some Street";
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
            TestItem.Username = "John123";
            TestItem.CustomerFirstName = "John";
            TestItem.CustomerLastName = "Smith";
            TestItem.CustomerEmail = "";
            TestItem.CustomerAddress = "123 Some Street";
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

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.Username = "John123";
            TestItem.CustomerFirstName = "John";
            TestItem.CustomerLastName = "Smith";
            TestItem.CustomerEmail = "";
            TestItem.CustomerAddress = "123 Some Street";
            TestItem.CustomerTelephone = "01163480420";
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            //assign the data to the property
            TestItem.CustomerID = PrimaryKey;
            //
            TestItem.Username = "Stephen678";
            TestItem.CustomerFirstName = "Stephen";
            TestItem.CustomerLastName = "Coulade";
            TestItem.CustomerEmail = "fsdf@live.co.uk";
            TestItem.CustomerAddress = "456 Different Street";
            TestItem.CustomerTelephone = "01557347020";
            //
            AllCustomers.ThisCustomer = TestItem;
            //
            AllCustomers.Update();
            //test to see that the two values are the same
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

        }

        [TestMethod]
        public void ReportByUsernameMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            FilteredCustomers.ReportByUsername("");
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByUsernameNoneFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            FilteredCustomers.ReportByUsername("Example123");
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByUsernameTestDataFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            Boolean OK = true;
            FilteredCustomers.ReportByUsername("Example123");
            if (FilteredCustomers.Count == 2)
            {
                if (FilteredCustomers.CustomerList[0].CustomerID !=1)
                {
                    OK = false;
                }
                if (FilteredCustomers.CustomerList[1].CustomerID != 2)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}
