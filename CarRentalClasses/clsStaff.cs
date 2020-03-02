using System;

namespace CarRentalClasses
{
    public class clsStaff
    {
        public int StaffId { get; set; }
        public string StaffFirstName { get; set; }
        public string StaffLastName { get; set; }
        public string StaffEmail { get; set; }
        public int StaffTelephone { get; set; }
        public DateTime StaffDateOfBirth { get; set; }

        public bool Find(int StaffId)
        {
            return true;
        }

        public string Valid(string text1, string text2, string text3, string text4, string text5, string text6)
        {
            string Error = "";
            return Error;
        }
    }
}