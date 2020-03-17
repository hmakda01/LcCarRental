using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarRentalClasses;

public partial class CarList : System.Web.UI.Page
{
    Int32 CarID;
    //this function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        CarID = Convert.ToInt32(Session["CarID"]);
        if (IsPostBack == false)
        {
            //update the list 
            DisplayCars();
            //if this new record
            if (CarID != -1)
            {
                //display the current data for the record
                DisplayCars();
            }
        }
    }

    void DisplayCars()
    {
        //create an instance of the county collection 
        CarRentalClasses.clsCarCollection Cars = new CarRentalClasses.clsCarCollection();
        //set the data source to the list of counties in the collection
        lstCars.DataSource = Cars.CarList;
        //set the name of the primariy key
        lstCars.DataValueField = "Id";
        //set the data field to display
        lstCars.DataValueField = "RegPlate";
        //bind the data to the list
        lstCars.DataBind();
    }

    protected void btnDelete_Click1(object sender, EventArgs e)
    {
        //var to store the prim key value of the record to be deleted
        Int32 CarID;
        //if a record has been seleced from the list
        if (lstCars.SelectedIndex != -1)
        {
            //get the prim key value of record to delete
            CarID = Convert.ToInt32(lstCars.SelectedValue);
            //store the data in the section object
            Session["CarID"] = CarID;
            //redirect to the delte page
            Response.Redirect("Delete.aspx");
        }
        else //if no record has been selected 
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 CarID;
        //if a record has been selected from the list
        if (lstCars.SelectedIndex != -1)
        {
            //get the prim key value of the record to edit
            CarID = Convert.ToInt32(lstCars.SelectedValue);
            //store the data in the session object
            Session["CarID"] = CarID;
            //redirect to the edit page
            Response.Redirect("Car.aspx");
        }
        else
        //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to Edit from the list";
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {

        //store -1 into the session object to indicate this is a new record 
        Session["CarID"] = -1;
        //redirect to the data entry page
        Response.Redirect("Car.aspx");
    }


    //bellow named car name but use for reg search because car list is reg
    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {

    }

    protected void tctCNSearch_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnApply_Click(object sender, EventArgs e)
    {

    }
}