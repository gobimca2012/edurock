using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using BusinessLogic;
using BusinessLogic.ShoppingCartController;

public partial class ShoppingCart_AjaxControl_AddToCart :AjaxPage
{
    private int ID
    {
        get
        {
            if (Request.Params["pdid"] != null)
            {
                AjaxState["pdid"] = Request.Params["pdid"];
                return Convert.ToInt32(AjaxState["pdid"]);
            }
            else if (AjaxState["pdid"] != null)
            {
                return Convert.ToInt32(AjaxState["pdid"]);
            }
            else
            {
                return 0;
            }
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        BindData();
    }
    private void BindData()
    {
        var dataBunch = new ProductController().GetbyProductID(ID);
        if (dataBunch.Count > 0)
        {
            var data = dataBunch[0];
            lblTitle.InnerText = data.Name;
            lblQuantityText.InnerText = data.QuantityText;
            Session[BusinessLogic.ShoppingCartController.SessionName.Product.ToString()] = data;
        }
    }
    protected void AjaxNextClick(object sender, AjaxControl.AjaxEventArg e)
    {
        int Quantity =Convert.ToInt32( HtmlHelper.ControlValue(txtQuantity.ClientID));
        Session[BusinessLogic.ShoppingCartController.SessionName.Quantity.ToString()] = Quantity;
        Response.Redirect("~/ShoppingCart/AjaxControl/CustomerInfo.aspx");
        //Response.Redirect("~/ShoppingCart/AjaxControl/ConfirmShopping.aspx");
    }
}
