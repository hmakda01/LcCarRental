using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarRentalClasses;

public partial class Delete : System.Web.UI.Page
{

    //var to store the primary key value
    Int32 StaffId;
    protected void Page_Load(object sender, EventArgs e)
    {
        StaffId = Convert.ToInt32(Session["StaffId"]);
    }

    void DeleteStaff()
    {
        //cratae a new instance for the class
        clsStaffCollection StaffBook = new clsStaffCollection();
        //finsd the record to delete
        StaffBook.ThisStaff.Find(StaffId);
        //delete the record
        StaffBook.Delete();
    }

    protected void btnYES_Click(object sender, EventArgs e)
    {
        //delete the staff
        DeleteStaff();
        //redierect back to amin page
        Response.Redirect("StaffList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffList.aspx");
    }
}