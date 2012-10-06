using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderComplete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string message = "";
        if (Request.QueryString["st"] == "1")
        {
            message = "Your order has been completed.</br>you can now login to crameasy using your username and password";
        }
        else
        {
            message = "Please try letter we encounter problem in your transaction";
        }
        divMessage.InnerHtml = message;
    }
}