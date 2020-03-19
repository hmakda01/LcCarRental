using System;
using CarRentalClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CarRentalTest
{
    [TestClass]
    public class CustomerTest
    {

        
        string Username = "example";
        string CustomerFirstName = "example";
        string CustomerLastName = "example";
        string CustomerEmail = "example";
        string CustomerAddress = "example";
        string CustomerTelephone = "example";



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
        public void CustomerIDOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            //create some tests data
            Int32 TestData = 4;
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
            Int32 CustomerID = 6;
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
            Int32 CustomerID = 6;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.CustomerID != 6)
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
            Int32 CustomerID = 6;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.Username != "example")
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
            Int32 CustomerID = 6;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.CustomerFirstName != "example")
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
            Int32 CustomerID = 6;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.CustomerLastName != "example")
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
            Int32 CustomerID = 6;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.CustomerEmail != "example")
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
            Int32 CustomerID = 6;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.CustomerAddress != "example")
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
            Int32 CustomerID = 6;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.CustomerTelephone != "example")
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
            Assert.AreEqual(Error, "");
        }


        //Username Validation Tests


        [TestMethod]
        public void UsernameMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Username = "";
            Error = ACustomer.Valid(Username, CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress, CustomerTelephone);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UsernameMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Username = "a";
            Error = ACustomer.Valid(Username, CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress, CustomerTelephone);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UsernameMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Username = "aa";
            Error = ACustomer.Valid(Username, CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress, CustomerTelephone);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UsernameMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Username = "aaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(Username, CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress, CustomerTelephone);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UsernameMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Username = "aaaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(Username, CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress, CustomerTelephone);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UsernameMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Username = "aaaaaaaaaaa";
            Error = ACustomer.Valid(Username, CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress, CustomerTelephone);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UsernameMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Username = "aaaaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(Username, CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress, CustomerTelephone);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UsernameExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Username = "";
            Username = Username.PadRight(500, 'a');//500 characters, should fail
            Error = ACustomer.Valid(Username, CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress, CustomerTelephone);
            Assert.AreNotEqual(Error, "");
        }


        //CustomerFirstName Validation Tests


        [TestMethod]
        public void CustomerFirstNameMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerFirstName = "";
            Error = ACustomer.Valid(Username, CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress, CustomerTelephone);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerFirstName = "a";
            Error = ACustomer.Valid(Username, CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress, CustomerTelephone);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerFirstName = "aa";
            Error = ACustomer.Valid(Username, CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress, CustomerTelephone);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerFirstName = "aaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(Username, CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress, CustomerTelephone);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerFirstName = "aaaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(Username, CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress, CustomerTelephone);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerFirstName = "aaaaaaaaaaa";
            Error = ACustomer.Valid(Username, CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress, CustomerTelephone);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerFirstName = "aaaaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(Username, CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress, CustomerTelephone);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerFirstName = "";
            CustomerFirstName = CustomerFirstName.PadRight(500, 'a');//500 characters, should fail
            Error = ACustomer.Valid(Username, CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress, CustomerTelephone);
            Assert.AreNotEqual(Error, "");
        }



        //CustomerLastName Validation Tests


        [TestMethod]
        public void CustomerLastNameMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerLastName = "";
            Error = ACustomer.Valid(Username, CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress, CustomerTelephone);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerLastName = "a";
            Error = ACustomer.Valid(Username, CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress, CustomerTelephone);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerLastName = "aa";
            Error = ACustomer.Valid(Username, CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress, CustomerTelephone);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerLastName = "aaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(Username, CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress, CustomerTelephone);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerLastName = "aaaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(Username, CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress, CustomerTelephone);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerLastName = "aaaaaaaaaaa";
            Error = ACustomer.Valid(Username, CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress, CustomerTelephone);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerLastName = "aaaaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(Username, CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress, CustomerTelephone);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerLastName = "";
            CustomerLastName = CustomerLastName.PadRight(500, 'a');//500 characters, should fail
            Error = ACustomer.Valid(Username, CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress, CustomerTelephone);
            Assert.AreNotEqual(Error, "");
        }


        //CustomerEmail Validation Tests



        [TestMethod]
        public void CustomerEmailMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerEmail = "";
            Error = ACustomer.Valid(Username, CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress, CustomerTelephone);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerEmail = "a";
            Error = ACustomer.Valid(Username, CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress, CustomerTelephone);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerEmail = "aa";
            Error = ACustomer.Valid(Username, CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress, CustomerTelephone);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerEmail = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(Username, CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress, CustomerTelephone);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerEmail = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(Username, CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress, CustomerTelephone);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerEmail = "aaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(Username, CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress, CustomerTelephone);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerEmail = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(Username, CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress, CustomerTelephone);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(500, 'a');//500 characters, should fail
            Error = ACustomer.Valid(Username, CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress, CustomerTelephone);
            Assert.AreNotEqual(Error, "");
        }




        //CustomerAddress Validation Tests




        [TestMethod]
        public void CustomerAddressMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerAddress = "";
            Error = ACustomer.Valid(Username, CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress, CustomerTelephone);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerAddress = "a";
            Error = ACustomer.Valid(Username, CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress, CustomerTelephone);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerAddress = "aa";
            Error = ACustomer.Valid(Username, CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress, CustomerTelephone);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerAddress = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(Username, CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress, CustomerTelephone);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerAddress = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(Username, CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress, CustomerTelephone);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerAddress = "aaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(Username, CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress, CustomerTelephone);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerAddress = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(Username, CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress, CustomerTelephone);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(500, 'a');//500 characters, should fail
            Error = ACustomer.Valid(Username, CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress, CustomerTelephone);
            Assert.AreNotEqual(Error, "");
        }




        //CustomerTelephone Validation Tests




        [TestMethod]
        public void CustomerTelephoneMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerTelephone = "";
            Error = ACustomer.Valid(Username, CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress, CustomerTelephone);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerTelephoneMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerTelephone = "a";
            Error = ACustomer.Valid(Username, CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress, CustomerTelephone);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerTelephoneMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerTelephone = "aa";
            Error = ACustomer.Valid(Username, CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress, CustomerTelephone);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerTelephoneMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerTelephone = "aaaaaaaaaaa";
            Error = ACustomer.Valid(Username, CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress, CustomerTelephone);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerTelephoneMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerTelephone = "aaaaaaaaaaaa";
            Error = ACustomer.Valid(Username, CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress, CustomerTelephone);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerTelephoneMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerTelephone = "aaaaaa";
            Error = ACustomer.Valid(Username, CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress, CustomerTelephone);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerTelephoneMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerTelephone = "aaaaaaaaaaaaa";
            Error = ACustomer.Valid(Username, CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress, CustomerTelephone);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerTelephoneExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerTelephone = "";
            CustomerTelephone = CustomerTelephone.PadRight(500, 'a');//500 characters, should fail
            Error = ACustomer.Valid(Username, CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress, CustomerTelephone);
            Assert.AreNotEqual(Error, "");
        }
    }
}




