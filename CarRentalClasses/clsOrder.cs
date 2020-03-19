using System;


namespace CarRentalClasses
{
    public class clsOrder
    {
        //private data member for the OrderID property
        private Int32 mOrderID;
        private DateTime mDate;
        private Int32 mCarID;
        private Int32 mCustomerID;
        private Int32 mStaffID;
        private string mEmail;
        private Int32 mPrice;


        public int OrderID
        {
            get
            {
                return mOrderID;

            }
            set
            {
                mOrderID = value;

            }

        }

        public int CustomerID
        {
            get
            {
                return mCustomerID;

            }
            set
            {
                mCustomerID = value;

            }
        }

        public int StaffID
        {
            get
            {
                return mStaffID;

            }
            set
            {
                mStaffID = value;

            }
        }

        public int CarID
        {
            get
            {
                return mCarID;

            }
            set
            {
                mCarID = value;

            }
        }

        public DateTime Date
        {
            get
            {
                return mDate;

            }
            set
            {
                mDate = value;

            }
        }
        public string Email
        {
            get
            {
                return mEmail;

            }
            set
            {
                mEmail = value;

            }
        }

        public int Price
        {
            get
            {
                return mPrice;

            }
            set
            {
                mPrice = value;

            }
        }

        //public DateTime DateAdded { get; set; }
        //public int CarID { get; set; }
        //public int CustomerID { get; set; }
        //public int OrderID { get; set; }
        //public int StaffID { get; set; }
        // public string Email { get; set; }
        //public int Price { get; set; }

        public bool Find(int OrderID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", OrderID);
            DB.Execute("sproc_tblOrder_FilterByOrderID");
            if (DB.Count == 1)
            {
                //set the private data member to the test data value
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mCarID = Convert.ToInt32(DB.DataTable.Rows[0]["CarID"]);
                mDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Date"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mPrice = Convert.ToInt32(DB.DataTable.Rows[0]["Price"]);
                //return everything that worked ok
                return true;
            }
            //if no record found
            else
            {
                //return false indicating a problem)
                return false;
            }
        }

        public string Valid(string date, string email, string price)
        {
            //create a string variable to store the error
            String Error = "";
            DateTime DateTemp;
            //if the OrderID is blank
            if (email.Length == 0)
            {
                //Record the Error
                Error = Error + "The email may not be blank : ";
            }
            
            try
            {
                //copy the date value to the DateTemp variable
                DateTemp = Convert.ToDateTime(date);
                DateTime minDate = new DateTime(2000, 01, 01);
                DateTime maxDate = DateTime.Today;
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past : ";
                }
                if (DateTemp < minDate || DateTemp > maxDate)
                { //record the error

                    Error = Error + "The date cannot be in the future : " + maxDate;
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date : ";
            }

            if ( price.Length == 0 )
            {
                Error = Error + "The price may not be blank : ";
            }
            //if price has too many characters
            if (price.Length > 6)
            {
                Error = Error + "The price must be less than 6 characters : ";
            }
            
            

            return Error;




        }
    }

}

