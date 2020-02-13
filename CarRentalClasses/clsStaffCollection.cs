using System.Collections.Generic;
using System;


namespace CarRentalClasses
{
    public class clsStaffCollection
    {
        public List<clsStaff> ThisStaff { get; set; }


        private List<clsStaff> mStaffList = new List<clsStaff>();

        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }


        //public property for cout
        public int Count
        {
            get
            {
                //return the count list
                return mStaffList.Count;
            }
            set
            {
                //later
            }
        }

        public clsStaffCollection()
        {
            //ceate an instance of the county
            clsStaff TestItem = new clsStaff();
            //set the county to leicesterhsire
            TestItem.StaffFirstName = "Smith";
            TestItem.StaffLastName = "John";
            TestItem.StaffEmail = "";
            TestItem.StaffTelephone = 01163480420;
            TestItem.StaffDateOfBirth = DateTime.Now.Date;
            //add the county to the private list
            mStaffList.Add(TestItem);
            //re initilise
            TestItem = new clsStaff();
            //SET the 
            TestItem.StaffFirstName = "Ben";
            TestItem.StaffLastName = "King";
            TestItem.StaffEmail = "";
            TestItem.StaffTelephone = 01163480543;
            TestItem.StaffDateOfBirth = DateTime.Now.Date;
            //add the second county to the list
            mStaffList.Add(TestItem);
            //the privat elist  now cntains two counties

        }


    }
}