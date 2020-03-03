using System;
using CarRentalClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarRentalTest
{
    [TestClass]
    public class StaffTest
    {

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
        public void StaffFirstName()
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
        public void StaffLastName()
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
        public void StaffEmail()
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
        public void StaffTelephone()
        {
            clsStaff AStaff = new clsStaff();
            Int32 TestData = 01163480420;
            //assgn the data to the property
            AStaff.StaffTelephone = TestData;
            //applythe test
            Assert.AreEqual(AStaff.StaffTelephone, TestData);
        }

        [TestMethod]
        public void StaffDateOfBirth()
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


    }
}
