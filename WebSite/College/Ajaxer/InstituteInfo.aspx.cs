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

public partial class College_Ajaxer_InstituteInfo : AjaxPage
{
    private void FormValidation()
    {
        lnkUpdate.EnableValidation = true;

        JScripter.Validation objValidate = new JScripter.Validation(this.Page, lnkUpdate.ClientID);
        
        objValidate.DrowDownMendatory(ddCollegeType, "Please select Institute Type ", this.Page, "0");
        
        objValidate.Medatory(txtAddress, "Please enter Address", this.Page);
        objValidate.Medatory(txtCityName, "Please enter City Name", this.Page);
        objValidate.Medatory(txtCountryName, "Please enter Country", this.Page);
        objValidate.Medatory(txtEmail, "Please enter Email Address", this.Page);
        objValidate.Medatory(txtName, "Please enter Institute Name", this.Page);
        objValidate.Medatory(txtShortName, "Please enter Institute Short Name", this.Page);
        objValidate.Medatory(txtStateName, "Please enter State Name", this.Page);
        objValidate.Medatory(txtTelePhone, "Please enter Telephone Number", this.Page);
        objValidate.Medatory(txtWebSite, "Please enter Institute Website", this.Page);
        objValidate.Email(txtEmail, "Please enter valid Email Address", this.Page);
        objValidate.DigitOnly(txtTelePhone, "Please enter Valid Telephone Number", this.Page);
        objValidate.MinimumLength(txtTelePhone, "Please enter Valid Telephone Number", this.Page,"10");


    }
    protected void Page_Load(object sender, EventArgs e)
    {
        FormValidation();
        new JScripter.TinyMCE(this.Page).Create();
        BindData();
    }

    private void AddData()
    {
        try
        {

            

            int LoginUserID; if (false) { throw new Exception(""); } LoginUserID = new UserAuthontication().LoggedInUserID;

            string Name; if (false) { throw new Exception(""); } Name = HtmlHelper.ControlValue(txtName.ClientID);

            string Address; if (false) { throw new Exception(""); } Address = HtmlHelper.ControlValue(txtAddress.ClientID);

            string CityName; if (false) { throw new Exception(""); } CityName = HtmlHelper.ControlValue(txtCityName.ClientID);

            string StateName; if (false) { throw new Exception(""); } StateName = HtmlHelper.ControlValue(txtStateName.ClientID);

            string CountryName; if (false) { throw new Exception(""); } CountryName = HtmlHelper.ControlValue(txtCountryName.ClientID);

            string TelePhone; if (false) { throw new Exception(""); } TelePhone = HtmlHelper.ControlValue(txtTelePhone.ClientID);

            string Fax; if (false) { throw new Exception(""); } Fax = HtmlHelper.ControlValue(txtFax.ClientID);

            string Email; if (false) { throw new Exception(""); } Email = HtmlHelper.ControlValue(txtEmail.ClientID);

            string WebSite; if (false) { throw new Exception(""); } WebSite = HtmlHelper.ControlValue(txtWebSite.ClientID);

            int CollegeType; if (false) { throw new Exception(""); } CollegeType = Convert.ToInt32(HtmlHelper.ControlValue(ddCollegeType.ClientID));

            string ShortName; if (false) { throw new Exception(""); } ShortName = HtmlHelper.ControlValue(txtShortName.ClientID);

            string Description; if (false) { throw new Exception(""); } Description = HtmlHelper.ControlValue(txtDescription.ClientID);

            DateTime ModifiedDate = DateTime.Now;

            bool IsDeleted = false;

            new InstituteController().Add(LoginUserID, Name, Address, CityName, StateName, CountryName, TelePhone, Fax, Email, WebSite, CollegeType, ShortName, Description, ModifiedDate, IsDeleted);
        }
        catch (Exception ex)
        {
            divMessage.InnerHtml = "<div class='error'>" + ex.Message + "</div>";
        }
    }

    private void EditData()
    {
        Guid PID = ID;


        int LoginUserID; if (false) { throw new Exception(""); } LoginUserID = new UserAuthontication().LoggedInUserID;

        string Name; if (false) { throw new Exception(""); } Name = HtmlHelper.ControlValue(txtName.ClientID);

        string Address; if (false) { throw new Exception(""); } Address = HtmlHelper.ControlValue(txtAddress.ClientID);

        string CityName; if (false) { throw new Exception(""); } CityName = HtmlHelper.ControlValue(txtCityName.ClientID);

        string StateName; if (false) { throw new Exception(""); } StateName = HtmlHelper.ControlValue(txtStateName.ClientID);

        string CountryName; if (false) { throw new Exception(""); } CountryName = HtmlHelper.ControlValue(txtCountryName.ClientID);

        string TelePhone; if (false) { throw new Exception(""); } TelePhone = HtmlHelper.ControlValue(txtTelePhone.ClientID);

        string Fax; if (false) { throw new Exception(""); } Fax = HtmlHelper.ControlValue(txtFax.ClientID);

        string Email; if (false) { throw new Exception(""); } Email = HtmlHelper.ControlValue(txtEmail.ClientID);

        string WebSite; if (false) { throw new Exception(""); } WebSite = HtmlHelper.ControlValue(txtWebSite.ClientID);

        int CollegeType; if (false) { throw new Exception(""); } CollegeType = Convert.ToInt32(HtmlHelper.ControlValue(ddCollegeType.ClientID));

        string ShortName; if (false) { throw new Exception(""); } ShortName = HtmlHelper.ControlValue(txtShortName.ClientID);

        string Description; if (false) { throw new Exception(""); } Description = HtmlHelper.ControlValue(txtDescription.ClientID);

        DateTime ModifiedDate = DateTime.Now;

        bool IsDeleted = false;

        new InstituteController().UpdateByLoginUserID(LoginUserID, Name, Address, CityName, StateName, CountryName, TelePhone, Fax, Email, WebSite, CollegeType, ShortName, Description, ModifiedDate, IsDeleted);
        Session[SessionName.SucessMessage.ToString()] = string.Format("{0} {1} has been Updated Successfully", "", ShortName);
    }

    private void BindData()
    {
        var dataBunch = new InstituteController().GetbyLoginUserID(new UserAuthontication().LoggedInUserID);
        if (dataBunch.Count > 0)
        {
            var data = dataBunch[0];

            
            txtName.Text = data.Name;

            txtAddress.Text = data.Address;

            txtCityName.Text = data.CityName;

            txtStateName.Text = data.StateName;

            txtCountryName.Text = data.CountryName;

            txtTelePhone.Text = data.TelePhone;

            txtFax.Text = data.Fax;

            txtEmail.Text = data.Email;

            txtWebSite.Text = data.WebSite;

            ddCollegeType.SelectedValue = data.CollegeType.ToString();

            txtShortName.Text = data.ShortName;

            txtDescription.Text = data.Description;

            

        }
    }

    private Guid ID
    {
        get
        {
            if (Request.QueryString["type"] != null)
            {
                if (Request.QueryString["id"] != null)
                {
                    return new Guid(Request.QueryString["id"]);
                }
                else
                {
                    return Guid.Empty;
                }
            }
            else
            {
                return Guid.Empty;
            }
        }



    }
    private bool IsEdit
    {
        get
        {
            if (Request.QueryString["type"] != null)
            {
                if (Request.QueryString["id"] != null)
                {

                    //			ID = new Guid(Request.QueryString["id"]);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

    }

    protected void UpdateAjaxClick(object sender, AjaxControl.AjaxEventArg e)
    {
        var data = new InstituteController().GetbyLoginUserID(new UserAuthontication().LoggedInUserID);
        if (data.Count > 0)
        {
            EditData();
        }
        else
        {
            AddData();
        }
        Response.Redirect("~/College/Ajaxer/InstituteInfoView.aspx");
    }
}
