using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRentalClasses
{
    public class clsStaff
    {
        
        public string StaffFirstName { get; set; }
        public string StaffLastName { get; set; }
        public string StaffEmail { get; set; }
        public int StaffTelephone { get; set; }
        public DateTime StaffDateOfBirth { get; set; }
        public bool Active { get; set; }
    }
}