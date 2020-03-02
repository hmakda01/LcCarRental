using System;
using System.Collections.Generic;



namespace CarRentalClasses
{
    public class clsStaffCollection
    {

        List<clsStaff> mStaffList = new List<clsStaff>();
        //public List<clsStaff> ThisStaff { get; set; }
        clsStaff mThisStaff = new clsStaff();

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

        public clsStaff ThisStaff
        {
            get
            {
                return mThisStaff;
            }
            set
            {
                mThisStaff = value;
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
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //exevute the stored procudure
            DB.Execute("sproc_tblStaff_SelectAll");
            //popoulate the array list
            PopulateArray(DB);
           
        }

        public int Add()
        {
            //adds a  new reocrd to the databse
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the stroed procudure
           // DB.AddParameter("StaffId", mThisStaff.StaffId);
            DB.AddParameter("StaffFirstName", mThisStaff.StaffFirstName);
            DB.AddParameter("StaffLastName", mThisStaff.StaffLastName);
            DB.AddParameter("StaffEmail", mThisStaff.StaffEmail);
            DB.AddParameter("StaffTelephone", mThisStaff.StaffTelephone);
            DB.AddParameter("StaffDateOfBirth", mThisStaff.StaffDateOfBirth);
            //execute the qeury
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Delete()
        {
            //deleted the record pointed to by ThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the paramerers for the stored rocudure
            DB.AddParameter("@StaffId", mThisStaff.StaffId);
            //execute the stored procudure
            DB.Execute("sproc_tblStaff_Delete");


        }

        public void Update()
        {
            //updates a xisting reocrd to the databse
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the stroed procudure
            DB.AddParameter("StaffId", mThisStaff.StaffId);
            DB.AddParameter("StaffFirstName", mThisStaff.StaffFirstName);
            DB.AddParameter("StaffLastName", mThisStaff.StaffLastName);
            DB.AddParameter("StaffEmail", mThisStaff.StaffEmail);
            DB.AddParameter("StaffTelephone", mThisStaff.StaffTelephone);
            DB.AddParameter("StaffDateOfBirth", mThisStaff.StaffDateOfBirth);
            //execute the qeury
            DB.Execute("sproc_tblStaff_Update");
        }

        public void ReportByStaffFirstName(string StaffFirstName)
        {
            //filters the record based on a full or partial fisrtname
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //send the name parameter to the database
            DB.AddParameter("@StaffFirstName", StaffFirstName);
            //execute the styored procudure 
            DB.Execute("sproc_tblStaff_FilterByStaffFirstName");
            //popoulate the array list with the table
            PopulateArray(DB);
        }


        void PopulateArray(clsDataConnection DB)    
        {
            //VAR FOR THE INDEX
            Int32 Index = 0;
            //var to store the rrdeord count
            Int32 RecordCount = 0;
            //object for data connection
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mStaffList = new List<clsStaff>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //cretae a blank staff
                clsStaff AnStaff = new clsStaff();
                //read in fields form the current record
                AnStaff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                AnStaff.StaffFirstName = Convert.ToString(DB.DataTable.Rows[Index]["StaffFirstName"]);
                AnStaff.StaffLastName = Convert.ToString(DB.DataTable.Rows[Index]["StaffLastName"]);
                AnStaff.StaffEmail = Convert.ToString(DB.DataTable.Rows[Index]["StaffEmail"]);
                AnStaff.StaffTelephone = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffTelephone"]);
                AnStaff.StaffDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["StaffDateOfBirth"]);
                //add the record to the private data memeber
                mStaffList.Add(AnStaff);
                //POINT AT the next index
                Index++;
            }
        }






    }
}