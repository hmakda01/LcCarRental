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

        public void CustomerTelephone()
        {
            clsCustomer ACustomer = new clsCustomer();
            String TestData = "01163480420";
            //assgn the data to the property
            ACustomer.CustomerTelephone = TestData;
            //applythe test
            Assert.AreEqual(ACustomer.CustomerTelephone, TestData);
        }


        [TestMethod]
        public void CustomerHouseNo()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "21b";
            //assign the data to the property
            ACustomer.CustomerHouseNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerHouseNo, TestData);
        }

        [TestMethod]
        public void CustomerPostCode()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "LE1 4AB";
            //assign the data to the property
            ACustomer.CustomerPostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerPostCode, TestData);
        }

        [TestMethod]
        public void CustomerStreet()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Some Street";
            //assign the data to the property
            ACustomer.CustomerStreet = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerStreet, TestData);
        }

        [TestMethod]
        public void CustomerTown()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Leicester";
            //assign the data to the property
            ACustomer.CustomerTown = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerTown, TestData);
        }
    }


}
