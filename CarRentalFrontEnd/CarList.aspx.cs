using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CarList : System.Web.UI.Page
{
    //this function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list 
            DisplayCars();
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
        lstCars.DataValueField = "Reg Plate";
        //bind the data to the list
        lstCars.DataBind();
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {

    }

    //event handlert for the delete button
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
}