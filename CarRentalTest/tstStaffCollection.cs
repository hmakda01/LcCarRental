using System;
using CarRentalClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CarRentalTest
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //cretae an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test dat to assign to thwe property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add a item to the ;list
            //cretae the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.Active = true;
            TestItem.StaffFirstName = "John";
            TestItem.StaffLastName = "Smith";
            TestItem.StaffEmail = "";
            TestItem.StaffTelephone = 01163480420;
            TestItem.StaffDateOfBirth = DateTime.Now.Date;
            //ad the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);

        }
        
        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //cretae some test data to assign to the property
            Int32 someCount = 2;
            //assign the data to the property
            AllStaff.Count = someCount;
            //tets to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, someCount);
        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //cretae an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test dat to assign to thwe property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add a item to the ;list
            //cretae the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.Active = true;
            TestItem.StaffFirstName = "John";
            TestItem.StaffLastName = "Smith";
            TestItem.StaffEmail = "";
            TestItem.StaffTelephone = 01163480420;
            TestItem.StaffDateOfBirth = DateTime.Now.Date;
            //ad the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.ThisStaff = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestList);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //cretae an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test dat to assign to thwe property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add a item to the ;list
            //cretae the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.Active = true;
            TestItem.StaffFirstName = "John";
            TestItem.StaffLastName = "Smith";
            TestItem.StaffEmail = "";
            TestItem.StaffTelephone = 01163480420;
            TestItem.StaffDateOfBirth = DateTime.Now.Date;
            //ad the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);

        }

        [TestMethod]
        public void TwoRecordsPresent()
        {
            //create a instace
            clsStaffCollection AllStaff = new clsStaffCollection();
            //tets to see the two values are the ame
            Assert.AreEqual(AllStaff.Count, 2);
        }

    }
}
