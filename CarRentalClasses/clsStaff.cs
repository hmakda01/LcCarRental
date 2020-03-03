using System;

namespace CarRentalClasses
{
    public class clsStaff
    {
        //private member
        private Int32 mStaffId;

        private String mStaffFirstName;
        private String mStaffLastName;
        private String mStaffEmail;
        private Int32 mStaffTelephone;
        private DateTime mStaffDateOfBirth;

        public int StaffId
        {
            get
            {
                return mStaffId;
            }
                
            set
            {
                //set the value of the data private data meber
                mStaffId = value;
            }
                
        }
        public string StaffFirstName
        {
            get
            {
                return mStaffFirstName;
            }
            set
            {
                mStaffFirstName = value;
            }
        }
        public string StaffLastName
        {
            get
            {
                return mStaffLastName;
            }
            set
            {
                mStaffLastName = value;
            }
        }
        public string StaffEmail
        {
            get
            {
                return mStaffEmail;
            }
            set
            {
                mStaffEmail = value;
            }
        }
        public int StaffTelephone
        {
            get
            {
                return mStaffTelephone;
            }
            set
            {
                mStaffTelephone = value;
            }
        }
        public DateTime StaffDateOfBirth
        {
            get
            {
                return mStaffDateOfBirth;
            }
            set
            {
                mStaffDateOfBirth = value;
            }
            
        }

        public bool Find(int StaffId)
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the paramerers for the stored rocudure
            DB.AddParameter("@StaffId", StaffId);
            //execute the stored procudure
            DB.Execute("sproc_tblStaff_FilterByStaffId");
            //if one record is found
            if (DB.Count == 1)
            {
                //set the private data member to the test data
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mStaffFirstName = Convert.ToString(DB.DataTable.Rows[0]["StaffFirstName"]);
                mStaffLastName = Convert.ToString(DB.DataTable.Rows[0]["StaffLastName"]);
                mStaffEmail = Convert.ToString(DB.DataTable.Rows[0]["StaffEmail"]);
                mStaffTelephone = Convert.ToInt32(DB.DataTable.Rows[0]["StaffTelephone"]);
                mStaffDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["StaffDateOfBirth"]);
                //always return true;
                return true;
            }
            //if no record is found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string text1, string text2, string text3, string text4, string text5, string text6)
        {
            string Error = "";
            return Error;
        }
    }
}