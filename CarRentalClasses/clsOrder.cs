using System;

namespace CarRentalClasses
{
    public class clsOrder
    {
        public int CarReg { get; set; }
        public int CustomerID { get; set; }
        public int OrderID { get; set; }
        public int StaffID { get; set; }
        public DateTime DateAdded { get; set; }
        public string Email { get; set; }
        public int Price { get; set; }
    }
}