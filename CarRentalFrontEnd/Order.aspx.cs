using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarRentalClasses;
public partial class Order : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnOK_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        AnOrder.CarReg = Convert.ToInt32(TxtBCarReg.Text);
        Session["AnOrder"] = AnOrder;
        Response.Redirect("Orderviewer.aspx");
    }
}