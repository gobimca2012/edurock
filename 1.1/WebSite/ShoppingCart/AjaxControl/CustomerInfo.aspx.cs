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

public partial class ShoppingCart_AjaxControl_CustomerInfo : AjaxPage
{


    private void AddData()
    {
        try
        {

            Guid CustomerInfoID = Guid.NewGuid();

            string UserID = new UserAuthontication().LoggedInUserID.ToString();

            string FirstName; if (false) { throw new Exception(""); } FirstName = HtmlHelper.ControlValue(txtFirstName.ClientID);

            string LastName; if (false) { throw new Exception(""); } LastName = HtmlHelper.ControlValue(txtLastName.ClientID);

            string MobileNumber; if (false) { throw new Exception(""); } MobileNumber = HtmlHelper.ControlValue(txtMobileNumber.ClientID);

            string OfficeNumber; if (false) { throw new Exception(""); } OfficeNumber = HtmlHelper.ControlValue(txtOfficeNumber.ClientID);

            string Fax; if (false) { throw new Exception(""); } Fax = HtmlHelper.ControlValue(txtFax.ClientID);

            string businessEmail; if (false) { throw new Exception(""); } businessEmail = HtmlHelper.ControlValue(txtbusinessEmail.ClientID);

            int CurrencyCode = 1;

            string BillingFirstName; if (false) { throw new Exception(""); } BillingFirstName = HtmlHelper.ControlValue(txtBillingFirstName.ClientID);

            string BillingLastName; if (false) { throw new Exception(""); } BillingLastName = HtmlHelper.ControlValue(txtBillingLastName.ClientID);

            string BillingAddress1; if (false) { throw new Exception(""); } BillingAddress1 = HtmlHelper.ControlValue(txtBillingAddress1.ClientID);

            string BillingAddress2; if (false) { throw new Exception(""); } BillingAddress2 = HtmlHelper.ControlValue(txtBillingAddress2.ClientID);

            string BillingCity; if (false) { throw new Exception(""); } BillingCity = HtmlHelper.ControlValue(txtBillingCity.ClientID);

            string billingStateProvince; if (false) { throw new Exception(""); } billingStateProvince = HtmlHelper.ControlValue(txtbillingStateProvince.ClientID);

            string billingCountry; if (false) { throw new Exception(""); } billingCountry = HtmlHelper.ControlValue(txtbillingCountry.ClientID);

            string BillingEmail; if (false) { throw new Exception(""); } BillingEmail = HtmlHelper.ControlValue(txtBillingEmail.ClientID);

            DateTime ModifiedDate = DateTime.Now;// ; if (false) { throw new Exception(""); } ModifiedDate = Convert.ToDateTime(HtmlHelper.ControlValue(txtModifiedDate.ClientID));

            new CustomerInfoController().Add(CustomerInfoID, UserID, FirstName, LastName, MobileNumber, OfficeNumber, Fax, businessEmail, CurrencyCode, BillingFirstName, BillingLastName, BillingAddress1, BillingAddress2, BillingCity, billingStateProvince, billingCountry, BillingEmail, ModifiedDate);
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

            Guid CustomerInfoID = ID;

            string UserID = new UserAuthontication().LoggedInUserID.ToString();

            string FirstName; if (false) { throw new Exception(""); } FirstName = HtmlHelper.ControlValue(txtFirstName.ClientID);

            string LastName; if (false) { throw new Exception(""); } LastName = HtmlHelper.ControlValue(txtLastName.ClientID);

            string MobileNumber; if (false) { throw new Exception(""); } MobileNumber = HtmlHelper.ControlValue(txtMobileNumber.ClientID);

            string OfficeNumber; if (false) { throw new Exception(""); } OfficeNumber = HtmlHelper.ControlValue(txtOfficeNumber.ClientID);

            string Fax; if (false) { throw new Exception(""); } Fax = HtmlHelper.ControlValue(txtFax.ClientID);

            string businessEmail; if (false) { throw new Exception(""); } businessEmail = HtmlHelper.ControlValue(txtbusinessEmail.ClientID);

            int CurrencyCode=1;

            string BillingFirstName; if (false) { throw new Exception(""); } BillingFirstName = HtmlHelper.ControlValue(txtBillingFirstName.ClientID);

            string BillingLastName; if (false) { throw new Exception(""); } BillingLastName = HtmlHelper.ControlValue(txtBillingLastName.ClientID);

            string BillingAddress1; if (false) { throw new Exception(""); } BillingAddress1 = HtmlHelper.ControlValue(txtBillingAddress1.ClientID);

            string BillingAddress2; if (false) { throw new Exception(""); } BillingAddress2 = HtmlHelper.ControlValue(txtBillingAddress2.ClientID);

            string BillingCity; if (false) { throw new Exception(""); } BillingCity = HtmlHelper.ControlValue(txtBillingCity.ClientID);

            string billingStateProvince; if (false) { throw new Exception(""); } billingStateProvince = HtmlHelper.ControlValue(txtbillingStateProvince.ClientID);

            string billingCountry; if (false) { throw new Exception(""); } billingCountry = HtmlHelper.ControlValue(txtbillingCountry.ClientID);

            string BillingEmail; if (false) { throw new Exception(""); } BillingEmail = HtmlHelper.ControlValue(txtBillingEmail.ClientID);

            DateTime ModifiedDate = DateTime.Now;// ; if (false) { throw new Exception(""); } ModifiedDate = Convert.ToDateTime(HtmlHelper.ControlValue(txtModifiedDate.ClientID));

            new CustomerInfoController().UpdateByCustomerInfoID(CustomerInfoID, UserID, FirstName, LastName, MobileNumber, OfficeNumber, Fax, businessEmail, CurrencyCode, BillingFirstName, BillingLastName, BillingAddress1, BillingAddress2, BillingCity, billingStateProvince, billingCountry, BillingEmail, ModifiedDate);

            Response.Redirect("~/Admin/Ajaxer/CourceInfoView.aspx");
        }
        catch (Exception ex)
        {
            divMessage.InnerHtml = "<div class='error'>" + ex.Message + "</div>";
        }
    }

    private void BindData()
    {
        var dataBunch = new CustomerInfoController().GetbyUserID(new UserAuthontication().LoggedInUserID.ToString());
        if (dataBunch.Count > 0)
        {
            var data = dataBunch[0];
            txtFirstName.Text = data.FirstName;

            txtLastName.Text = data.LastName;

            txtMobileNumber.Text = data.MobileNumber;

            txtOfficeNumber.Text = data.OfficeNumber;

            txtFax.Text = data.Fax;

            txtbusinessEmail.Text = data.businessEmail;

            

            txtBillingFirstName.Text = data.BillingFirstName;

            txtBillingLastName.Text = data.BillingLastName;

            txtBillingAddress1.Text = data.BillingAddress1;

            txtBillingAddress2.Text = data.BillingAddress2;

            txtBillingCity.Text = data.BillingCity;

            txtbillingStateProvince.Text = data.billingStateProvince;

            txtbillingCountry.Text = data.billingCountry;

            txtBillingEmail.Text = data.BillingEmail;



        }
    }

    private Guid ID
    {
        get
        {
            return new Guid(AjaxState["suid"]);
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
        if (Request.Params["suid"] != null)
        {
            AjaxState["suid"] = Request.Params["suid"];
            BindData();
            lnkAddCustomerInfo.Visible = false;
        }
        else
        {
            //new CourceCatagoryController().BindCourceCatagory(ddCatagory);
            lnkUpdateCustomerInfo.Visible = false;
        }
        if (new UserAuthontication().IsLoggedIn)
        {
            BindData();
        }
    }

    public void PreventData()
    {





        txtFirstName.Text = HtmlHelper.ControlValue(txtFirstName.ClientID);

        txtLastName.Text = HtmlHelper.ControlValue(txtLastName.ClientID);

        txtMobileNumber.Text = HtmlHelper.ControlValue(txtMobileNumber.ClientID);

        txtOfficeNumber.Text = HtmlHelper.ControlValue(txtOfficeNumber.ClientID);

        txtFax.Text = HtmlHelper.ControlValue(txtFax.ClientID);

        txtbusinessEmail.Text = HtmlHelper.ControlValue(txtbusinessEmail.ClientID);



        txtBillingFirstName.Text = HtmlHelper.ControlValue(txtBillingFirstName.ClientID);

        txtBillingLastName.Text = HtmlHelper.ControlValue(txtBillingLastName.ClientID);

        txtBillingAddress1.Text = HtmlHelper.ControlValue(txtBillingAddress1.ClientID);

        txtBillingAddress2.Text = HtmlHelper.ControlValue(txtBillingAddress2.ClientID);

        txtBillingCity.Text = HtmlHelper.ControlValue(txtBillingCity.ClientID);

        txtbillingStateProvince.Text = HtmlHelper.ControlValue(txtbillingStateProvince.ClientID);

        txtbillingCountry.Text = HtmlHelper.ControlValue(txtbillingCountry.ClientID);

        txtBillingEmail.Text = HtmlHelper.ControlValue(txtBillingEmail.ClientID);



    }

}
