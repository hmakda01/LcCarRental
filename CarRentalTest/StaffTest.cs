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

        


    }
}
