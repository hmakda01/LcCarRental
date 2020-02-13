using CarRentalClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StaffViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a ne winstance
        clsStaff AStaff = new clsStaff();
        //get tyhe data form the session object
        AStaff = (clsStaff)Session[ "AStaff"];
        //display the 
        Response.Write(AStaff.StaffFirstName);
        Response.Write(AStaff.StaffLastName);
        //Response.Write(AStaff.StaffEmail);
       // Response.Write(AStaff.StaffTelephone);
        //Response.Write(AStaff.StaffDateOfBirth);
        //Response.Write(AStaff.Active);

    }
}