using System;
using CarRentalClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CarRentalTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void InstanceOk()
        {
            clsCustomer ACustomer = new clsCustomer();
            //testt to see if it works
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void ActivePropertyOk()
        {
            clsCustomer ACustomer = new clsCustomer();
            //cretae some test data
            bool TestData = true;
            //assignthr  dta to the property
            ACustomer.Active = TestData;
            //test to see the tewo values are the same
            Assert.AreEqual(ACustomer.Active, TestData);
        }

        [TestMethod]
        public void CustomerID()
        {
            clsCustomer ACustomer = new clsCustomer();
            //create some tests data
            Int32 TestData = 1;
            //assign the data to the property
            ACustomer.CustomerID = TestData;
            //test tpos ee if it works
            Assert.AreEqual(ACustomer.CustomerID, TestData);
        }


        [TestMethod]
        public void Username()
        {
            clsCustomer ACustomer = new clsCustomer();
            //create some tests data
            string TestData = "John123";
            //assign the data to the property
            ACustomer.Username = TestData;
            //test tpos ee if it works
            Assert.AreEqual(ACustomer.Username, TestData);
        }

        [TestMethod]
        public void CustomerFirstName()
        {
            clsCustomer ACustomer = new clsCustomer();
            //create some tests data
            string TestData = "John";
            //assign the data to the property
            ACustomer.CustomerFirstName = TestData;
            //test tpos ee if it works
            Assert.AreEqual(ACustomer.CustomerFirstName, TestData);
        }

        [TestMethod]
        public void CustomerLastName()
        {
            clsCustomer ACustomer = new clsCustomer();
            //create some tests data
            string TestData = "smith";
            //assign the data to the property
            ACustomer.CustomerLastName = TestData;
            //test tpos ee if it works
            Assert.AreEqual(ACustomer.CustomerLastName, TestData);
        }


        [TestMethod]

        public void CustomerEmail()
        {
            clsCustomer ACustomer = new clsCustomer();
            //create some tests data
            string TestData = "hfhggfh";
            //assign the data to the property
            ACustomer.CustomerEmail = TestData;
            //test tpos ee if it works
            Assert.AreEqual(ACustomer.CustomerEmail, TestData);
        }

        [TestMethod]

        public void CustomerTelephone()
        {
            clsCustomer ACustomer = new clsCustomer();
            String TestData = "01163480420";
            //assgn the data to the property
            ACustomer.CustomerTelephone = TestData;
            //applythe test
            Assert.AreEqual(ACustomer.CustomerTelephone, TestData);
        }

    }

}
