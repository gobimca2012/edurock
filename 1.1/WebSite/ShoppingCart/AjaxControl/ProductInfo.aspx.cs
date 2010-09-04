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
using Common;
using BusinessLogic.ShoppingCartController;

public partial class ShoppingCart_AjaxControl_ProductInfo : AjaxPage
{




    private void AddData()
    {
        try
        {

            int ProductID = 0;

            string Name; if (false) { throw new Exception(""); } Name = HtmlHelper.ControlValue(txtName.ClientID);

            int ItemType = (int)ShoppingCartItemTypeEnum.Product;

            decimal Price; if (false) { throw new Exception(""); } Price = Convert.ToDecimal(HtmlHelper.ControlValue(txtPrice.ClientID));

            string QuantityText; if (false) { throw new Exception(""); } QuantityText = HtmlHelper.ControlValue(txtQuantityText.ClientID);

            string ApplicationURL; if (false) { throw new Exception(""); } ApplicationURL = HtmlHelper.ControlValue(txtApplicationURL.ClientID);

            string Description; if (false) { throw new Exception(""); } Description = HtmlHelper.ControlValue(txtDescription.ClientID);

            string MetaDescription; if (false) { throw new Exception(""); } MetaDescription = HtmlHelper.ControlValue(txtMetaDescription.ClientID);

            DateTime ModifiedDate = DateTime.Now;

            new ProductController().Add(ProductID, Name, ItemType, Price, QuantityText, ApplicationURL, Description, MetaDescription, ModifiedDate);
            Response.Redirect("~/Admin/Ajaxer/CourceInfoView.aspx");
        }
        catch (Exception ex)
        {
            divMessage.InnerHtml = "<div class='error'>" + ex.Message + "</div>";
        }
    }

    private void EditData()
    {
        try
        {

            int ProductID = ID;

            string Name; if (false) { throw new Exception(""); } Name = HtmlHelper.ControlValue(txtName.ClientID);

            int ItemType = (int)ShoppingCartItemTypeEnum.Product;

            decimal Price; if (false) { throw new Exception(""); } Price = Convert.ToDecimal(HtmlHelper.ControlValue(txtPrice.ClientID));

            string QuantityText; if (false) { throw new Exception(""); } QuantityText = HtmlHelper.ControlValue(txtQuantityText.ClientID);

            string ApplicationURL; if (false) { throw new Exception(""); } ApplicationURL = HtmlHelper.ControlValue(txtApplicationURL.ClientID);

            string Description; if (false) { throw new Exception(""); } Description = HtmlHelper.ControlValue(txtDescription.ClientID);

            string MetaDescription; if (false) { throw new Exception(""); } MetaDescription = HtmlHelper.ControlValue(txtMetaDescription.ClientID);

            DateTime ModifiedDate = DateTime.Now;

            new ProductController().UpdateByProductID(ProductID, Name, ItemType, Price, QuantityText, ApplicationURL, Description, MetaDescription, ModifiedDate);

            Response.Redirect("~/Admin/Ajaxer/CourceInfoView.aspx");
        }
        catch (Exception ex)
        {
            divMessage.InnerHtml = "<div class='error'>" + ex.Message + "</div>";
        }
    }

    private void BindData()
    {
        var dataBunch = new ProductController().GetbyProductID(ID);
        if (dataBunch.Count > 0)
        {
            var data = dataBunch[0];

           

            txtName.Text = data.Name;
            txtPrice.Text = data.Price.ToString();
     


            txtQuantityText.Text = data.QuantityText;

            txtApplicationURL.Text = data.ApplicationURL;

            txtDescription.Text = data.Description;

            txtMetaDescription.Text = data.MetaDescription;

            

        }
    }

    private int ID
    {
        get
        {
            return Convert.ToInt32(AjaxState["pdid"]);
        }
    }
    protected void AddAjaxClick(object sender, AjaxControl.AjaxEventArg e)
    {
        AddData();

    }
    protected void UpdateAjaxClick(object sender, AjaxControl.AjaxEventArg e)
    {
        EditData();

    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["pdid"] != null)
        {
            AjaxState["pdid"] = Request.Params["pdid"];
            BindData();
            lnkAddProduct.Visible = false;
        }
        else
        {
            //new CourceCatagoryController().BindCourceCatagory(ddCatagory);
            lnkUpdateProduct.Visible = false;
        }
    }

    public void PreventData()
    {



        txtName.Text = HtmlHelper.ControlValue(txtName.ClientID);

        txtPrice.Text = HtmlHelper.ControlValue(txtPrice.ClientID);

        txtQuantityText.Text = HtmlHelper.ControlValue(txtQuantityText.ClientID);

        txtApplicationURL.Text = HtmlHelper.ControlValue(txtApplicationURL.ClientID);

        txtDescription.Text = HtmlHelper.ControlValue(txtDescription.ClientID);

        txtMetaDescription.Text = HtmlHelper.ControlValue(txtMetaDescription.ClientID);



    }
		

}
