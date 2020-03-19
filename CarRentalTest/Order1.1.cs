using System;
using CarRentalClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CarRentalTest
{
    [TestClass]
    public class Order1
    {

        string Date = DateTime.Now.Date.ToString();
        string Email = "xxxxx@xxxxxxxxxxxx";
        string Price = "1";

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
        public void DatePropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            AnOrder.Date = TestData;
            Assert.AreEqual(AnOrder.Date, TestData);
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

        [TestMethod]

        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with method
            Int32 OrderID = 4;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //test to see that the result is correct
            Assert.IsTrue(Found);

        }

        [TestMethod]


        public void TestOrderIDFound()
        {
            //Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 1;
            //Invoke the method
            Found = AnOrder.Find(OrderID);
            //check the Order Id
            if (AnOrder.OrderID != 1)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]


        public void TestCustomerIDFound()
        {
            //Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 1;
            //Invoke the method
            Found = AnOrder.Find(OrderID);
            //check the Order Id
            if (AnOrder.CustomerID != 2)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]


        public void TestStaffIDFound()
        {
            //Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 1;
            //Invoke the method
            Found = AnOrder.Find(OrderID);
            //check the Order Id
            if (AnOrder.StaffID != 2)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]


        public void TestCarIDFound()
        {
            //Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 1;
            //Invoke the method
            Found = AnOrder.Find(OrderID);
            //check the Order Id
            if (AnOrder.CarID != 2)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]


        public void TestDateFound()
        {
            //Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 2;
            //Invoke the method
            Found = AnOrder.Find(OrderID);
            //check the Order Id
            if (AnOrder.Date != Convert.ToDateTime("19/03/2020"))

            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]


        public void TestEmailFound()
        {
            //Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 1;
            //Invoke the method
            Found = AnOrder.Find(OrderID);
            //check the Order Id
            if (AnOrder.Email != "hm@hotmail.co.uk")
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]


        public void TestPriceFound()
        {
            //Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 1;
            //Invoke the method
            Found = AnOrder.Find(OrderID);
            //check the Order Id
            if (AnOrder.Price != 67)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //invoke the method
            Error = AnOrder.Valid(Date, Email, Price);
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void EmailMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            //create some data to pass this method
            string Email = "a";
            //invoke the method
            Error = AnOrder.Valid(Date, Email, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some data to pass this method
            string Email = "a";
            //invoke the method
            Error = AnOrder.Valid(Date, Email, Price);
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void EmailMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some data to pass this method
            string Email = "a";
            //invoke the method
            Error = AnOrder.Valid(Date, Email, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some data to pass this method
            string Email = "a";
            //invoke the method
            Error = AnOrder.Valid(Date, Email, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            //create some data to pass this method
            string Email = ""; //should trigger an error
            //invoke the method
            Error = AnOrder.Valid(Date, Email, Price);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void DateExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variale to store the test date data
            DateTime TestDate;
            //change the date to whatever the data is less 100 years ago
            TestDate = DateTime.Now.Date;
            //convert the date variable to a srting variable 
            TestDate = TestDate.AddYears(-100);
            //convert the date vairable to a string method
            string Date = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(Date, Email, Price);
            //test to see if result is correct 
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void DateMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variale to store the test date data
            DateTime TestDate;
            //change the date to whatever the data is less 100 years ago
            TestDate = DateTime.Now.Date;
            //convert the date variable to a srting variable 
            TestDate = TestDate.AddYears(-100);
            //convert the date vairable to a string method
            string Date = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(Date, Email, Price);
            //test to see if result is correct 
            Assert.AreNotEqual(Error, "");

        }
        //[TestMethod]
        //public void DateMin()
        //{
        //    //create an instance of the class we want to create
        //    clsOrder AnOrder = new clsOrder();
        //    //string variable to store any error message
        //    String Error = "";
        //    //create a variale to store the test date data
        //    DateTime TestDate;
        //    //change the date to whatever the data is less 100 years ago
        //    TestDate = DateTime.Now.Date;
        //    //convert the date variable to a srting variable 
        //    TestDate = TestDate.AddYears(-100);
        //    //convert the date vairable to a string method
        //    string Date = TestDate.ToString();
        //    //invoke the method
        //    Error = AnOrder.Valid(Date, Email, Price);
        //    //test to see if result is correct 
        //    Assert.AreEqual(Error, "");

        //}
        [TestMethod]
        public void DateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variale to store the test date data
            DateTime TestDate;
            //change the date to whatever the data is less 100 years ago
            TestDate = DateTime.Now.Date;
            //convert the date variable to a srting variable 
            TestDate = TestDate.AddYears(-100);
            //convert the date vairable to a string method
            string Date = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(Date, Email, Price);
            //test to see if result is correct 
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void DateExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variale to store the test date data
            DateTime TestDate;
            //change the date to whatever the data is less 100 years ago
            TestDate = DateTime.Now.Date;
            //convert the date variable to a srting variable 
            TestDate = TestDate.AddYears(-100);
            //convert the date vairable to a string method
            string Date = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(Date, Email, Price);
            //test to see if result is correct 
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateInvalidData()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //set the date to a non date value
            string Date = "This is not a date";
            //invoke the method
            Error = AnOrder.Valid(Date, Email, Price);
            //test to see if result is correct 
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void PriceMinLessOne()
        {
            //create instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            //this should fail
            string Price = ""; //should trigger an error
            //invoke the method
            Error = AnOrder.Valid(Date, Email, Price);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMin()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //string variable to any error message
            String Error = "";
            //this should pass
            string Price = "hhhhh"; //should trigger an error
            //invoke the method
            Error = AnOrder.Valid(Date, Email, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //string variable to any error message
            String Error = "";
            //this should pass
            string Price = "";
            //invoke the method
            Error = AnOrder.Valid(Date, Email, Price);
            //Test to see if the reuslt if correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMaxLessOne()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //string variable to any error message
            String Error = "";
            //this should pass
            string Price = "";
            //invoke the method
            Error = AnOrder.Valid(Date, Email, Price);
            //Test to see if the reuslt if correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMax()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //string variable to any error message
            String Error = "";
            //this should pass
            string Price = "";
            //invoke the method
            Error = AnOrder.Valid(Date, Email, Price);
            //Test to see if the reuslt if correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMaxPlusOne()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //string variable to any error message
            String Error = "";
            //this should pass
            string Price = "";
            //invoke the method
            Error = AnOrder.Valid(Date, Email, Price);
            //Test to see if the reuslt if correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMid()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //string variable to any error message
            String Error = "";
            //this should pass
            string Price = "";
            //invoke the method
            Error = AnOrder.Valid(Date, Email, Price);
            //Test to see if the reuslt if correct
            Assert.AreNotEqual(Error, "");
        }






    }

}

