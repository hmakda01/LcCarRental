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
            TestItem.StaffId = 1;
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
        public void ThisStaffPropertyOK()
        {
            //cretae an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test dat to assign to the property
            clsStaff TestStaff = new clsStaff();
            //set its properties of the test object
            TestStaff.StaffId = 1;
            TestStaff.StaffFirstName = "John";
            TestStaff.StaffLastName = "Smith";
            TestStaff.StaffEmail = "JohnSmith@hotmail.com";
            TestStaff.StaffTelephone = 01163480420;
            TestStaff.StaffDateOfBirth = DateTime.Now.Date;
            //assign the data to the property
            AllStaff.ThisStaff = TestStaff;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);

        }

        [TestMethod]
        public void AddMethodOk()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //cretae the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //tets it properties
            //set its properties
            //TestItem.StaffId = 7;
            TestItem.StaffFirstName = "Eden";
            TestItem.StaffLastName = "Hazard";
            TestItem.StaffEmail = "hazard@hotmail.com";
            TestItem.StaffTelephone = 01164497370;
            TestItem.StaffDateOfBirth = DateTime.Now.Date;
            //set thr staff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key tpo the dtaa
            TestItem.StaffId = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //TEST TO SEE IF THE TWO VLAUES ARE THE SAME 
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOk()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //cretae the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //tets it properties
            //set its properties
           // TestItem.StaffId = 8;
            TestItem.StaffFirstName = "Callum";
            TestItem.StaffLastName = "Odoi";
            TestItem.StaffEmail = "Callum@hotmail.com";
            TestItem.StaffTelephone = 01167593271;
            TestItem.StaffDateOfBirth = DateTime.Now.Date;
            //set thr staff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key tpo the dtaa
            TestItem.StaffId = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //delete the record
            AllStaff.Delete();
            //nw ind the ecord
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            //TEST TO SEEthat the reocrd is found
            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void UpdateMethodOk()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //cretae the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //tets it properties
            //set its properties
           // TestItem.StaffId = 11;
            TestItem.StaffFirstName = "Callum";
            TestItem.StaffLastName = "Odoi";
            TestItem.StaffEmail = "Callum@hotmail.com";
            TestItem.StaffTelephone = 01167593271;
            TestItem.StaffDateOfBirth = DateTime.Now.Date;
            //set thr staff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key tpo the dtaa
            TestItem.StaffId = PrimaryKey;
            //mdidfy te records
            //set its properties
           // TestItem.StaffId = 10;
            TestItem.StaffFirstName = "Mason";
            TestItem.StaffLastName = "Mount";
            TestItem.StaffEmail = "2MM@hotmail.com";
            TestItem.StaffTelephone = 01167653272;
            TestItem.StaffDateOfBirth = DateTime.Now.Date;
            //set thr staff to the test data
            AllStaff.ThisStaff = TestItem;
            //delete the record
            AllStaff.Update();
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //TEST TO SEEthat the reocrd is found
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);

        }

        [TestMethod]

        public void ReportByStaffFirstName()
        {
            //create an intance of the class contsining unfiltered results
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a blank string (should return all records)
            FilteredStaff.ReportByStaffFirstName("");
            //test to see that are tewo values are the same
            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);
        }


        [TestMethod]

        public void ReportByStaffFirstNameNoneFound()
        {
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a blank string (should return all records)
            FilteredStaff.ReportByStaffFirstName("xxxxxxx");
            //test to see that are tewo values are the same
            Assert.AreEqual(0, FilteredStaff.Count);
        }


        [TestMethod]

        public void ReportByStaffFirstNameTestDataFound()
        {
            //create an intance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //var to store outcome
            Boolean OK = true;
            //apply the fisrtname 
            FilteredStaff.ReportByStaffFirstName("Callum");
            //check the correct the number found 
            if (FilteredStaff.Count == 2)
            {
                //check the firsdt record is id 1
                if (FilteredStaff.StaffList[0].StaffId != 8)
                {
                    OK = false;
                }
                //check the first id is 2
                if (FilteredStaff.StaffList[1].StaffId != 11)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);

        }


    }

     





    
}
