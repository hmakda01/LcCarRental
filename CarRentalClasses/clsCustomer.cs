using System;

namespace CarRentalClasses
{
    public class clsCustomer
    {
        public string Username;
        public string CustomerFirstName;
        public string CustomerLastName;
        public string CustomerAddress;
        public string CustomerEmail;
        public string CustomerTelephone;

        public bool Active { get; set; }


        public void Find(int primaryKey)
        {
            throw new NotImplementedException();
        }
    }
}