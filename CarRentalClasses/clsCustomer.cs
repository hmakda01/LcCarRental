using System;

namespace CarRentalClasses
{
    public class clsCustomer
    {

        private Int32 mCustomerID;
        private string mUsername;
        private string mCustomerFirstName;
        private string mCustomerLastName;
        private string mCustomerEmail;
        private string mCustomerAddress;
        private string mCustomerTelephone;



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
        public string Username
        {
            get
            {
                return mUsername;
            }
            set
            {
                mUsername = value;
            }
        }
        public string CustomerFirstName
        {
            get
            {
                return mCustomerFirstName;
            }
            set
            {
                mCustomerLastName = value;
            }
        }
        public string CustomerLastName
        {
            get
            {
                return mCustomerLastName;
            }
            set
            {
                mCustomerLastName = value;
            }
        }
        public string CustomerAddress
        {
            get
            {
                return mCustomerAddress;
            }
            set
            {
                mCustomerAddress = value;
            }
        }
        public string CustomerEmail
        {
            get
            {
                return mCustomerEmail;
            }
            set
            {
                mCustomerEmail = value;
            }
        }
        public string CustomerTelephone
        {
            get
            {
                return mCustomerTelephone;
            }
            set
            {
                mCustomerTelephone = value;
            }
        }



        public bool Active { get; set; }


        public bool Find(int CustomerID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", CustomerID);
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            if (DB.Count == 1)
            {
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mUsername = Convert.ToString(DB.DataTable.Rows[0]["Username"]);
                mCustomerFirstName = Convert.ToString(DB.DataTable.Rows[0]["CustomerFirstName"]);
                mCustomerLastName = Convert.ToString(DB.DataTable.Rows[0]["CustomerLastName"]);
                mCustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerAddress"]); ;
                mCustomerAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]); ;
                mCustomerTelephone = Convert.ToString(DB.DataTable.Rows[0]["CustomerTelephone"]); ;
                return true;
            }
            else
            {
                return false;
            }
        }


        public string Valid(string username, string customerFirstName, string customerLastName, string customerEmail, string customerAddress, string customerTelephone)
        {
            String Error = "";
            if (username.Length == 0)
            {
                Error = Error + "The Username may not be blank: ";
            }
            return Error;
        }
        //page 17 week 24
        //page 17 week 24
        //page 17 week 24
        //page 17 week 24
        //page 17 week 24

    }
}