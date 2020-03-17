using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarRentalClasses;

public partial class StaffList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            //update 
            DisplayStaff();
        }
    }

    void DisplayStaff()
    {
        //cerrtae an insance of the class
        clsStaffCollection Staff = new clsStaffCollection();
        //set the dat aosurce
        lstStaff.DataSource = Staff.StaffList;
        //set thename if hteprimary key
        lstStaff.DataValueField = "StaffId";
        //set the data field to display
        lstStaff.DataTextField = "StaffLastName";
        //bimd the data to the list
        lstStaff.DataBind();

    }



    protected void lstStaff_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object 
        Session["StaffId"] = -1;
        //redirect to the entry page
        Response.Redirect("AStaff.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value tro be stored
        Int32 StaffId;
        //if a record has been selected form the list
        if(lstStaff.SelectedIndex != -1)
        {
            //get the primary value to delete
            StaffId = Convert.ToInt32(lstStaff.SelectedValue);
            //store the data
            Session["StaffId"] = StaffId;
            //redirect back
            Response.Redirect("DeleteStaff.aspx");
        }
        else
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }

    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value tro be stored
        Int32 StaffId;
        //if a record has been selected form the list o be edieted
        if (lstStaff.SelectedIndex != -1)
        {
            //get the primary value to delete
            StaffId = Convert.ToInt32(lstStaff.SelectedValue);
            //store the data
            Session["StaffId"] = StaffId;
            //redirect back
            Response.Redirect("AStaff.aspx");
        }
        else
        {
            //display an error
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        
    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {

    }
}