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
using DataEntity;
using BusinessLogic.ShoppingCartController;

public partial class ShoppingCart_AjaxControl_ConfirmShopping : AjaxPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        BindData();
    }
    private void BindData()
    {
        Product data = (Product)Session[BusinessLogic.ShoppingCartController.SessionName.Product.ToString()];
        lblTitle.InnerText = data.Name;
        lblPricePerItem.InnerText = data.Price.ToString();
        lblQuantity.InnerText = Session[BusinessLogic.ShoppingCartController.SessionName.Quantity.ToString()].ToString();
        lblQuantityText.InnerText = data.QuantityText;
        lblTotalPrice.InnerText = (data.Price * Convert.ToInt32(Session[BusinessLogic.ShoppingCartController.SessionName.Quantity.ToString()].ToString())).ToString();
        
    }
    protected void AjaxConfirmClick(object sender, AjaxControl.AjaxEventArg e)
    {
        
    }
}
