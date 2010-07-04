﻿using System;
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
    protected void Page_Load(object sender, EventArgs e)
    {
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