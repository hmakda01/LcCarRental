using CarRentalClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Staff : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsStaff AStaff = new clsStaff();
        //capture the staff nanme
        AStaff.StaffFirstName = txtStaffFirstName.Text;
        AStaff.StaffLastName = txtStaffLastName.Text;
       // AStaff.StaffEmail = txtStaffEmail.Text;
        //AStaff.StaffTelephone = Convert.ToInt32(txtTelephone.Text);
        //AStaff.StaffDateOfBirth = Convert.ToDateTime(txtStaffDateOfBirth.Text);
        Session["AStaff"] = AStaff;
        Response.Redirect("StaffViewer.aspx");
    }
}