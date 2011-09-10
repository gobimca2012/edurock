using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;

public partial class ShoppingCart_Product : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //objLoader.LoadPage("#prdoductinfo", ResolveUrl("~/ShoppingCart/AjaxControl/ProductInfo.aspx"));
        objLoader.LoadPage("#contentBox", ResolveUrl("~/ShoppingCart/AjaxControl/ProductInfoView.aspx"));
    }
}