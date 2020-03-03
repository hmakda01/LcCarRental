using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarRentalClasses;

public partial class CarViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clscar
        clsCar AnCar = new clsCar();
        //get the data from the session object
        AnCar = (clsCar)Session["AnCarName"];
        AnCar = (clsCar)Session["AnCarReg"];
        AnCar = (clsCar)Session["AnCarModel"];
        AnCar = (clsCar)Session["AnEngineSize"];
        AnCar = (clsCar)Session["AnColour"];
        AnCar = (clsCar)Session["AnPrice"];
        //display the car for this entity
        Response.Write(AnCar.CarName);
    }
}