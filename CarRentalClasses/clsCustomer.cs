using System;
using System.Text;
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
                mCustomerFirstName = value;
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
            DB.Execute("sproc_tblCustomer_FilterByCustomerIDNew");
            if (DB.Count == 1)
            {
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mUsername = Convert.ToString(DB.DataTable.Rows[0]["Username"]);
                mCustomerFirstName = Convert.ToString(DB.DataTable.Rows[0]["CustomerFirstName"]);
                mCustomerLastName = Convert.ToString(DB.DataTable.Rows[0]["CustomerLastName"]);
                mCustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]); 
                mCustomerAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerAddress"]); 
                mCustomerTelephone = Convert.ToString(DB.DataTable.Rows[0]["CustomerTelephone"]);

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
                Error = Error + "The Username may not be blank:  ";
            }
            if (username.Length > 20)
            {
                Error = Error + "The Username may not be more than 20 characters:  ";
            }
            if (customerFirstName.Length == 0)
            {
                Error = Error + "The First Name may not be blank:  ";
            }
            if (customerFirstName.Length > 20)
            {
                Error = Error + "The First Name may not be more than 20 characters:  ";
            }
            if (customerLastName.Length == 0)
            {
                Error = Error + "The Last Name may not be blank:  ";
            }
            if (customerLastName.Length > 20)
            {
                Error = Error + "The Last Name may not be more than 20 characters:  ";
            }
            if (customerEmail.Length == 0)
            {
                Error = Error + "The Email may not be blank:  ";
            }
            if (customerEmail.Length > 30)
            {
                Error = Error + "The Email may not be more than 30 characters:  ";
            }
            if (customerAddress.Length == 0)
            {
                Error = Error + "The Address may not be blank:  ";
            }
            if (customerAddress.Length > 40)
            {
                Error = Error + "The Address may not be more than 40 characters:  ";
            }
            if (customerTelephone.Length == 0)
            {
                Error = Error + "The Telephone may not be blank:  ";
            }
            if (customerTelephone.Length > 12)
            {
                Error = Error + "The Telephone may not be more than 12 characters:  ";
            }
            return Error;
       
        }

        //CustomerFirstName

    }
}