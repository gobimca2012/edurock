using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;
using BusinessLogic.Controllers;

public partial class ShoppingCart_AjaxControl_ProductVersion : AjaxPage
{


    private void AddData()
    {
        try
        {

            Guid ProductVersionID; if (false) { throw new Exception(""); } ProductVersionID = Guid.NewGuid();

            Guid ProductID; if (false) { throw new Exception(""); } ProductID = _ProductID;

            string Name; if (false) { throw new Exception(""); } Name = HtmlHelper.ControlValue(txtName.ClientID);

            string Description; if (false) { throw new Exception(""); } Description = HtmlHelper.ControlValue(txtDescription.ClientID);

            string ShortDescription; if (false) { throw new Exception(""); } ShortDescription = HtmlHelper.ControlValue(txtShortDescription.ClientID);

            string QuantityIn; if (false) { throw new Exception(""); } QuantityIn = HtmlHelper.ControlValue(txtQuantityIn.ClientID);

            bool IsRecuringPrice = false; if (false) { throw new Exception(""); } if (HtmlHelper.ControlValue(chkIsRecuringPrice.ClientID) != "")
                if (HtmlHelper.ControlValue(chkIsRecuringPrice.ClientID) == "on")
                    IsRecuringPrice = true;


            decimal Discount; if (false) { throw new Exception(""); } Discount = Convert.ToDecimal(HtmlHelper.ControlValue(txtDiscount.ClientID));
            decimal Price; if (false) { throw new Exception(""); } Price = Convert.ToDecimal(HtmlHelper.ControlValue(txtPrice.ClientID));
            int RecurringTime; if (false) { throw new Exception(""); } RecurringTime = Convert.ToInt32(HtmlHelper.ControlValue(txtRecurringTime.ClientID));

            DateTime ModifiedDate; if (false) { throw new Exception(""); } ModifiedDate = DateTime.Now;

            new ProductVersionController().Add(ProductVersionID, ProductID, Name, Description, ShortDescription, IsRecuringPrice,RecurringTime,QuantityIn, Price, Discount, ModifiedDate);
            Response.Redirect("~/ShoppingCart/AjaxControl/ProductVersionInfoView.aspx?prid=" + _ProductID.ToString());
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

            Guid ProductVersionID; if (false) { throw new Exception(""); } ProductVersionID = ID;

            Guid ProductID; if (false) { throw new Exception(""); } ProductID = _ProductID;

            string Name; if (false) { throw new Exception(""); } Name = HtmlHelper.ControlValue(txtName.ClientID);

            string Description; if (false) { throw new Exception(""); } Description = HtmlHelper.ControlValue(txtDescription.ClientID);

            string ShortDescription; if (false) { throw new Exception(""); } ShortDescription = HtmlHelper.ControlValue(txtShortDescription.ClientID);

            bool IsRecuringPrice = false; if (false) { throw new Exception(""); } if (HtmlHelper.ControlValue(chkIsRecuringPrice.ClientID) != "")
                if (HtmlHelper.ControlValue(chkIsRecuringPrice.ClientID) == "on")
                    IsRecuringPrice = true;

            decimal Price; if (false) { throw new Exception(""); } Price = Convert.ToDecimal(HtmlHelper.ControlValue(txtPrice.ClientID));
            int RecurringTime; if (false) { throw new Exception(""); } RecurringTime = Convert.ToInt32(HtmlHelper.ControlValue(txtRecurringTime.ClientID));
            decimal Discount; if (false) { throw new Exception(""); } Discount = Convert.ToDecimal(HtmlHelper.ControlValue(txtDiscount.ClientID));

            DateTime ModifiedDate; if (false) { throw new Exception(""); } ModifiedDate = DateTime.Now;

            string QuantityIn; if (false) { throw new Exception(""); } QuantityIn = HtmlHelper.ControlValue(txtQuantityIn.ClientID);

            new ProductVersionController().UpdateByProductVersionID(ProductVersionID, ProductID, Name, Description, ShortDescription, IsRecuringPrice,RecurringTime,QuantityIn, Price, Discount, ModifiedDate);

            Response.Redirect("~/ShoppingCart/AjaxControl/ProductVersionInfoView.aspx?prid="+_ProductID.ToString());
        }
        catch (Exception ex)
        {
            divMessage.InnerHtml = "<div class='error'>" + ex.Message + "</div>";
        }
    }

    private void BindData()
    {
        var dataBunch = new ProductVersionController().GetbyProductVersionID(ID);
        if (dataBunch.Count > 0)
        {
            var data = dataBunch[0];

          
            txtName.Text = data.Name;

            txtDescription.Text = data.Description;

            txtShortDescription.Text = data.ShortDescription;

            chkIsRecuringPrice.Checked = data.IsRecuringPrice.Value;

            txtDiscount.Text = data.Discount.ToString();

          

        }
    }

    private Guid ID
    {
        get
        {
            return new Guid(AjaxState["prvid"]);
        }
    }
    private Guid _ProductID
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
        if (Request.Params["prvid"] != null)
        {
            AjaxState["prvid"] = Request.Params["prvid"];
            BindData();
            lnkAddProductVersion.Visible = false;
        }
        else
        {
           // new CourceCatagoryController().BindCourceCatagory(ddCatagory);
            lnkUpdateProductVersion.Visible = false;
        }
    }

    public void PreventData()
    {

        
        txtName.Text = HtmlHelper.ControlValue(txtName.ClientID);

        txtDescription.Text = HtmlHelper.ControlValue(txtDescription.ClientID);

        txtShortDescription.Text = HtmlHelper.ControlValue(txtShortDescription.ClientID);

        //chkIsRecuringPrice.Checked = (bool)HtmlHelper.ControlValue(chkIsRecuringPrice.ClientID);

        txtDiscount.Text = HtmlHelper.ControlValue(txtDiscount.ClientID);

        
    }
		
}