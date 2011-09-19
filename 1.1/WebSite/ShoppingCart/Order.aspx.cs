using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;

public partial class ShoppingCart_Order : BasePage
{
    protected override void OnInit(EventArgs e)
    {
        IsLogginMandatory = false;
        base.OnInit(e);
    }
    public string ProductVersionID
    {
        get
        {
            if (Request.QueryString["prvid"] != null)
            {
                return Request.QueryString["prvid"];
            }
            else
            {
                return "";
            }
        }

    }
    protected void Page_Load(object sender, EventArgs e)
    {
        objLoader.LoadPage("#accountInfo", ResolveUrl("~/ShoppingCart/AjaxControl/AccountInfo.aspx") + "?prvid=" + ProductVersionID);
        objLoader.LoadPage("#contentBox", ResolveUrl("~/ShoppingCart/AjaxControl/AttributeListDisplay.aspx") + "?prvid=" + ProductVersionID);
        //objLoader.LoadPage("#completeOrder", ResolveUrl("~/ShoppingCart/AjaxControl/CompleteOrder.aspx"));
    }
}