using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;
using BusinessLogic.Controllers;

public partial class ShoppingCart_AjaxControl_ProductInfo : AjaxPage
{


    private void AddData()
    {
        try
        {

            Guid ProductID; if (false) { throw new Exception(""); } ProductID = Guid.NewGuid();

            string Name; if (false) { throw new Exception(""); } Name = HtmlHelper.ControlValue(txtName.ClientID);

            string Description; if (false) { throw new Exception(""); } Description = HtmlHelper.ControlValue(txtDescription.ClientID);

            string ShortDescription; if (false) { throw new Exception(""); } ShortDescription = HtmlHelper.ControlValue(txtShortDescription.ClientID);

            DateTime ModifiedDate; if (false) { throw new Exception(""); } ModifiedDate = DateTime.Now;

            new ProductController().Add(ProductID, Name, Description, ShortDescription, ModifiedDate);
            Response.Redirect("~/ShoppingCart/AjaxControl/ProductInfoView.aspx");
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

            Guid ProductID; if (false) { throw new Exception(""); } ProductID = ID;

            string Name; if (false) { throw new Exception(""); } Name = HtmlHelper.ControlValue(txtName.ClientID);

            string Description; if (false) { throw new Exception(""); } Description = HtmlHelper.ControlValue(txtDescription.ClientID);

            string ShortDescription; if (false) { throw new Exception(""); } ShortDescription = HtmlHelper.ControlValue(txtShortDescription.ClientID);

            DateTime ModifiedDate; if (false) { throw new Exception(""); } ModifiedDate = DateTime.Now;

            new ProductController().UpdateByProductID(ProductID, Name, Description, ShortDescription, ModifiedDate);

            Response.Redirect("~/ShoppingCart/AjaxControl/ProductInfoView.aspx");
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

            txtDescription.Text = data.Description;

            txtShortDescription.Text = data.ShortDescription;

            
        }
    }

    private Guid ID
    {
        get
        {
            return new Guid(AjaxState["prid"]);
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
        if (Request.Params["prid"] != null)
        {
            AjaxState["prid"] = Request.Params["prid"];
            BindData();
            lnkAdd.Visible = false;
        }
        else
        {
            //new CourceCatagoryController().BindCourceCatagory(ddCatagory);
            lnkUpdate.Visible = false;
        }
    }

    public void PreventData()
    {

        
        txtName.Text = HtmlHelper.ControlValue(txtName.ClientID);

        txtDescription.Text = HtmlHelper.ControlValue(txtDescription.ClientID);

        txtShortDescription.Text = HtmlHelper.ControlValue(txtShortDescription.ClientID);

        
    }
		
}