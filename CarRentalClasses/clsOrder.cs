using System;

namespace CarRentalClasses
{
    public class clsOrder
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public int CarID { get; set; }
        public int CustomerID { get; set; }
        public int OrderID { get; set; }
        public int StaffID { get; set; }
        public string Email { get; set; }
        public int Price { get; set; }

        public bool Find(int primaryKey)
        {
            throw new NotImplementedException();
        }

        public string Valid(string text1, string text2, string text3, string text4, string text5, string text6, string text7)
        {
            throw new NotImplementedException();
        }
    }
}