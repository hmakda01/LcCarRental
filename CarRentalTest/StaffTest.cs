using System;
using CarRentalClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CarRentalTest
{
    [TestClass]
    public class StaffTest
    {

        ////good test data
        ////create some test data

        string StaffFirstName = "John";
        string StaffLastName = "smith";
        string StaffEmail = "hfhggfh";
        string StaffTelephone = "01163480420";
        string StaffDateOfBirth = DateTime.Now.Date.ToString();


        [TestMethod]
        public void InstanceOk()
        {
            clsStaff AStaff = new clsStaff();
            //testt to see if it works
            Assert.IsNotNull(AStaff);
        }


        [TestMethod]
        public void StaffId()
        {
            clsStaff AStaff = new clsStaff();
            Int32 TestData = 1;
            //assgn the data to the property
            AStaff.StaffId = TestData;
            //applythe test
            Assert.AreEqual(AStaff.StaffId, TestData);
        }

        [TestMethod]
        public void StaffFirstNameOK()
        {
            clsStaff AStaff = new clsStaff();
            //create some tests data
            string TestData = "John";
            //assign the data to the property
            AStaff.StaffFirstName = TestData;
            //test tpos ee if it works
            Assert.AreEqual(AStaff.StaffFirstName, TestData);
        }

        [TestMethod]
        public void StaffLastNameOK()
        {
            clsStaff AStaff = new clsStaff();
            //create some tests data
            string TestData = "smith";
            //assign the data to the property
            AStaff.StaffLastName = TestData;
            //test tpos ee if it works
            Assert.AreEqual(AStaff.StaffLastName, TestData);
        }

        [TestMethod]
        public void StaffEmailOK()
        {
            clsStaff AStaff = new clsStaff();
            //create some tests data
            string TestData = "hfhggfh";
            //assign the data to the property
            AStaff.StaffEmail = TestData;
            //test tpos ee if it works
            Assert.AreEqual(AStaff.StaffEmail, TestData);
        }

        [TestMethod]
        public void StaffTelephoneOK()
        {
            clsStaff AStaff = new clsStaff();
            Int32 TestData = 01163480420;
            //assgn the data to the property
            AStaff.StaffTelephone = TestData;
            //applythe test
            Assert.AreEqual(AStaff.StaffTelephone, TestData);
        }

        [TestMethod]
        public void StaffDateOfBirthOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AStaff.StaffDateOfBirth = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffDateOfBirth, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an intance of the class
            clsStaff AStaff = new clsStaff();
            //boolean varaubel ti stroe thge result of the validation
            Boolean Found = false;
            //create some test data to use
            Int32 StaffId = 19;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //test to see if the result is ok
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffIdFound()
        {
            //create an intance of the class
            clsStaff AStaff = new clsStaff();
            //boolean varaubel ti stroe thge result of the validation
            Boolean Found = false;
            //boolea variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 19;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the staffid
            if (AStaff.StaffId != 19)
            {
                OK = false;
            }
            //test to see if tis ok
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestStaffFirstNameFound()
        {
            //create an intance of the class
            clsStaff AStaff = new clsStaff();
            //boolean varaubel ti stroe thge result of the validation
            Boolean Found = false;
            //boolea variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 19;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the staffid
            if (AStaff.StaffFirstName !=  "Test FirstName")
            {
                OK = false;
            }
            //test to see if tis ok
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestStaffLastNameFound()
        {
            //create an intance of the class
            clsStaff AStaff = new clsStaff();
            //boolean varaubel ti stroe thge result of the validation
            Boolean Found = false;
            //boolea variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 19;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the staffid
            if (AStaff.StaffLastName != "Test LastName")
            {
                OK = false;
            }
            //test to see if tis ok
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestStaffEmailFound()
        {
            //create an intance of the class
            clsStaff AStaff = new clsStaff();
            //boolean varaubel ti stroe thge result of the validation
            Boolean Found = false;
            //boolea variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 19;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the staffid
            if (AStaff.StaffEmail != "Test email")
            {
                OK = false;
            }
            //test to see if tis ok
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestStaffTelephoneFound()
        {
            //create an intance of the class
            clsStaff AStaff = new clsStaff();
            //boolean varaubel ti stroe thge result of the validation
            Boolean Found = false;
            //boolea variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 19;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the staffid
            if (AStaff.StaffTelephone != 0116354763)
            {
                OK = false;
            }
            //test to see if tis ok
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestStaffDateOfBirthFound()
        {
            //create an intance of the class
            clsStaff AStaff = new clsStaff();
            //boolean varaubel ti stroe thge result of the validation
            Boolean Found = false;
            //boolea variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 19;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the staffid
            if (AStaff.StaffDateOfBirth != Convert.ToDateTime("16/09/1998"))
            {
                OK = false;
            }
            //test to see if tis ok
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void StaffFirstNameMinBoundary()
        {
            //cretae an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create astring variable to store it
            String Error = "";
            //create some test dat
            string StaffFirstName = "a";
            //invoke the methoid
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffTelephone, StaffDateOfBirth);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameMinPlusOne()
        {
            //cretae an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string StaffFirstName = "aa";
            //invoke the methoid
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffTelephone, StaffDateOfBirth);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameMaxLessOne()
        {
            //cretae an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string StaffFirstName = "kkkkkkkkkkkkkkkkkkkkkkkkk";
            //invoke the methoid
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffTelephone, StaffDateOfBirth);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameMaxPlusOne()
        {
            //cretae an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string StaffFirstName = "oooooooooooooooooooooooooo";
            //invoke the methoid
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffTelephone, StaffDateOfBirth);
            //tets tosee if the result is no ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameMid()
        {
            //cretae an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string StaffFirstName = "0123456789";
            //invoke the methoid
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffTelephone, StaffDateOfBirth);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameExtremeMax()
        {
            //cretae an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string StaffFirstName = "";
            //pad the string with chracters
            StaffFirstName = StaffFirstName.PadRight(500, 'a');
            //invoke the methoid
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffTelephone, StaffDateOfBirth);
            //tets tosee if the result is not  ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffLastNameMinLessOne()
        {
            //cretae an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create astring variable to store it
            String Error = "";
            //create some test dat
            string StaffLastName = "aaaaaaaaaaaaaaaaaa";
            //invoke the methoid
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffTelephone, StaffDateOfBirth);
            //tets tosee if the result is not ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffLastNameMinBoundary()
        {
            //cretae an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create astring variable to store it
            String Error = "";
            //create some test dat
            string StaffLastName = "a";
            //invoke the methoid
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffTelephone, StaffDateOfBirth);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffLastNameMinPlusOne()
        {
            //cretae an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string StaffLastName = "aa";
            //invoke the methoid
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffTelephone, StaffDateOfBirth);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffLastNameMaxLessOne()
        {
            //cretae an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string StaffLastName = "kkkkkkkkkkkkkkkkkkkkkkkkk";
            //invoke the methoid
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffTelephone, StaffDateOfBirth);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffLastNameMaxPlusOne()
        {
            //cretae an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string StaffLastName = "oooooooooooooooooooooooooo";
            //invoke the methoid
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffTelephone, StaffDateOfBirth);
            //tets tosee if the result is no ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffLastNameMid()
        {
            //cretae an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string StaffLastName = "0123456789";
            //invoke the methoid
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffTelephone, StaffDateOfBirth);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffLastNameExtremeMax()
        {
            //cretae an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string StaffLastName = "";
            //pad the string with chracters
            StaffLastName = StaffLastName.PadRight(500, 'a');
            //invoke the methoid
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffTelephone, StaffDateOfBirth);
            //tets tosee if the result is not  ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMinBoundary()
        {
            //cretae an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create astring variable to store it
            String Error = "";
            //create some test dat
            string StaffEmail = "a";
            //invoke the methoid
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffTelephone, StaffDateOfBirth);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMinPlusOne()
        {
            //cretae an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string StaffEmail = "aa";
            //invoke the methoid
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffTelephone, StaffDateOfBirth);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMaxLessOne()
        {
            //cretae an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string StaffEmail = "kkkkkkkkkkkkkkkkkkkkkkkk";
            //invoke the methoid
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffTelephone, StaffDateOfBirth);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmaiMaxPlusOne()
        {
            //cretae an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string StaffEmail = "llllllllllllllllllllllllllllllllllllllllllllllllll111";
            //invoke the methoid
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffTelephone, StaffDateOfBirth);
            //tets tosee if the result is no ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMid()
        {
            //cretae an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string StaffEmail = "0123456@789";
            //invoke the methoid
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffTelephone, StaffDateOfBirth);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailExtremeMax()
        {
            //cretae an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string StaffEmail = "";
            //pad the string with chracters
            StaffEmail = StaffEmail.PadRight(500, 'a');
            //invoke the methoid
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffTelephone, StaffDateOfBirth);
            //tets tosee if the result is not  ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffTelephoneMinBoundary()
        {
            //cretae an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create astring variable to store it
            String Error = "";
            //create some test dat
            string StaffTelephone = "4";
            //invoke the methoid
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffTelephone, StaffDateOfBirth);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffTelephoneMinPlusOne()
        {
            //cretae an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string StaffTelephone = "22";
            //invoke the methoid
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffTelephone, StaffDateOfBirth);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffTelephoneNameMaxLessOne()
        {
            //cretae an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string StaffTelephone = "011654325464643782349876";
            //invoke the methoid
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffTelephone, StaffDateOfBirth);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffTelephoneMaxPlusOne()
        {
            //cretae an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string StaffTelephone = "01165432546464378234987654";
            //invoke the methoid
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffTelephone, StaffDateOfBirth);
            //tets tosee if the result is no ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffTelephoneMid()
        {
            //cretae an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string StaffTelephone = "0123456789";
            //invoke the methoid
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffTelephone, StaffDateOfBirth);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffTelephoneExtremeMax()
        {
            //cretae an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string StaffTelephone = "";
            //pad the string with chracters
            StaffTelephone = StaffTelephone.PadRight(500, 'a');
            //invoke the methoid
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffTelephone, StaffDateOfBirth);
            //tets tosee if the result is not  ok
            Assert.AreNotEqual(Error, "");
        }






        [TestMethod]
        public void DateOfBirthExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string StaffDateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffTelephone, StaffDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        //[TestMethod]
        //public void DateOfBirthMinLessOne()
        //{
        //    //create an instance of the class we want to create
        //    clsStaff AStaff = new clsStaff();
        //    //string variable to store any error message
        //    String Error = "";
        //    //create a variable to store the test date data
        //    DateTime TestDate;
        //    //set the date totodays date
        //    TestDate = DateTime.Now.Date;
        //    //change the date to whatever the date is less 1 day
        //    TestDate = TestDate.AddDays(-100);
        //    //convert the date variable to a string variable
        //    string StaffDateOfBirth = TestDate.ToString();
        //    //invoke the method
        //    Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffTelephone, StaffDateOfBirth);
        //    //test to see that the result is correct
        //    Assert.AreNotEqual(Error, "");
        //}

        [TestMethod]
        public void DateOfBirthMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string StaffDateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffTelephone, StaffDateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateOfBirthMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string StaffDateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffTelephone, StaffDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string StaffDateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffTelephone, StaffDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthInvalidData()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //convert the date variable to a string variable
            string StaffDateOfBirth = "this is not a date!";
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffTelephone, StaffDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

    }
}
