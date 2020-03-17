using System;
using CarRentalClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CarRentalTest
{
    [TestClass]
    public class CustomerTest
    {

        string Username = "John123";
        string CustomerFirstName = "John";
        string CustomerLastName = "Simms";
        string CustomerEmail = "john@email.com";
        string CustomerAddress = "123 new road";
        string CustomerTelephone = "01234567890";


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
        public void UsernameOK()
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
        public void CustomerFirstNameOK()
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
        public void CustomerLastNameOK()
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

        public void CustomerEmailOK()
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

        public void CustomerAddressOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            //create some tests data
            string TestData = "12 Random Road";
            //assign the data to the property
            ACustomer.CustomerAddress = TestData;
            //test tpos ee if it works
            Assert.AreEqual(ACustomer.CustomerAddress, TestData);
        }

        [TestMethod]

        public void CustomerTelephoneOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            String TestData = "01163480420";
            //assgn the data to the property
            ACustomer.CustomerTelephone = TestData;
            //applythe test
            Assert.AreEqual(ACustomer.CustomerTelephone, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            //assgn the data to the property
            Int32 CustomerID = 4;
            //
            Found = ACustomer.Find(CustomerID);
            //apply the test
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 4;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.CustomerID != 4)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestUsernameFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 4;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.Username != "John123")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFirstNameFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 4;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.CustomerFirstName != "John")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLastNameFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 4;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.CustomerLastName != "Simms")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 4;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.CustomerEmail != "John@email.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestAddressFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 4;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.CustomerAddress != "123 Some Street")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneNoFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 4;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.CustomerTelephone != "01234567890")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            Error = ACustomer.Valid(Username, CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress, CustomerTelephone);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UsernameMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Username = "";
            Error = ACustomer.Valid(Username, CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress, CustomerTelephone);
            Assert.AreNotEqual(Error, "");
        }
        //page 17 week 24
        //page 17 week 24
        //page 17 week 24
        //page 17 week 24
        //page 17 week 24
        //page 17 week 24

    }
}




