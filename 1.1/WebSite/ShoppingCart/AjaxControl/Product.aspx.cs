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

public partial class ShoppingCart_AjaxControl_Product : AjaxPage
{

    private void BindData(int ID)
    {
        var dataBunch = new ProductController().GetbyProductID(ID);
        if (dataBunch.Count > 0)
        {
            var data = dataBunch[0];
            if (data.ProductID != null)
            {
                lblProductID.InnerHtml = data.ProductID.ToString();
                lnkBuy.NavigateUrl = ResolveUrl("~/ShoppingCart/AjaxControl/AddQuantity.aspx") + "?pdid=" + data.ProductID.ToString();
            }

            if (data.Name != null)

                lblName.InnerHtml = data.Name.ToString();

            if (data.ItemType != null)

                lblItemType.InnerHtml = data.ItemType.ToString();

            if (data.Price != null)

                lblPrice.InnerHtml = data.Price.ToString();

            if (data.QuantityText != null)

                lblQuantityText.InnerHtml = data.QuantityText.ToString();

            if (data.ApplicationURL != null)

                lblApplicationURL.InnerHtml = data.ApplicationURL.ToString();

            if (data.Description != null)

                lblDescription.InnerHtml = data.Description.ToString();

            if (data.MetaDescription != null)

                lblMetaDescription.InnerHtml = data.MetaDescription.ToString();

            if (data.ModifiedDate != null)

                lblModifiedDate.InnerHtml = data.ModifiedDate.ToString();
        }

    }

    private int ID
    {
        get
        {
            return Convert.ToInt32(Request.Params["qid"]);
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        BindData(ID);
    }

}
