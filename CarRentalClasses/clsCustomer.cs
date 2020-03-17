using System;

namespace CarRentalClasses
{
    public class clsCustomer
    {
        public int CustomerID;
        public string Username;
        public string CustomerFirstName;
        public string CustomerLastName;
        public string CustomerAddress;
        public string CustomerEmail;
        public string CustomerTelephone;


        public bool Active { get; set; }


        public bool Find(int primaryKey)
        {
            throw new NotImplementedException();
        }

        public string Valid(string text1, string text2, string text3, string text4, string text5, string text6)
        {
            throw new NotImplementedException();
        }
    }
}