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

        public string Valid(string staffFirstName, string staffLastName, string staffEmail, string staffTelephone, string staffDateOfBirth)
        {
            //string variable to store error message
            String Error = "";

            DateTime DateTemp;

            //if the name of the staffis not blank
            if (staffFirstName.Length == 0)
            {
                //return an error message
                Error = "the name may not be blank";
            }
            if (staffFirstName.Length > 25)
            {
                //error
                Error = Error + "The staff name cannot have more than 25 characters ";
            }
            if (staffLastName.Length == 0)
            {
                //return an error message
                Error = "the name may not be blank";
            }
            if (staffLastName.Length > 25)
            {
                //error
                Error = Error + "The staff name cannot have more than 25 characters ";
            }

            if (staffEmail.Length == 0)
            {
                //return an error message
                Error = "the name may not be blank";
            }
            if (staffEmail.Length > 50)
            {
                //error
                Error = Error + "The staffemail cannot have more than 50 characters ";
            }
            //if the name of the staffis not blank
            if (staffTelephone.Length == 0)
            {
                //return an error message
                Error = "the name may not be blank";
            }
            if (staffTelephone.Length > 25)
            {
                //error
                Error = Error + "The staff name cannot have more than 25 characters ";
            }


            //try
            //{
            //    DateTemp = Convert.ToDateTime(staffDateOfBirth);

            //    if (DateTemp < DateTime.Now.Date)

            //    {
            //        //record the error
            //        Error = Error + "The date cannot be in the past : ";

            //    }

            //    //check to see if the date is greater than today's date

            //    if (DateTemp > DateTime.Now.Date)

            //    {
            //        //record the error
            //        Error = Error + "The date cannot be in the future : ";

            //    }
            //}
            //catch
            //{
            //    //record the error
            //    Error = Error + "The date was not a valid date : ";
            //}

            return Error;
        }
    }
}